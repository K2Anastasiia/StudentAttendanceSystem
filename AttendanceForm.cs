using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace StudentAttendanceSystem
{
    public partial class AttendanceForm : Form
    {
        public DataTable AttendanceData { get; set; }
        public int NumberOfClasses { get; set; }
        DataTable table = new DataTable();

        public AttendanceForm()
        {
            InitializeComponent();
            UpdateTeacherInfo();
            AttendanceData = new DataTable();

        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            // Налаштування dataGridView1
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersWidth = 5;
            // Створення структури таблиці "table"
            table.Columns.Add(new DataColumn("№", typeof(int)));
            table.Columns.Add(new DataColumn("Name", typeof(string)));

            if (AttendanceData != null)
            {
                // Додавання стовпців в "table" на основі даних в "AttendanceData"
                foreach (DataColumn column in AttendanceData.Columns)
                {
                    if (column.ColumnName != "№" && column.ColumnName != "Name")
                    {
                        table.Columns.Add(new DataColumn(column.ColumnName, typeof(int)));
                    }
                }

                // Копіювання даних з "AttendanceData" до "table"
                foreach (DataRow row in AttendanceData.Rows)
                {
                    DataRow newRow = table.NewRow();
                    newRow["№"] = row["№"];
                    newRow["Name"] = row["Name"];

                    foreach (DataColumn column in AttendanceData.Columns)
                    {
                        if (column.ColumnName != "№" && column.ColumnName != "Name")
                        {
                            newRow[column.ColumnName] = row[column.ColumnName];
                        }
                    }

                    table.Rows.Add(newRow);
                }
            }

            // Додавання стовпців у "table"
            for (int i = 0; i < NumberOfClasses; i++)
            {
                table.Columns.Add(new DataColumn("" + (i + 1), typeof(string)));
            }
            //Відображення "table" у dataGridView1
            dataGridView1.DataSource = table; // Клонування структури таблиці

            // Оновлення структури таблиці AttendanceData
            AttendanceData = table.Clone(); // Клонування структури таблиці
            for (int i = 0; i < NumberOfClasses; i++)
            {
                AttendanceData.Columns.Add(new DataColumn(" " + (i + 1) + " ", typeof(string)));
            }

            // Перенесення даних з table в AttendanceData
            foreach (DataRow row in table.Rows)
            {
                DataRow newRow = AttendanceData.NewRow();
                newRow["№"] = row["№"];
                newRow["Name"] = row["Name"];

                for (int i = 2; i < table.Columns.Count; i++)
                {
                    newRow[i] = row[i];
                }

                AttendanceData.Rows.Add(newRow);
            }

            // Налаштування dataGridView2
            dataGridView2.AllowUserToAddRows = false;
            if (dataGridView2 != null)
            {
                // Очищення dataGridView2 перед заповненням новими даними
                dataGridView2.Rows.Clear();

                // Додаємо стовпці в dataGridView2, якщо вони відсутні
                if (dataGridView2.Columns.Count == 0)
                {
                    dataGridView2.Columns.Add("№", "№");
                    DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                    checkboxColumn.Name = "Column2";
                    checkboxColumn.HeaderText = "Учет";
                    dataGridView2.Columns.Add(checkboxColumn);
                }
                // Встановлення ширини стовпців
                dataGridView2.Columns["№"].Width = 35; // Встановіть потрібну ширину для стовпця "№"
                dataGridView2.Columns["Column2"].Width = 55; // Встановіть потрібну ширину для стовпця "Облік"
                dataGridView2.RowHeadersWidth = 5; // Встановіть потрібну ширину для області заголовків рядків

                // Заповнення dataGridView2 даними з dataGridView1
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                    cell1.Value = value;
                    DataGridViewCheckBoxCell cell2 = new DataGridViewCheckBoxCell();
                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);
                    dataGridView2.Rows.Add(row);
                }
            }

            //Налаштування numericUpDown1
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = NumberOfClasses;

        }

        // Оновлення інформації про викладача
        private void UpdateTeacherInfo()
        {
            lblFullName.Text = "Name: " + Teacher.FullName;
            lblDiscipline.Text = "Discipline: " + Teacher.Discipline;
        }

        // Обробник події Створити групу
        private void pctrGroup_Click(object sender, EventArgs e)
        {
            this.Close();
            GroupForm groupForm = new GroupForm();
            groupForm.AttendanceData = AttendanceData; // Передача даних AttendanceData назад на форму GroupForm (якщо необхідно)
            groupForm.NumberOfClasses = NumberOfClasses; // Передача даних NumberOfClasses назад на форму GroupForm (якщо необхідно)
            groupForm.Show();
        }

        // Обробник події Виставити відвідуваність
        private void bttnAttendance_Click(object sender, EventArgs e)
        {
            int selectedClass = (int)numericUpDown1.Value;

            string columnName = " " + selectedClass + " ";

            // Знайти індекс стовпця в таблиці AttendanceData
            int columnIndex = -1;
            foreach (DataColumn column in AttendanceData.Columns)
            {
                if (column.ColumnName.Trim() == columnName.Trim())
                {
                    columnIndex = AttendanceData.Columns.IndexOf(column);
                    break;
                }
            }

            if (columnIndex != -1)
            {
                // Оновити значення у стовпці table на основі значень другого стовпця dataGridView2
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    object cellValue = dataGridView2.Rows[i].Cells[1].Value;
                    bool isChecked = (cellValue != null && (bool)cellValue);
                    table.Rows[i][columnIndex] = isChecked ? "+" : "-";
                }

                // Оновити dataGridView1 з оновленою таблицею table
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
                dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            }
            else
            {
                MessageBox.Show("Стовбчик не знайдено.");
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() == "+")
            {
                e.CellStyle.BackColor = Color.GreenYellow;
            }
        }

        //Обробник події підрахунок пропусків
        private void bttnRecord_Click(object sender, EventArgs e)
        {
            //Перевіряємо наявність стовпця з ім'ям "Пропуски" у таблиці table
            if (table.Columns.Contains("Пропуски"))
            {
                //Видаляємо існуючий стовпець "Пропуски"
                table.Columns.Remove("Пропуски");
            }

            //Додаємо новий стовпець "Пропуски" до таблиці table
            table.Columns.Add(new DataColumn("Пропуски", typeof(int)));

            // Обчислюємо кількість знаків "-" у кожному рядку та заповнюємо стовпець "Пропуски"
            foreach (DataRow row in table.Rows)
            {
                int count = 0;
                for (int i = 2; i < table.Columns.Count; i++)
                {
                    string cellValue = row[i].ToString();
                    if (cellValue == "-")
                    {
                        count++;
                    }
                }
                row["Пропуски"] = count; // Записуємо кількість у стовпець "Пропуски"
            }

            // Оновлюємо dataGridView1 з оновленою таблицею table
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        // Обробник події експорт даних
        private void bttnExport_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = saveFileDialog1.FileName;
            

            try
            {

                // Додаємо розширення .xlsx до імені файлу
                filePath += ".xlsx";
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    IWorkbook workbook = new XSSFWorkbook();
                    ISheet worksheet = workbook.CreateSheet("Attendance");

                    IRow headerRow = worksheet.CreateRow(0); 

                    for (int columnIndex = 0; columnIndex < table.Columns.Count; columnIndex++)
                    {
                        ICell headerCell = headerRow.CreateCell(columnIndex); 
                        headerCell.SetCellValue(table.Columns[columnIndex].ColumnName);
                    }

                    for (int rowIndex = 0; rowIndex < table.Rows.Count; rowIndex++)
                    {
                        IRow dataRow = worksheet.CreateRow(rowIndex + 1);

                        for (int columnIndex = 0; columnIndex < table.Columns.Count; columnIndex++)
                        {
                            ICell dataCell = dataRow.CreateCell(columnIndex);
                            dataCell.SetCellValue(table.Rows[rowIndex][columnIndex].ToString());
                        }
                    }

                    workbook.Write(fileStream);
                }

                MessageBox.Show("Файл успішно збережено.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Помилка збереження файлу: " + ex.Message);
            }
        }

        // Обробник події імпорт даних
        private void bttnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files|*.xlsx";
            openFileDialog1.Title = "Выберите файл для импорта";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                try
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        IWorkbook workbook = new XSSFWorkbook(fileStream);
                        ISheet worksheet = workbook.GetSheetAt(0);

                        DataTable importedData = new DataTable();

                        IRow headerRow = worksheet.GetRow(0);
                        if (headerRow != null)
                        {
                            for (int i = 0; i < headerRow.LastCellNum; i++)
                            {
                                ICell headerCell = headerRow.GetCell(i);
                                if (headerCell != null)
                                {
                                    string columnName = headerCell.StringCellValue;
                                    importedData.Columns.Add(columnName);
                                }
                            }
                        }

                        for (int rowIndex = 1; rowIndex <= worksheet.LastRowNum; rowIndex++)
                        {
                            IRow dataRow = worksheet.GetRow(rowIndex);
                            if (dataRow != null)
                            {
                                DataRow newRow = importedData.NewRow();
                                for (int columnIndex = 0; columnIndex < dataRow.LastCellNum; columnIndex++)
                                {
                                    ICell dataCell = dataRow.GetCell(columnIndex);
                                    if (dataCell != null)
                                    {
                                        newRow[columnIndex] = dataCell.ToString();
                                    }
                                }
                                importedData.Rows.Add(newRow);
                            }
                        }

                        // Відображення даних у dataGridView1

                        table = importedData;
                        dataGridView1.DataSource = table;
                        AttendanceData = table.Clone();

                        // Відображення даних у dataGridView2

                        dataGridView2.Rows.Clear();

                        foreach (DataRow row in importedData.Rows)
                        {
                            string value = row[0].ToString();
                            DataGridViewRow newRow = new DataGridViewRow();
                            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                            cell1.Value = value;
                            DataGridViewCheckBoxCell cell2 = new DataGridViewCheckBoxCell();
                            newRow.Cells.Add(cell1);
                            newRow.Cells.Add(cell2);
                            dataGridView2.Rows.Add(newRow);
                        }

                        numericUpDown1.Minimum = 1;
                        numericUpDown1.Maximum = dataGridView1.Columns.Count - 3; 

                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Помилка під час читання файлу: " + ex.Message);
                }
            }
        }

       
    }
}

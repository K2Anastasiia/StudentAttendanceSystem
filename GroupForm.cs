using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Linq;


namespace StudentAttendanceSystem
{
    public partial class GroupForm : Form
    {
        public DataTable AttendanceData { get; set; } = new DataTable();

        public int NumberOfClasses { get; set; }
        private string usernamePlaceholder = "ПІБ";
        private bool isUsernamePlaceholderVisible = true;

        public struct Student
        {
            public int id;
            public string name;

            public Student(int _id, string _name)
            {
                id = _id;
                name = _name;
            }
        }

        List<Student> students = new List<Student>();
        DataTable table = new DataTable();


        public GroupForm()
        {
            InitializeComponent();
            txtNameS.GotFocus += txtNameS_GotFocus;
            txtNameS.LostFocus += txtNameS_LostFocus;
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            lblDiscipline.Text = "Оберіть кількість занять з дисципліни " + Teacher.Discipline;
            dataGridView1.AllowUserToAddRows = false;
            table.Columns.Add(new DataColumn("№", typeof(int)));
            table.Columns.Add(new DataColumn("Name", typeof(string)));
            dataGridView1.DataSource = table;
            txtNameS.Text = usernamePlaceholder;
            txtNameS.ForeColor = SystemColors.GrayText;
        }
        private void txtNameS_GotFocus(object sender, EventArgs e)
        {
            if (isUsernamePlaceholderVisible)
            {
                txtNameS.Text = "";
                txtNameS.ForeColor = SystemColors.ControlText;
                isUsernamePlaceholderVisible = false;
            }
        }
        private void txtNameS_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameS.Text))
            {
                txtNameS.Text = usernamePlaceholder;
                txtNameS.ForeColor = SystemColors.GrayText;
                isUsernamePlaceholderVisible = true;
            }
        }
        private int currentId = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            students.Add(new Student(currentId, txtNameS.Text));
            currentId++;

            DataRow newRow = table.NewRow(); // Создаем новую строку DataRow

            newRow["№"] = students.Last().id; // Задаем значение столбца "№" из последнего добавленного студента
            newRow["Name"] = students.Last().name; // Задаем значение столбца "Name" из последнего добавленного студента


            table.Rows.Add(newRow); // Добавляем новую строку в таблицу
            
            AttendanceData.Rows.Add(students.Last().id, students.Last().name);
            
            txtNameS.Clear();
        }

        private void pctrBack_Click(object sender, EventArgs e)
        {
            AttendanceForm attendanceForm = new AttendanceForm();
            attendanceForm.AttendanceData = table.Copy();
            attendanceForm.NumberOfClasses = (int)nmrcNumberClasses.Value;
            attendanceForm.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class Form1 : Form
    {

        private Dictionary<string, string> teacherAccounts; // Хранит учетные данные педагогов
        


        public Form1(Dictionary<string, string> teacherAccounts)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запретить изменение размера формы
            this.teacherAccounts = teacherAccounts;

            this.MaximizeBox = false; // Отключить кнопку "Развернуть"
            this.MinimizeBox = false; // Отключить кнопку "Свернуть"
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "123456")
            {
                AdminForm adminForm = new AdminForm(teacherAccounts);
                adminForm.Show();

                // Clear input fields
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else if (teacherAccounts.ContainsKey(username) && teacherAccounts[username] == password)
            {
                
                AttendanceForm attendanceForm = new AttendanceForm();
                attendanceForm.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid login credentials. Please try again.");
            }

        }
    }
}



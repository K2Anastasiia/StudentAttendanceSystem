using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class AdminForm : Form
    {
        private Dictionary<string, string> teacherAccounts;
        
        private string usernamePlaceholder = "ПІБ";
        private bool isUsernamePlaceholderVisible = true;
        private string disciplinePlaceholder = "Дисципліна";
        private string idPlaceholder = "Ідентифікатор";
        private bool isDisciplinePlaceholderVisible = true;
        private bool isIdPlaceholderVisible = true;

        public AdminForm(Dictionary<string, string> teacherAccounts)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запретить изменение размера формы
            this.ControlBox = false; // Скрыть кнопку закрытия
            this.teacherAccounts = teacherAccounts;

            
            txtFullName.GotFocus += txtFullName_GotFocus;
            txtFullName.LostFocus += txtFullName_LostFocus;

            txtDiscipline.GotFocus += txtDiscipline_GotFocus;
            txtDiscipline.LostFocus += txtDiscipline_LostFocus;

            txtId.GotFocus += txtId_GotFocus;
            txtId.LostFocus += txtId_LostFocus;
        }


        private void txtFullName_GotFocus(object sender, EventArgs e)
        {
            if (isUsernamePlaceholderVisible)
            {
                txtFullName.Text = "";
                txtFullName.ForeColor = SystemColors.ControlText;
                isUsernamePlaceholderVisible = false;
            }
        }
        private void txtFullName_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                txtFullName.Text = usernamePlaceholder;
                txtFullName.ForeColor = SystemColors.GrayText;
                isUsernamePlaceholderVisible = true;
            }
        }

        private void txtDiscipline_GotFocus(object sender, EventArgs e)
        {
            if (isDisciplinePlaceholderVisible)
            {
                txtDiscipline.Text = "";
                txtDiscipline.ForeColor = SystemColors.ControlText;
                isDisciplinePlaceholderVisible = false;
            }
        }

        private void txtDiscipline_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiscipline.Text))
            {
                txtDiscipline.Text = disciplinePlaceholder;
                txtDiscipline.ForeColor = SystemColors.GrayText;
                isDisciplinePlaceholderVisible = true;
            }
        }

        private void txtId_GotFocus(object sender, EventArgs e)
        {
            if (isIdPlaceholderVisible)
            {
                txtId.Text = "";
                txtId.ForeColor = SystemColors.ControlText;
                isIdPlaceholderVisible = false;
            }
        }

        private void txtId_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                txtId.Text = idPlaceholder;
                txtId.ForeColor = SystemColors.GrayText;
                isIdPlaceholderVisible = true;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text;
            string password = txtNewPassword.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    
                    Teacher.FullName = txtFullName.Text;
                    Teacher.Discipline = txtDiscipline.Text;
                    Teacher.Id = int.Parse(txtId.Text);


                    teacherAccounts.Add(username, password);
                  

                    MessageBox.Show("Teacher account created successfully!");

                    // Clear input fields
                    txtNewUsername.Clear();
                    txtNewPassword.Clear();
                    txtFullName.Clear();
                    txtDiscipline.Clear();
                    txtId.Clear();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid teacher ID. Please enter a valid integer value.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a username and password for the teacher account.");
            }

        }

        private void pctrClouse_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Закрываем текущую форму AdminForm 
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            txtFullName.Text = usernamePlaceholder;
            txtFullName.ForeColor = SystemColors.GrayText;
            
            txtDiscipline.Text = disciplinePlaceholder;
            txtDiscipline.ForeColor = SystemColors.GrayText;

            txtId.Text = idPlaceholder;
            txtId.ForeColor = SystemColors.GrayText;
        }
    }
}

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ProjectTraining.Classes;
using ProjectTraining.Classes.DataBase;

namespace ProjectTraining
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpeningForms.OpenLoginForm();
        }

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            bool isSkipped = false;

            if (isSkipped == false)
            {
                this.WindowState = FormWindowState.Minimized;
                isSkipped = true;
            }
            else isSkipped = false;
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            CheckRegistrarion(tbxLogin.Text, tbxPassword.Text, tbxFullname.Text, tbxEmail.Text);
            tbxEmail.Clear();
            tbxFullname.Clear();
            tbxLogin.Clear();
            tbxPassword.Clear();
        }

        private static void CheckRegistrarion(string Login, string Password, string Fullname, string Email)
        {
            if (string.IsNullOrEmpty(Login) || string.IsNullOrWhiteSpace(Login))
            {
                MessageBox.Show("Invalid value entered or not entered at all.");
            }
            else if (string.IsNullOrEmpty(Password) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Invalid value entered or not entered at all.");
            }
            else if (string.IsNullOrEmpty(Fullname) || string.IsNullOrWhiteSpace(Fullname))
            {
                MessageBox.Show("Invalid value entered or not entered at all.");
            }
            else if (string.IsNullOrEmpty(Email) || string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Invalid value entered or not entered at all.");
            }
            else
            {
                Connection.CheckValuesLogin(Login, Password, Fullname, Email);
            }
        }
    }
}
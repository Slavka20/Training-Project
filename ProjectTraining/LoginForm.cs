using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjectTraining.Classes;
using ProjectTraining.Classes.DataBase;

namespace ProjectTraining
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void BtnSkip_Click(object sender, EventArgs e)
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
            this.Hide();
            OpeningForms.OpenRegistrationForm();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin(tbxLogin.Text, tbxPassword.Text);
        }

        private void CheckLogin(string Login, string Password)
        {
            if (string.IsNullOrEmpty(Login) || string.IsNullOrWhiteSpace(Login))
            {
                MessageBox.Show("Invalid value entered or not entered at all.");
            }
            else if (string.IsNullOrEmpty(Password) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Invalid value entered or not entered at all.");
            }
            else
            {
                Connection.SelectLoginPass(tbxLogin.Text, tbxPassword.Text);
                tbxLogin.Clear();
                tbxPassword.Clear();
            }
        }
    }
}

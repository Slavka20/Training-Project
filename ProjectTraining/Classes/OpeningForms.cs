using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraining.Classes
{
    class OpeningForms
    {
        public static void OpenLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        public static void OpenRegistrationForm()
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        public static void OpenMainForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

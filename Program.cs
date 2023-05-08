using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AdminInterface adminInterfaceForm = new AdminInterface();
            AdminLogin adminLoginForm = new AdminLogin();
            UserInterface userInterfaceForm = new UserInterface();
            LoginPage loginPageForm = new LoginPage();

            adminInterfaceForm.Hide();
            adminLoginForm.Hide();
            userInterfaceForm.Hide();
            loginPageForm.Hide();

            Application.Run(new LoginPage());

            while (true)
            {
                if (adminInterfaceForm.Visible == false)
                {
                    userInterfaceForm.Show();
                }
                else if(adminLoginForm.Visible == false)
                {
                    adminInterfaceForm.Show();
                }
                else if(loginPageForm.Visible == false)
                {
                    userInterfaceForm.Show();
                }
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachineLib;

namespace VendingMachine2
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void goback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UserInterface userInterfaceForm3 = new UserInterface();
            userInterfaceForm3.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            // if username and password is true, then do this:
            if((usernameEnter.Text == "admin") && (passwordEnter.Text == "1234"))
            {
                this.Visible = false;
                AdminInterface adminInterfaceForm2 = new AdminInterface();
                adminInterfaceForm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or password.", "Error!");//gives warning
            }
            

        }
    }
}

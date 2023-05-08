using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachineLib;

namespace VendingMachine2
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string username = usernameEnter.Text;
            string balance = balanceEnter.Text;

            bool usernameControl = true;
            bool balanceControl = true;

            if (usernameValidation(username) == false)
            {
                usernameControl = false;
                MessageBox.Show("You need to enter non-digit characters. (max.15)", "Non-Valid Username Entry");
            }
            if (balanceValidation(balance) == false)
            {
                balanceControl = false;
                MessageBox.Show("You need to enter a number.", "Non-Valid Balance Entry");
            }

            if((usernameControl == true) && (balanceControl) == true)
            {
                float Balance = float.Parse(balance);
                db.CreateUser(username, Balance);
                MessageBox.Show("You've created a user.", "Succesful!");
                usernameEnter.Clear();
                balanceEnter.Clear();

            }

            bool usernameValidation(string Name)
            {
                //how to make sure it takes max.15 chars?
                Regex rgxname = new Regex(@"^([A-Z]\w+)$");
                if (rgxname.Match(Name).Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool balanceValidation(string Name)
            {
                Regex rgxnumber = new Regex(@"\d+");
                if (rgxnumber.Match(Name).Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }
    }
}

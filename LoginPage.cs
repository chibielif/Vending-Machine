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
    public partial class LoginPage : Form
    {
        List<Users> Users = new List<Users>();
        List<Users> Users2 = new List<Users>();
        public LoginPage()
        {
            InitializeComponent();


            //DataAccess db2 = new DataAccess();
            //Users2 = db2.GetUserBalance(userChooser.Text);
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            CreateUser createUserForm = new CreateUser();
            createUserForm.Show();
        }


        private void LoginPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendingMachineDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.vendingMachineDataSet.Users);

        }

        private void enterLabel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UserInterface userInterfaceForm = new UserInterface();
            userInterfaceForm.Show();
        }
    }
}

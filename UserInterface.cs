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
    public partial class UserInterface : Form
    {
        List<Foods> Foods = new List<Foods>();
        List<Drinks> Drinks = new List<Drinks>();
        List<Users> Users = new List<Users>();
        public UserInterface()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();
            Users = db.GetUsers();
            userChooser.DataSource = Users;
            userChooser.DisplayMember = "Username";

            Foods = db.GetFoods();
            FoodTable.DataSource = Foods;
            FoodTable.DisplayMember = "UIinfo";

            Drinks = db.GetDrinks();
            DrinkTable.DataSource = Drinks;
            DrinkTable.DisplayMember = "UIinfo";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buying function
            DataAccess db = new DataAccess();
            List<Foods> Foods = new List<Foods>();
            List<Drinks> Drinks = new List<Drinks>();
            Foods = db.GetFoodStock(itemChooser.Text);
            Drinks = db.GetDrinkStock(itemChooser.Text);

            if (categoryChooser.Text == "Foods")
            {
                if (Foods[0].stock <= 0)
                {
                    MessageBox.Show("Out of stock.", "Warning!");
                }
                else
                {
                    if(Foods[0].stock < Int32.Parse(qtybox.Text))
                    {
                        MessageBox.Show("There isn't enough item in the stock.", "Warning!");
                    }
                    else
                    {
                        if(float.Parse(balanceBox.Text) < (Int32.Parse(qtybox.Text)*Foods[0].price))
                        {
                            MessageBox.Show("You don't have enough balance.", "Warning!");
                        }
                        else
                        {
                            db.SubtractFoodStock(itemChooser.Text, Int32.Parse(qtybox.Text));
                            MessageBox.Show("You bought item(s).", "Purchase Succesful");

                            //update the balance
                            db.UpdateBalance(userChooser.Text, Int32.Parse(qtybox.Text), Foods[0].price);
                            List<Users> users = db.GetUserBalance(userChooser.Text);
                            balanceBox.DataSource = users;
                            balanceBox.DisplayMember = "Balance";
                        }
                    }
                }

                
            }
            else if (categoryChooser.Text == "Drinks")
            {
                if (Drinks[0].stock <= 0)
                {
                    MessageBox.Show("Out of stock.", "Warning!");
                }
                else
                {
                    if (Drinks[0].stock < Int32.Parse(qtybox.Text))
                    {
                        MessageBox.Show("There isn't enough item in the stock.", "Warning!");
                    }
                    else
                    {
                        if (float.Parse(balanceBox.Text) < (Int32.Parse(qtybox.Text) * Drinks[0].price))
                        {
                            MessageBox.Show("You don't have enough balance.", "Warning!");
                        }
                        else
                        {
                            db.SubtractDrinkStock(itemChooser.Text, Int32.Parse(qtybox.Text));
                            MessageBox.Show("You bought item(s).", "Purchase Succesful");

                            //update the balance
                            db.UpdateBalance(userChooser.Text, Int32.Parse(qtybox.Text), Drinks[0].price);
                            List<Users> users = db.GetUserBalance(userChooser.Text);
                            balanceBox.DataSource = users;
                            balanceBox.DisplayMember = "Balance";
                        }
                    }
                }
            }

            
        }

        private void vendingmachine_Click(object sender, EventArgs e)
        {

        }

        private void UserInterface_Load(object sender, EventArgs e)
        {

        }


        private void adminloginUI_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminLogin adminLoginForm2 = new AdminLogin();
            adminLoginForm2.Show();
        }

        private void FoodTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categoryChooser_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (categoryChooser.Text == "Foods")
            {
                itemChooser.DataSource = Foods;
                itemChooser.DisplayMember = "Name";
            }
            else if (categoryChooser.Text == "Drinks")
            {
                itemChooser.DataSource = Drinks;
                itemChooser.DisplayMember = "Name";
            }
        }

        private void itemChooser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void balanceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void qtybox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseUserLabel_Click(object sender, EventArgs e)
        {

        }

        private void userChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess db3 = new DataAccess();
            List<Users> users = db3.GetUserBalance(userChooser.Text);
            balanceBox.DataSource = users;
            balanceBox.DisplayMember = "Balance";
        }
    }
}

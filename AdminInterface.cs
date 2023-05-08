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
    public partial class AdminInterface : Form
    {
        List<Foods> Foods = new List<Foods>();
        List<Drinks> Drinks = new List<Drinks>();
        public AdminInterface()
        {
            InitializeComponent();
            DataAccess db = new DataAccess();
            Foods = db.GetFoods();
            Drinks = db.GetDrinks();
        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            List<Foods> Foods = new List<Foods>();
            List<Drinks> Drinks = new List<Drinks>();

            Foods = db.GetFoods();
            Drinks = db.GetDrinks();


            if (categoryChooser.Text == "Foods")
            {
                db.AddFoods(changeStockComboBox.Text);
                stockBox.DataSource = Foods;
                stockBox.DisplayMember = "stockInfo";
            }
            else if (categoryChooser.Text == "Drinks")
            {
                db.AddDrinks(changeStockComboBox.Text);
                stockBox.DataSource = Drinks;
                stockBox.DisplayMember = "stockInfo";
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            List<Foods> Foods = new List<Foods>();
            List<Drinks> Drinks = new List<Drinks>();

            Foods = db.GetFoods();
            Drinks = db.GetDrinks();

            List<Foods> foods = db.GetFoodStock(changeStockComboBox.Text);
            List<Drinks> drinks = db.GetDrinkStock(changeStockComboBox.Text);

            if (categoryChooser.Text == "Foods")
            {
                if(foods[0].stock == 0)
                {
                    MessageBox.Show("The item is already out of stock.", "Warning!");
                }
                else
                {
                    db.SubtractFoods(changeStockComboBox.Text);
                }
                stockBox.DataSource = Foods;
                stockBox.DisplayMember = "stockInfo";
            }
            else if (categoryChooser.Text == "Drinks")
            {
                if (drinks[0].stock == 0)
                {
                    MessageBox.Show("The item is already out of stock.", "Warning!");
                }
                else
                {
                    db.SubtractDrinks(changeStockComboBox.Text);
                }
                stockBox.DataSource = Drinks;
                stockBox.DisplayMember = "stockInfo";
            }
        }

        private void gobacktomainmenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UserInterface userInterfaceForm2 = new UserInterface();
            userInterfaceForm2.ShowDialog();

        }

        private void stockBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categoryChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryChooser.Text == "Foods")
            {
                changeStockComboBox.DataSource = Foods;
                changeStockComboBox.DisplayMember = "Name";

                stockBox.DataSource = Foods;
                stockBox.DisplayMember = "stockInfo";
            }
            else if (categoryChooser.Text == "Drinks")
            {
                changeStockComboBox.DataSource = Drinks;
                changeStockComboBox.DisplayMember = "Name";

                stockBox.DataSource = Drinks;
                stockBox.DisplayMember = "stockInfo";
            }


        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            string name = nameEnter.Text;
            string Price = priceEnter.Text;
            string Stock = stockEnter.Text;

            bool nameControl = true;
            bool priceControl = true;
            bool stockControl = true;

            if(nameValidation(name) == false)
            {
                nameControl = false;
                MessageBox.Show("You need to enter non-digit characters starting with an uppercase letter. (min.3 - max.15)", "Non-Valid Name Entry");
            }
            if(numberValidation(Price) == false)
            {
                priceControl = false;
                MessageBox.Show("You need to enter a number.", "Non-Valid Price Entry");
            }
            if(numberValidation(Stock) == false)
            {
                stockControl = false;
                MessageBox.Show("You need to enter a number.", "Non-Valid Stock Entry");
            }


            if (((nameControl) == true) && ((priceControl) == true) && ((stockControl) == true))
            {
                float price = float.Parse(Price);
                int stock = int.Parse(Stock);
                if (categoryChooserEnter.Text == "Foods")
                {
                    db.AddFoodStock(name, price, stock);

                    nameEnter.Clear();
                    priceEnter.Clear();
                    stockEnter.Clear();

                    List<Foods> Foods = new List<Foods>();
                    Foods = db.GetFoods();
                    stockBox.DataSource = Foods;
                    stockBox.DisplayMember = "stockInfo";
                }
                else if (categoryChooserEnter.Text == "Drinks")
                {
                    db.AddDrinkStock(name, price, stock);

                    nameEnter.Clear();
                    priceEnter.Clear();
                    stockEnter.Clear();

                    List<Drinks> Drinks = new List<Drinks>();
                    Drinks = db.GetDrinks();
                    stockBox.DataSource = Drinks;
                    stockBox.DisplayMember = "stockInfo";
                }
            }


            bool nameValidation(string Name)
            {
                //how to make sure it takes max.15 chars?
                Regex rgxname = new Regex(@"(([A-Z]\w+)$|([A-Z]\w* [A-Z]\w+))");
                if (rgxname.Match(Name).Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            bool numberValidation(string Name)
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

        private void nameEnter_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

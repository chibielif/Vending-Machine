using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace VendingMachineLib
{
    public class DataAccess
    {

        public List<Foods> GetFoods()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                return connection.Query<Foods>($"select * from Foods").ToList();
            }
        }

        public List<Drinks> GetDrinks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                return connection.Query<Drinks>($"select * from Drinks").ToList();
            }
        }

        public List<Users> GetUsers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                return connection.Query<Users>($"select * from Users").ToList();
            }
        }

        public void AddFoods(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                connection.Execute($"UPDATE dbo.[Foods] SET [stock] += 1 WHERE [name] = '{Name}' ");
            }
        }

        public void AddDrinks(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                connection.Execute($"UPDATE dbo.[Drinks] SET [stock] += 1 WHERE [name] = '{Name}' ");
            }
        }

        public void UpdateBalance(string Username, int Quantity, float Price)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                connection.Execute($"UPDATE dbo.[Users] SET [balance] -= '{Quantity*Price}' WHERE [username] = '{Username}' ");
            }
        }

        public void SubtractFoods(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                connection.Execute($"UPDATE dbo.[Foods] SET [stock] -= 1 WHERE [name] = '{Name}' ");
            }
        }

        public void SubtractDrinks(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                connection.Execute($"UPDATE dbo.[Drinks] SET [stock] -= 1 WHERE [name] = '{Name}' ");
            }
        }

        public void SubtractFoodStock(string Name, int Quantity)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                connection.Execute($"UPDATE dbo.[Foods] SET [stock] -= '{Quantity}' WHERE [name] = '{Name}' ");
            }
        }

        public void SubtractDrinkStock(string Name, int Quantity)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                connection.Execute($"UPDATE dbo.[Drinks] SET [stock] -= '{Quantity}' WHERE [name] = '{Name}' ");
            }
        }

        public List<Foods> GetFoodStock(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                return connection.Query<Foods>($"select * from Foods where [name] = '{Name}'").ToList();
            }
        }

        public List<Drinks> GetDrinkStock(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                return connection.Query<Drinks>($"select * from Drinks where [name] = '{Name}'").ToList();
            }
        }

        public List<Users> GetUserBalance(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                return connection.Query<Users>($"select * from Users where [username] = '{Name}'").ToList();
            }
        }

        public void AddFoodStock(string Name, float Price, int Stock)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                var query = "INSERT INTO Foods(Name, Price, Stock) VALUES(@name, @price, @stock)";

                var dp = new DynamicParameters();
                dp.Add("@name", Name, DbType.AnsiString, ParameterDirection.Input, 255);
                dp.Add("@price", Price);
                dp.Add("@stock", Stock);

                connection.Execute(query, dp);
            }
        }

        public void AddDrinkStock(string Name, float Price, int Stock)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                var query = "INSERT INTO Drinks(Name, Price, Stock) VALUES(@name, @price, @stock)";

                var dp = new DynamicParameters();
                dp.Add("@name", Name, DbType.AnsiString, ParameterDirection.Input, 255);
                dp.Add("@price", Price);
                dp.Add("@stock", Stock);

                connection.Execute(query, dp);
            }
        }

        public void CreateUser(string Username, float Balance)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VendingMachineDB")))
            {
                var query = "INSERT INTO Users(Username, Balance) VALUES(@username, @balance)";

                var dp = new DynamicParameters();
                dp.Add("@username", Username, DbType.AnsiString, ParameterDirection.Input, 255);
                dp.Add("@balance", Balance);

                connection.Execute(query, dp);
            }
        }
    }
}

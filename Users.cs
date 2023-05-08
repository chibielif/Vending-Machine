using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineLib
{
    public class Users
    {
        public int id;
        public string username;
        public float balance;

        public string Username { get { return username; } set { username = value; } }
        public float Balance { get { return balance; } set { balance = value; } }
    }
}

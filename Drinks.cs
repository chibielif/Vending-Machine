using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineLib
{
    public class Drinks
    {
        public int id;
        public string name;
        public float price;
        public int stock;

        public string Name { get { return name; } set { name = value; } }
        public float Price { get { return price; } set { price = value; } }
        public int Stock { get { return stock; } set { stock = value; } }
        public string stockInfo
        {
            get
            {
                // format:
                // Water 25
                // Cookie 20  etc.
                return $"{name} {stock}";
            }
        }

        public string UIinfo
        {
            get
            {
                // format:
                // Water 25
                // Cookie 20  etc.
                return $"{name} {price}";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Product
    {
        public Product(string n, double m) {
            name = n;
            money = m;
        }
        public string name="Default";
        public double money = 0;   
        
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
    }
}

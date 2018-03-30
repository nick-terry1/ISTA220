using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_MilitaryUnit
{
    class equipment : unit
    {
        public string name;
        public string purpose;
        public double price;

        public equipment(string name, string purpose, double price) : base(name, purpose)
        {
            this.name = name;
            this.purpose = purpose;
            price = 0;
        }

        public void Lost()
        {
            Console.WriteLine("You lost a {0}, the army's going to take {1} out of your paycheck", name, price);
        }
    }
}

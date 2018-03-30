using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_MilitaryUnit
{
    class vehicles : unit
    {
        public string name;
        public string purpose;
        public int passengers;

        public vehicles(string name, string purpose, int passengers) : base(name, purpose)
        {
            this.name = name;
            this.purpose = purpose;
            this.passengers = passengers;
        }

        public void Load()
        {
            Console.WriteLine("The {0} has loaded {1} passengers and is ready to {2}", name, passengers, purpose);
        }
    }
}

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
        bool loaded = false;

        public vehicles(string name, string purpose, int passengers) : base(name, purpose)
        {
            this.name = name;
            this.purpose = purpose;
            this.passengers = passengers;
        }

        public void Load()
        {
            Console.WriteLine("The {0} has loaded {1} passengers and is ready to {2}", name, passengers, purpose);
            loaded = true;
        }

        // this program overrides the Move() method in the base class
        public override void Move()
        {
            if (loaded == true)
            {
                Console.WriteLine("{0} is full and moving to the target! Get ready!", name);
                loaded = false;
            }
            else
            {
                Console.WriteLine("You cant move out without loading passengers first!");
            }
        }
    }
}

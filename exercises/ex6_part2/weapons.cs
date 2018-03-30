using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_MilitaryUnit
{
    class weapons : unit
    {
        public string name;
        public string purpose;
        public int capacity;

        public weapons(string name, string purpose, int capacity) : base(name, purpose)
        {
            this.name = name;
            this.purpose = purpose;
            this.capacity = capacity;
        }

        public void Load()
        {
            Console.WriteLine("The {0} has a capacity of {1} and its purpose is to {2}", name, capacity, purpose);
        }
    }
}

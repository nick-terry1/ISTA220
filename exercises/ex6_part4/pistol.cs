using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_MilitaryUnit
{
    class pistol : weapons
    {
        public string name;
        public string purpose;
        public int capacity;
        public string ammo;

        public pistol(string name, string purpose, int capacity, string ammo) : base(name, purpose, capacity)
        {
            this.name = name;
            this.purpose = purpose;
            this.capacity = capacity;
            this.ammo = ammo;
        }

        public void Fire()
        {
            Console.WriteLine("pop pop");
        }
    }
}

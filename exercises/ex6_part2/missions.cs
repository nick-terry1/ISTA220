using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_MilitaryUnit
{
    class missions : unit
    {
        public string name;
        public string purpose;
        public int distance;
        public string target;

        public missions(string name, string purpose, int distance, string target) : base(name, purpose)
        {
            this.name = name;
            this.purpose = purpose;
            this.distance = distance;
            this.target = target;
        }

        public void Conop()
        {
            Console.WriteLine("We are ready to go {} and travel {} km to {} k/c {}", name, distance, purpose, target);
        }
    }
}

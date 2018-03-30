using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_MilitaryUnit
{
    public class unit
    {
        string name = "3/75 Ranger Regiment";
        string purpose = "kill everyone";
        public unit(string name, string purpose)
        {
            this.name = name;
            this.purpose = purpose;
        }

        public virtual void MissionStatement()
        {
            Console.WriteLine("Mission of {0} is to {1}", name, purpose);
        }

        // the vehicle class method Move() will override this method.
        public virtual void Move()
        {
            Console.WriteLine("{0} is on the move!", name);
        }
    }
}

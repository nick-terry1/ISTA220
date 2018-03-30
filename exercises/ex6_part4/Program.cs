using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            grenadelauncher M320 = new grenadelauncher("M320", "firing at deadspace", 1, "40mm");
            pistol glock19 = new pistol("Glock19", "shooting close range targets", 15, "9mm");
            rifle M4 = new rifle("M4A1", "firing at midrange targets", 30, "5.56");
            vehicles MH47 = new vehicles("MH47", "fly to target as fast as possible", 32);
            unit bco = new unit("bravo company", "baby killing");
            MH47.Move();
            MH47.Load();
            MH47.Move();
            bco.Move();
            glock19.Fire();
            M4.Fire();
            M320.Fire();

        }
    }
}

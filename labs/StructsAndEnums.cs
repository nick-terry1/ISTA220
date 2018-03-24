#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            Month first = Month.December;
            Console.WriteLine(first);
            Console.WriteLine((int)first);

            first++;
            Console.WriteLine(first);

            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);

            Date WeddingAnniversary = new Date(2015, Month.July, 4);
            Console.WriteLine(WeddingAnniversary);

            Date weddingAnniversaryCopy = WeddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");

            WeddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is {WeddingAnniversary}");
            Console.WriteLine($"Value of copy is still {weddingAnniversaryCopy}");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

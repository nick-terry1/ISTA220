using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1_areaCir
{
    class AreaCircum
    {
        static void Main(string[] args)
        {
            float circum;
            float pi = 3.14159F;
            Console.WriteLine("enter a value for the radius");
            float r = float.Parse(Console.ReadLine());
            circum = 2 * pi * r;
            Console.WriteLine($"The circumference of the circle is {circum}");

            float area = pi * (r * r);
            Console.WriteLine($"The area of the circle is {area}");
        }
    }
}

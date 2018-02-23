using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    static void Main(string[] args)
    {
        public void circumArea() // First part calculates circumference and second part calculates area
        {
            float circum;
            float pi = 3.14159F;
            Console.WriteLine("enter a value for the radius");
            float r = float.Parse(Console.ReadLine());
            circum = 2 * pi* r;
            Console.WriteLine($"The circumference of the circle is {circum}");

            float area = pi * (r * r);
            Console.WriteLine($"The area of the circle is {area}");
        
        }

        public void calVolume(string[] args)
            {
                float vol;
                float pi = 3.14159F;
                Console.WriteLine("Please enter a radius");
                float r = float.Parse(Console.ReadLine());
                vol = ((4 / 3) * pi * (r * r * r)) / 2;
                Console.WriteLine(vol);
            }
        }
    }
}


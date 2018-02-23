using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TriArea          // calculates the area of a triangle of sides a,b, and c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for the first side");                             // The first side of the triangle is of length "a"
            int sideA = int.Parse(Console.ReadLine());                                         // Reads the user input for side 'a'
            Console.WriteLine("Enter a value for the second side");                            // The second side of the triangle is of lenth 'b'
            int sideB = int.Parse(Console.ReadLine());                                         // Reads the user input for side 'b'
            Console.WriteLine("Enter a value for the third side");                             // The third side of the triangle is of lenth 'c'
            int sideC = int.Parse(Console.ReadLine());                                         // Reads the user input for the side 'c'

            double p = (sideA + sideB + sideC) / 2;                                            // p is the sum of all sides divided by two. This variable
                                                                                               // will be used for the final area equation.
            double areaFinal = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideB));         // Herons formula
            Console.WriteLine($"The area of the tringle is {areaFinal}");                      // Displays the results from Herons formula

            

        }
    }
}

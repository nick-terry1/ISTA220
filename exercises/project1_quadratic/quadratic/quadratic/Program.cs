using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadratic                
    
    /* solves the quadratic equation for x, given coefficients of a,b,and c.
    The quadratic equation is x = (-b +- sqrt(b^2 -4ac))/2a where the initial 
    equation for x is in the form x = ax^2 + bx + c   */

{
    class Program
    {
        static void Main(string[] args)                                                
        {
            Console.WriteLine("Enter the coefficient for 'a'");                             // Asks user for coefficient 'a'
            double coA = double.Parse(Console.ReadLine());                                  // User inputs value for 'a'
            Console.WriteLine("Enter the coefficient for 'b'");                             // Asks user for coefficient 'b'
            double coB = double.Parse(Console.ReadLine());                                  // User inputs value for 'b'
            Console.WriteLine("Enter the coefficient for 'c'");                             // Asks user for coefficient 'c'
            double coC = double.Parse(Console.ReadLine());                                  // User inputs value for 'c'

            double x1 = (-coB + Math.Sqrt(coB * coB - 4 * coA * coC)) / (2 * coA);          // Calculates the first value of x
            double x2 = (-coB - Math.Sqrt(coB * coB - 4 * coA * coC)) / (2 * coA);          // Calculates the second value of x
                
            Console.WriteLine($" x = ({x1},{x2})");                                         // Prints the values of x in the form x=(x1,x2)

        }
    }
}

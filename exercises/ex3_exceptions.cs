using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This program will take the week one math excercises (area & circumference of a circle, 
 * hemisphere, area of a triangle, and quadratic formula) and run them while taking into 
 * consideration multiple exceptions, or problems that might arise. Problems solved are 1) the program 
 * doesnt end after more than one exception is thrown and 2) only one try catch statement 
 * for the entire program */

namespace Exceptions1
{
    class Areas
    {
        static void Main(string[] args)
        {
            // the entire program will be checked for overflow
            checked
            {
                // two universal variables 
                float circum;
                float pi = 3.14159F;
                                
                MainMenu();
            
                // Main menu method for all the available choices.
                void MainMenu()
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the formula you want to use:\n\n" +
                        "1) Circumference of a circle\n" +
                        "2) Area of a circle\n" +
                        "3) Hemisphere of a circle \n" +
                        "4) Area of a triangle\n" +
                        "5) Quadratic Formula \n" +
                        "6) Exit\n");

                        int menuChoice = int.Parse(Console.ReadLine());

                        switch (menuChoice)
                        {
                            case 1:
                                Circumference();
                                break;
                            case 2:
                                CircleArea();
                                break;
                            case 3:
                                Hemisphere();
                                break;
                            case 4:
                                TriArea();
                                break;
                            case 5:
                                Quadratic();
                                break;
                            case 6:
                                return;
                            default:
                                Console.WriteLine("Not a valid choice, press enter and try again...");
                                Console.ReadLine();
                                MainMenu();
                                break;
                        }

                    }
                    // this catch will find all formatting errors (ex. giving a float value for an int)
                    catch (FormatException fEx)
                    {
                        Console.WriteLine(fEx.Message);
                        Console.ReadLine();
                        MainMenu();
                    }
                    // this will catch all values from overflowing and becoming negative
                    catch (OverflowException ofEx)
                    {
                        Console.WriteLine(ofEx.Message);
                        Console.ReadLine();
                        MainMenu();
                    }
                    // This exception cant be thrown, but is included for future edits.
                    catch (DivideByZeroException dbzEx)
                    {
                        Console.WriteLine(dbzEx.Message);
                        Console.ReadLine();
                        MainMenu();
                    }

                }

                // this method finds the circumference of a circle that user gives radius for
                void Circumference()
                {
                    // cleans up the screen before starting
                    Console.Clear();
                    Console.WriteLine("enter a value for the radius");
                    float r = float.Parse(Console.ReadLine());

                    // this will keep the user inputting values until he gives one 
                    // thats not negative or zero, which is impossible.
                    while (r <= 0)
                    {
                        Console.Write("The radius must be a positive number, try again\n" +
                            "enter a value for the radius: ");
                        r = float.Parse(Console.ReadLine());
                    }
                    circum = 2 * pi * r;
                    Console.WriteLine($"The circumference of the circle is {circum}\n" +
                        $"Press <enter> to continue...");
                    Console.ReadLine();
                    MainMenu();
                }

                // this method calculates the area of a circle
                void CircleArea()
                {
                    Console.Clear();
                    Console.WriteLine("enter a value for the radius");
                    float r = float.Parse(Console.ReadLine());

                    // keeps user inputting only valid numbers
                    while (r <= 0)
                    {
                        Console.WriteLine("The radius must be a positive number\n" +
                            "enter another value:");
                        r = float.Parse(Console.ReadLine());
                    }
                    float area = pi * (r * r);
                    Console.WriteLine($"The area of the circle is {area}\n" +
                        $"Press <enter> to continue...");
                    Console.ReadLine();
                    MainMenu();
                }

                // this method calculates the volume of a circle
                void Hemisphere()
                {
                    Console.Clear();
                    float vol;
                    Console.WriteLine("Enter a radius value");
                    float r = float.Parse(Console.ReadLine());

                    // keeps the radius only positive float values
                    while (r <= 0)
                    {
                        Console.WriteLine("The radius must be a positive number\n" +
                            "enter another radius value:");
                        r = float.Parse(Console.ReadLine());
                    }
                    vol = ((4 / 3) * pi * (r * r * r)) / 2;
                    Console.WriteLine($"The volume of the circle is {vol}\n" +
                        $"Press <enter> to continue...");
                    Console.ReadLine();
                    MainMenu();
                }

                // this method calculates the area of a triangle 
                void TriArea()
                {
                    // declare the starting point for when the user inputs invalid numbers and must start over
                    START:
                    Console.Clear();
                    Console.WriteLine("Enter a value for the first side");
                    int sideA = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a value for the second side");
                    int sideB = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a value for the third side");
                    int sideC = int.Parse(Console.ReadLine());

                    // obviously the sides cant be less than or equal to 0, if they are start over
                    if ((sideC <= 0) || (sideB <= 0) || (sideC <= 0))
                    {
                        Console.WriteLine("The value of the side must be greater than zero");
                        Console.ReadKey();
                        goto START;
                    }

                    double p = (sideA + sideB + sideC) / 2;
                    double areaFinal = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideB));

                    Console.WriteLine($"The area of the tringle is {areaFinal}\n" +
                        $"Press <enter> to continue...");
                    // all programs and methods end with this console readline to keep the writeline words on screen to read
                    Console.ReadLine();
                    MainMenu();
                }

                // this method calculates the value of x using the quadratic formula
                void Quadratic()
                {
                    // declare the starting point in the case of invalid inputs and we need to restart
                    START:
                    float coA = -1, coB = -1, coC = -1;
                    // this value is to check whether the value calculated in the sqrt is a number or NaN
                    bool sqrtCheck = true;

                    Console.Clear();
                    Console.WriteLine("Using the formula ax^2 + bx +c\n" +
                        "enter the coefficient for 'a'");
                    coA = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the coefficient for 'b'");
                    coB = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the coefficient for 'c'");
                    coC = float.Parse(Console.ReadLine());

                    sqrtCheck = double.IsNaN(Math.Sqrt(coB * coB - 4 * coA * coC));

                    // if the sqrt returns a negative number start over. No imaginary number in this equation.
                    if (sqrtCheck == true)
                    {
                        Console.WriteLine("The square root contains a negative value which is not allowed\n" +
                            "press enter to enter values again");
                        Console.ReadLine();
                        goto START;
                    }
                                                
                    double x1 = (-coB + Math.Sqrt(coB * coB - 4 * coA * coC)) / (2 * coA);
                    double x2 = (-coB - Math.Sqrt(coB * coB - 4 * coA * coC)) / (2 * coA);

                    // If x1 or x2 are not real numbers (NaN) start over.
                    if ((double.IsNaN(x1)) || (double.IsNaN(x2)))
                    {
                        Console.WriteLine("The value of x is not a real number\n" +
                            "press enter to enter values again");
                        Console.ReadKey();
                        goto START;
                    }

                    // If x1 or x2 are infinity start over. Neither NaN or infinity will cause
                    // an exception as we are working with doubles.
                    if  ((double.IsInfinity(x1)) || (double.IsInfinity(x2)))
                    {
                        Console.WriteLine("The value of x is infinity\n" +
                            "press enter to enter values again");
                        Console.ReadKey();
                        goto START;
                    }

                    Console.WriteLine($" x = ({x1},{x2})\n" +
                        $"Press <enter> to continue...)");
                    Console.ReadLine();
                    MainMenu();
                }
            }
        }
    }
}

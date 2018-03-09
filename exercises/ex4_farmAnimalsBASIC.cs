using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This program creates four classes each representing a farm animal. Each animal has four methods. 
 * All the method names are the same but depending on the class does different things. This is just
 * a very basic program that does only the class requirements for part 4 of the exercise. Ill be
 * writing a program called farmAnimalsV2 that should be more fun with more in depth functions but
 * I wanted to put this up first. */

namespace ex4_farmAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            // The whole program is encased for exception handling.
            try
            {
                // Created an instance of class Horse called mrEd where the arguments define 
                // what horse says, eats, its speed, and its average lifespan. 
                Horse mrEd = new Horse("neigh", "hay", 30, 15);

                // Im calling each method defined in the horse class to test that they work.
                mrEd.Speak();
                mrEd.Speed();
                mrEd.Eat();
                mrEd.Life();

                // The process is repeated with an instance of chicken, cat, and cow
                Chicken firstChick = new Chicken("cluck", "corn", 1, 2);
                firstChick.Speak();
                firstChick.Eat();
                firstChick.Speed();
                firstChick.Life();

                Cat firstCat = new Cat("meow meow meow", "canned food", 20, 15);
                firstCat.Speak();
                firstCat.Speed();
                firstCat.Eat();
                firstCat.Life();

                Cow firstCow = new Cow("mooooooooo", "grass", 5, 10);
                firstCow.Speak();
                firstCow.Speed();
                firstCow.Eat();
                firstCow.Life();
            }
            
            // My exception handling only includes a format error and a general one, as there are really no other
            // common exceptions that might pop up with this program.
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Console.ReadKey();
            }
            
            catch (Exception gEx)
            {
                Console.WriteLine(gEx.Message);
                Console.ReadKey();
            }

        }

        
    }

    public class Horse
    {
        // class Horse is defined by four variables
        private string talk;
        private string food;
        private int speed;
        private int life;

        // assigning the instance arguments to the class variables
        public Horse(string horseTalk, string horseFood, int horseSpeed, int horseLife)
        {
            talk = horseTalk;
            food = horseFood;
            speed = horseSpeed;
            life = horseLife;
        }

        // each method simply prints out a message that goes with what the argument is.
        public void Speak()
        {
            Console.WriteLine("The Horse says {0}", talk);
            Console.ReadKey();
        }

        public void Eat()
        {
            Console.WriteLine("The horse eats {0}", food);
            Console.ReadKey();
        }

        public void Speed()
        {
            Console.WriteLine($"Horses can only go {speed} mph");
            Console.ReadKey();
        }

        public void Life()
        {
            Console.WriteLine($"Horses live as long as {life}");
            Console.ReadKey();
        }
    }
   
    // Horse class is repeated with chicken, cat, and cow.
    public class Chicken
    {
        private string talk;
        private string food;
        private int speed;
        private int life;

        public Chicken(string chickTalk, string chickFood, int chickSpeed, int chickLife)
        {
            talk = chickTalk;
            food = chickFood;
            speed = chickSpeed;
            life = chickLife;

        }

        public void Speak()
        {
            Console.WriteLine("hello im a chicken and i say {0}", talk);
            Console.ReadKey();
        }

        public void Eat()
        {
            Console.WriteLine("The chicken eats {0}", food);
            Console.ReadKey();
        }

        public void Speed()
        {
            Console.WriteLine($"Chickens can only go {speed} mph");
            Console.ReadKey();
        }

        public void Life()
        {
            Console.WriteLine($"chickens live as long as {life} years");
            Console.ReadKey();
        }
    }

    public class Cat
    {
        private string talk;
        private string food;
        private int speed;
        private int life;

        public Cat(string catTalk, string catFood, int catSpeed, int catLife)
        {
            talk = catTalk;
            food = catFood;
            speed = catSpeed;
            life = catLife;
        }

        public void Speak()
        {
            Console.WriteLine("hello im a cat and i say {0}", talk);
            Console.ReadKey();
        }

        public void Eat()
        {
            Console.WriteLine("cats eats {0}", food);
            Console.ReadKey();
        }

        public void Speed()
        {
            Console.WriteLine($"cats can only go {speed} mph");
            Console.ReadKey();
        }

        public void Life()
        {
            Console.WriteLine($"cats live as long as {life} years");
            Console.ReadKey();
        }
    }

    public class Cow
    {
        private string talk;
        private string food;
        private int speed;
        private int life;

        public Cow(string cowTalk, string cowFood, int cowSpeed, int cowLife)
        {
            talk = cowTalk;
            food = cowFood;
            speed = cowSpeed;
            life = cowLife;
        }

        public void Speak()
        {
            Console.WriteLine("hello im a cow and i say {0}", talk);
            Console.ReadKey();
        }

        public void Eat()
        {
            Console.WriteLine("The cow eats {0}", food);
            Console.ReadKey();
        }

        public void Speed()
        {
            Console.WriteLine($"cows can only go {speed} mph");
            Console.ReadKey();
        }

        public void Life()
        {
            Console.WriteLine($"cows live as long as {life} years");
            Console.ReadKey();
        }
    }
}

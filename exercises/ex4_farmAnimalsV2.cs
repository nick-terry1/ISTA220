using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This program is the more fun version of the basic program ex4_farmAnimalsBASIC. This one has more user input with 
 * menus and programs that dont just print out words but have actual functionality. You can pick one of four animals.
 * Once you pick an animal you input four parameters for it and the instance of that animal is saved. 
 * You then have the choice of one of 5 program within that class. */

namespace ex4_farmAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            // try catch block that catches only format exceptions and general exceptions
            try
            {
                MainMenu();
            }

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

            void MainMenu()
            {
                Console.WriteLine("Please enter a number value for the farm animal you want to play with:\n\n" +
                    "1) Exit Program\n" +
                    "2) Horse\n" +
                    "3) Cow\n" +
                    "4) Cat\n" +
                    "5) Sheep\n");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    // immediately exits
                    case 1:
                        {
                            return;
                        }

                    case 2:
                        {
                            // user inputs for the arguments for the instance of class horse
                            Console.Clear();
                            Console.WriteLine("Tell me about your horse\n" +
                                "What kind of food does he eat?");
                            string Hfood = Console.ReadLine();

                            Console.WriteLine("How old is it in years?");
                            int Hage = int.Parse(Console.ReadLine());

                            Console.WriteLine("What does your horse do for fun?");
                            string Hfun = Console.ReadLine();

                            Console.WriteLine("Finally whats your horse's name???");
                            string Hname = Console.ReadLine();

                            // instance initialized
                            Horse sampleHorse = new Horse(Hfood, Hage, Hfun, Hname);

                            // sampleHorse calls the program with arguments Hfood,Hage,Hfun,Hname
                            sampleHorse.HorseProg(Hfood,Hage,Hfun,Hname);
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Tell me about your cow\n" +
                                "What kind of food does he eat?");
                            string food = Console.ReadLine();

                            Console.WriteLine("How old is it in years?");
                            int age = int.Parse(Console.ReadLine());

                            Console.WriteLine("What does your cow do for fun?");
                            string fun = Console.ReadLine();

                            Console.WriteLine("Finally whats your cow's name???");
                            string name = Console.ReadLine();

                            Cow sampleAnimal = new Cow(food, age, fun, name);

                            sampleAnimal.CowProg(food, age, fun, name);
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Tell me about your cat\n" +
                                "What kind of food does he eat?");
                            string food = Console.ReadLine();

                            Console.WriteLine("How old is it in years?");
                            int age = int.Parse(Console.ReadLine());

                            Console.WriteLine("What does your cat do for fun?");
                            string fun = Console.ReadLine();

                            Console.WriteLine("Finally whats your cat's name???");
                            string name = Console.ReadLine();

                            Cat sampleAnimal = new Cat(food, age, fun, name);

                            sampleAnimal.CatProg(food, age, fun, name);
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Tell me about your sheep\n" +
                                "What kind of food does he eat?");
                            string food = Console.ReadLine();

                            Console.WriteLine("How old is it in years?");
                            int age = int.Parse(Console.ReadLine());

                            Console.WriteLine("What does your sheep do for fun?");
                            string fun = Console.ReadLine();

                            Console.WriteLine("Finally whats your sheep's name???");
                            string name = Console.ReadLine();

                            Sheep sampleAnimal = new Sheep(food, age, fun, name);

                            sampleAnimal.SheepProg(food, age, fun, name);
                            break;
                        }

                        // default will catch all inputs that are not between 1 - 5
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a value 1-5 ONLY!\n" +
                                "press enter to acknowledge");
                            Console.ReadLine();
                            Console.Clear();
                            MainMenu();
                            break;
                        }
                }
            }

        }


    }

    public class Horse
    {
        // collection created to hold the new input and make room for future horse instances
        List<Horse> HorseList = new List<Horse>();

        private string food;
        private int age;
        private string fun;
        private string name;

        

        public Horse(string one, int two, string three, string four)
        {
            food = one ;
            age = two;
            fun = three;
            name = four;
        }

        public void HorseProg(string food, int age, string fun, string name)
        {
            // sampleHorse is transfered from program class to horse class in this manner
            Horse sampleHorse = new Horse(food, age, fun, name);
            // sample horse is then added to the collection
            HorseList.Add(sampleHorse);

            Console.Clear();
            Console.WriteLine("The information for your horse has been saved.\n" +
                "What else would you like to do?");

            HMAIN:
            Console.WriteLine("1) Exit\n" +
                "2) List all my horses\n" +
                "3) Search for a specific horse\n" +
                "4) Feed the horses\n" +
                "5) Play with the horses\n" +
                "6) Add another horse friend");

            int horseChoice = int.Parse(Console.ReadLine());

            switch (horseChoice)
            {
                case 1:
                    {
                        return;
                    }
                case 2:
                    {
                        SavedHorses();
                        goto HMAIN;
                    }
                case 3:
                    {
                        HorseSearch();
                        goto HMAIN;
                    }
                case 4:
                    {
                        FeedHorses();
                        goto HMAIN;
                    }
                case 5:
                    {
                        HorsePlay();
                        goto HMAIN;
                    }
                case 6:
                    {
                        HorseFriend();
                        goto HMAIN;
                    }
                    // default catches any inputs not within the range of 1 and 6
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Thats not an available choice, please pick a number 1-6\n" +
                            "press enter to acknowledge");
                        Console.ReadLine();
                        Console.Clear();
                        goto HMAIN;
                    }
            }

        }
        
        // this method prints all saved horse instances
        public void SavedHorses()
        {
            Console.Clear();
            // this foreach loops through each horse in the list and prints its parameters seperated by commas
            foreach (Horse hhh in HorseList)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", hhh.food, hhh.age, hhh.fun, hhh.name);
            }
            Console.ReadLine();
            Console.Clear();
            return;
        }

        // this method searches through all the saved instances in the horse list for the name of the horse specified
        // and prints the contents on screen.
        public void HorseSearch()
        {
            Console.Clear();
            Console.Write("Enter the name of the Horse you wish to get info on: ");
            string hSearch = Console.ReadLine();
             // this is the lamda expression that finds instance of horse that matches the parameter 'name' that matches user input
            Horse match = HorseList.Find((Horse hor) => { return hor.name == hSearch; });
            // prints out the results
            Console.WriteLine("name: {0}, age: {1}, fun: {2}, food: {3}", match.name, match.age, match.fun, match.food);
            Console.ReadLine();
            Console.Clear();
            return;
        }
        
        // method that uses user input to print out custom message about food
        public void FeedHorses()
        {
            Console.Clear();
            Console.WriteLine("What would you like to feed the horses?");
            string feed1 = Console.ReadLine();
            Console.WriteLine($"Dont worry, all the horses have been fed {feed1}!");
            Console.ReadLine();
            Console.Clear();
            return;
        }

        // method that uses user input to print out custom message about playing
        public void HorsePlay()
        {
            Console.Clear();
            Console.WriteLine("What would you like to play with your horses?");
            string play1 = Console.ReadLine();
            Console.WriteLine($"Youre having so much fun playing {play1} with the horses!");
            Console.ReadLine();
            Console.Clear();
            return;
        }

        // this method adds another Horse to the collection using the same code as before
        public void HorseFriend()
        {
            Console.WriteLine("Tell me about your horse\n" +
                                "What kind of food does he eat?");
            string Hfood = Console.ReadLine();

            Console.WriteLine("How old is it in years?");
            int Hage = int.Parse(Console.ReadLine());

            Console.WriteLine("What does your horse do for fun?");
            string Hfun = Console.ReadLine();

            Console.WriteLine("Finally whats your horse's name???");
            string Hname = Console.ReadLine();

            Horse sampleHorse = new Horse(Hfood, Hage, Hfun, Hname);

            HorseList.Add(sampleHorse);

            Console.Clear();
            Console.WriteLine("The information for your horse has been saved.\n" +
                "What else would you like to do?\n");
            return;
        }
    }

    // this class as well as the cat and sheep classes are just carbon copies of the horse class but with slight name differences
    public class Cow
    {
        List<Cow> CowList = new List<Cow>();

        private string food;
        private int age;
        private string fun;
        private string name;



        public Cow(string one, int two, string three, string four)
        {
            food = one;
            age = two;
            fun = three;
            name = four;
        }

        public void CowProg(string food, int age, string fun, string name)
        {
            Cow sampleAnimal = new Cow(food, age, fun, name);
            CowList.Add(sampleAnimal);

            Console.Clear();
            Console.WriteLine("The information for your cow has been saved.\n" +
                "What else would you like to do?\n");

            HMAIN:
            Console.WriteLine("1) Exit\n" +
                "2) List all my cows\n" +
                "3) Search for a specific cow\n" +
                "4) Feed the cows\n" +
                "5) Play with the cows\n" +
                "6) Add another cow friend");

            int animalChoice = int.Parse(Console.ReadLine());

            switch (animalChoice)
            {
                case 1:
                    {
                        return;
                    }
                case 2:
                    {
                        SavedCows();
                        goto HMAIN;
                    }
                case 3:
                    {
                        CowSearch();
                        goto HMAIN;
                    }
                case 4:
                    {
                        FeedCows();
                        goto HMAIN;
                    }
                case 5:
                    {
                        CowPlay();
                        goto HMAIN;
                    }
                case 6:
                    {
                        CowFriend();
                        goto HMAIN;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Thats not an available choice, please pick a number 1-6");
                        goto HMAIN;
                    }
            }

        }

        public void SavedCows()
        {
            Console.Clear();
            foreach (Cow hhh in CowList)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", hhh.food, hhh.age, hhh.fun, hhh.name);
            }
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void CowSearch()
        {
            Console.Clear();
            Console.Write("Enter the name of the Cow you wish to get info on: ");
            string hSearch = Console.ReadLine();
            Cow match = CowList.Find((Cow hor) => { return hor.name == hSearch; });
            Console.WriteLine("name: {0}, age: {1}, fun: {2}, food: {3}", match.name, match.age, match.fun, match.food);
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void FeedCows()
        {
            Console.Clear();
            Console.WriteLine("What would you like to feed the cows?");
            string feed1 = Console.ReadLine();
            Console.WriteLine($"Dont worry, all the cows have been fed {feed1}!");
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void CowPlay()
        {
            Console.Clear();
            Console.WriteLine("What would you like to play with your cows?");
            string play1 = Console.ReadLine();
            Console.WriteLine($"Youre having so much fun playing {play1} with the cows!");
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void CowFriend()
        {
            Console.WriteLine("Tell me about your cow\n" +
                                "What kind of food does he eat?");
            string food = Console.ReadLine();

            Console.WriteLine("How old is it in years?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What does your cow do for fun?");
            string fun = Console.ReadLine();

            Console.WriteLine("Finally whats your cow's name???");
            string name = Console.ReadLine();

            Cow sampleCow = new Cow(food, age, fun, name);

            CowList.Add(sampleCow);

            Console.Clear();
            Console.WriteLine("The information for your cow has been saved.\n" +
                "What else would you like to do?\n");
            return;
        }
    }

    public class Sheep
    {
        List<Sheep> SheepList = new List<Sheep>();

        private string food;
        private int age;
        private string fun;
        private string name;



        public Sheep(string one, int two, string three, string four)
        {
            food = one;
            age = two;
            fun = three;
            name = four;
        }

        public void SheepProg(string food, int age, string fun, string name)
        {
            Sheep sampleAnimal = new Sheep(food, age, fun, name);
            SheepList.Add(sampleAnimal);

            Console.Clear();
            Console.WriteLine("The information for your sheep has been saved.\n" +
                "What else would you like to do?");

            HMAIN:
            Console.WriteLine("1) Exit\n" +
                "2) List all my sheep\n" +
                "3) Search for a specific sheep\n" +
                "4) Feed the sheep\n" +
                "5) Play with the sheep\n" +
                "6) Add another sheep friend");

            int animalChoice = int.Parse(Console.ReadLine());

            switch (animalChoice)
            {
                case 1:
                    {
                        return;
                    }
                case 2:
                    {
                        SavedSheep();
                        goto HMAIN;
                    }
                case 3:
                    {
                        SheepSearch();
                        goto HMAIN;
                    }
                case 4:
                    {
                        FeedSheep();
                        goto HMAIN;
                    }
                case 5:
                    {
                        SheepPlay();
                        goto HMAIN;
                    }
                case 6:
                    {
                        SheepFriend();
                        goto HMAIN;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Thats not an available choice, please pick a number 1-6");
                        goto HMAIN;
                    }
            }

        }

        public void SavedSheep()
        {
            Console.Clear();
            foreach (Sheep hhh in SheepList)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", hhh.food, hhh.age, hhh.fun, hhh.name);                
            }
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void SheepSearch()
        {
            Console.Clear();
            Console.Write("Enter the name of the Sheep you wish to get info on: ");
            string hSearch = Console.ReadLine();
            Sheep match = SheepList.Find((Sheep hor) => { return hor.name == hSearch; });
            Console.WriteLine("name: {0}, age: {1}, fun: {2}, food: {3}", match.name, match.age, match.fun, match.food);
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void FeedSheep()
        {
            Console.Clear();
            Console.WriteLine("What would you like to feed the sheep?");
            string feed1 = Console.ReadLine();
            Console.WriteLine($"Dont worry, all the sheep have been fed {feed1}!");
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void SheepPlay()
        {
            Console.Clear();
            Console.WriteLine("What would you like to play with your sheep?");
            string play1 = Console.ReadLine();
            Console.WriteLine($"Youre having so much fun playing {play1} with the sheep!");
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void SheepFriend()
        {
            Console.WriteLine("Tell me about your sheep\n" +
                                "What kind of food does he eat?");
            string food = Console.ReadLine();

            Console.WriteLine("How old is it in years?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What does your sheep do for fun?");
            string fun = Console.ReadLine();

            Console.WriteLine("Finally whats your sheep's name???");
            string name = Console.ReadLine();

            Sheep sampleSheep = new Sheep(food, age, fun, name);

            SheepList.Add(sampleSheep);

            Console.Clear();
            Console.WriteLine("The information for your Sheep has been saved.\n" +
                "What else would you like to do?\n");
            return;
        }
    }

    public class Cat
    {
        List<Cat> CatList = new List<Cat>();

        private string food;
        private int age;
        private string fun;
        private string name;



        public Cat(string one, int two, string three, string four)
        {
            food = one;
            age = two;
            fun = three;
            name = four;
        }

        public void CatProg(string food, int age, string fun, string name)
        {
            Cat sampleAnimal = new Cat(food, age, fun, name);
            CatList.Add(sampleAnimal);

            Console.Clear();
            Console.WriteLine("The information for your cat has been saved.\n" +
                "What else would you like to do?");

            HMAIN:
            Console.WriteLine("1) Exit\n" +
                "2) List all my cats\n" +
                "3) Search for a specific cat\n" +
                "4) Feed the cats\n" +
                "5) Play with the cats\n" +
                "6) Add another cat friend");

            int animalChoice = int.Parse(Console.ReadLine());

            switch (animalChoice)
            {
                case 1:
                    {
                        return;
                    }
                case 2:
                    {
                        SavedCats();
                        goto HMAIN;
                    }
                case 3:
                    {
                        CatSearch();
                        goto HMAIN;
                    }
                case 4:
                    {
                        FeedCats();
                        goto HMAIN;
                    }
                case 5:
                    {
                        CatPlay();
                        goto HMAIN;
                    }
                case 6:
                    {
                        CatFriend();
                        goto HMAIN;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Thats not an available choice, please pick a number 1-6");
                        goto HMAIN;
                    }
            }

        }

        public void SavedCats()
        {
            Console.Clear();
            foreach (Cat hhh in CatList)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", hhh.food, hhh.age, hhh.fun, hhh.name);
            }
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void CatSearch()
        {
            Console.Clear();
            Console.Write("Enter the name of the Cat you wish to get info on: ");
            string hSearch = Console.ReadLine();
            Cat match = CatList.Find((Cat hor) => { return hor.name == hSearch; });
            Console.WriteLine("name: {0}, age: {1}, fun: {2}, food: {3}", match.name, match.age, match.fun, match.food);
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void FeedCats()
        {
            Console.Clear();
            Console.WriteLine("What would you like to feed the cats?");
            string feed1 = Console.ReadLine();
            Console.WriteLine($"Dont worry, all the cats have been fed {feed1}!");
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void CatPlay()
        {
            Console.Clear();
            Console.WriteLine("What would you like to play with your cats?");
            string play1 = Console.ReadLine();
            Console.WriteLine($"Youre having so much fun playing {play1} with the cats!");
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void CatFriend()
        {
            Console.WriteLine("Tell me about your cat\n" +
                                "What kind of food does he eat?");
            string food = Console.ReadLine();

            Console.WriteLine("How old is it in years?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What does your cat do for fun?");
            string fun = Console.ReadLine();

            Console.WriteLine("Finally whats your cat's name???");
            string name = Console.ReadLine();

            Cat sampleCat = new Cat(food, age, fun, name);

            CatList.Add(sampleCat);

            Console.Clear();
            Console.WriteLine("The information for your cat has been saved.\n" +
                "What else would you like to do?\n");
            return;
        }
    }
}

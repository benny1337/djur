using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djur
{
    class Program
    {
        public static PetOwner PetOwner { get; set; }
        
        static void Main(string[] args)
        {
            MockData();
            do
            {
                var choice = ShowMenu();
                switch(choice)
                {
                    case 1:
                        Play(SelectAnimal());
                        break;
                    case 2:
                        Feed(SelectAnimal());
                        break;
                    case 3:
                        ListAnimals();
                        break;
                    case 4:
                        GetANewBall();
                        break;
                    case 5:
                        return;
                }
            } while (true);
        }

        private static void GetANewBall()
        {
            PetOwner.Ball = new Ball();
        }

        private static void ListAnimals()
        {
            var count = 1;
            foreach (var animal in PetOwner.Animals)
            {
                Console.WriteLine($"{count}: {animal.ToString()}");
                count++;
            }
        }

        private static void Feed(Animal a)
        {
            Console.WriteLine($"Which food do you want to feed {a.Name} with?");
            a.Eat(Console.ReadLine());
        }

        private static void Play(Animal a)
        {
            if (PetOwner.Ball != null)
                a.Interact(PetOwner.Ball);
            else
                a.Interact();
        }

        private static Animal SelectAnimal()
        {
            Console.WriteLine("Please write the corresponding number for an animal to select it:");
            
            do
            {
                ListAnimals();
                var choice = -1;
                Int32.TryParse(Console.ReadLine().ToString(), out choice);
                try
                {
                    choice--;
                    return PetOwner.Animals.ElementAt(choice);
                }
                catch (Exception) { Console.WriteLine("not a valid choice of animal"); }
            } while (true);
        }

        public static void MockData()
        {
            PetOwner = new PetOwner()
            {
                Ball = new Ball(),
                Age = 12,
                Animals = new List<Animal>()
                {
                    new Dog()
                    {
                        Name = "Jan Persson",
                        Age = 2,
                        Breed = "s:t bernard",
                        FavFood = "gammeldansk"
                    },
                    new Cat()
                    {
                        Age = 500,
                        Breed = "bonnakatt",
                        FavFood = "hund",
                        Name = "adam tall"
                    },
                    new Puppy()
                    {
                        FavFood = "entrecote",
                        Name = "optimus prime",
                        Breed = "tax",
                        Months = 7
                    }
                }
            };
        }
               

        public static int ShowMenu()
        {            
            Console.WriteLine($@"
1. Play
2. Feed
3. List animals
4. Get a new ball
5. Quit
");
            var choice = -1;
            do
            {
                Int32.TryParse(Console.ReadLine().ToString(), out choice);
                if (choice > 0 && choice < 6)
                {
                    Console.Clear();
                    return choice;
                }
                else
                    Console.WriteLine("Not a valid menuchoice");
            } while (true);
        }
    }
}

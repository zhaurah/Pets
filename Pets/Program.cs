using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static List<Animal> animals = new List<Animal>();
        private static readonly Random getrandom = new Random();
        
        static void Main(string[] args)
        {
            
            animals.Add(new Cat("Enpejst"));
            animals.Add(new Dog("Hot"));
            animals.Add(new Bird("Inamnamn"));
            animals.Add(new Dog("Ilito"));

            Console.WriteLine(@"--------------------

Welcome....

        GET A RANDOM ANIMAL!

Press any key to continue... (or escape to exit)");

            ConsoleKey ck = Console.ReadKey().Key;

            while (ck != ConsoleKey.Escape)
            {
                int n = getrandom.Next(0, animals.Count - 1); // Creates a number between 0 and last index of the list

                Console.WriteLine("\nYour animal is.... ");
                Console.WriteLine(animals[n].Show());
                Console.WriteLine("Press the Escape (Esc) key to quit or any key to continue: \n");
                ck = Console.ReadKey().Key;
            }


        }
    }
}

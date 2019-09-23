using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        public static int rando;
        public static int higher;
        public static int lower;
        public static int min = 1;
        public static int max = 100;

        public static Random random = new Random();
        

        static void Main(string[] args)
        {
            string choice = "";

            //Ask for the number
            Console.WriteLine("Ight fam I'm thinking of a number between 1 and 100.");
            Console.ReadLine();

            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(1, 100);
            }

            for (int i = 1; i < 100; i++)
            {
                rando = random.Next(min, max);
                Console.WriteLine("Is this the right number? " + rando);

                Console.WriteLine("Yes/Higher/Lower");
                choice = Console.ReadLine();

                if (choice == "Higher")
                {
                    min = rando + 1;
                    Console.WriteLine("Sike. Higher.");
                    Console.ReadLine();
                }
                else if (choice == "Lower")
                {
                    max = rando - 1;
                    Console.WriteLine("Sike. Lower.");
                    Console.ReadLine();
                }
                else if (choice == "Yes")
                {
                    Console.WriteLine("Sike. Lemme stop. You got it right.");
                    Console.ReadLine();
                    return;
                }
            }
        }


        public void test()
        {

        }
    }
}
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

        public static Random rando = new Random();
        

        static void Main(string[] args)
        {
            string choice = "";

            //Ask for the number
            Console.WriteLine("Ight fam I'm thinking of a number between 1 and 100.");
            Console.ReadLine();


            

            //for (int i = 1; i < 100 && i > 100; i++)
            {
                rando.Next(1, 100);
                Console.WriteLine("Is this the right number? " + rando)
                if (i is < rando)
                {
                    Console.WriteLine("Sike. Higher.");
                }
                if (i is > rando)
                {
                    Console.WriteLine("Sike. Lower.");
                }
                if (i is == rando)
                {
                    Console.WriteLine("Sike. Lemme stop. You got it right.");
                }
            }
        }
    }
}
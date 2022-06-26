using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.UC1();
            Program.UC2();
        }

        // UC1 Program file
        public static void UC1()
        {
            Console.WriteLine("Snake and ladder game played with singel player start at zero");
        }

        // UC2 Program file
        public static void UC2()
        {
            Random random = new Random();
            int number = random.Next(1, 7);
            Console.WriteLine("The Random player dice number is: " + number);
        }

        //UC3 Program file
        public static void UC_3()
        {
            int ladder = 1, ladderDice;
            int snake = 2, snakeDice;
            Random random = new Random();
            int Check_Random = random.Next(3);

            switch (Check_Random)
            {
                case 1:
                    {
                        Random lrandom = new Random();
                        ladderDice = lrandom.Next(1, 7);
                        Console.WriteLine("Got ladder and Player moves ahead by the number of position received in the die");
                        break;
                    }
                case 2:
                    {
                        Random srandom = new Random();
                        snakeDice = srandom.Next(1, 7);
                        Console.WriteLine("Got Snake and Player moves behind by the number of position received in the die");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No play, Player stay in same postion");
                        break;
                    }
            }

        }
    }
}

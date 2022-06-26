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
            Program.UC3();
            Program.UC4();
            Program.UC5();

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
        public static void UC3()
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

        //UC4 Program
        public static void UC4()
        {
            int ladder = 1, ladderDice;
            int snake = 2, snakeDice;
            int winLevel = 100;
            int count = 0;
            
            while (count <= winLevel)
            {
                if (count >= 0)
                {
                    Random random = new Random();
                    int randomCheck = random.Next(3);

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Random rnd = new Random();
                                ladderDice = rnd.Next(1, 7);
                                count = count + ladderDice;
                                Console.WriteLine("Got Ladder and Player moves the postion ahead");
                                break;
                            }
                        case 2:
                            {
                                Random snakeran = new Random();
                                snakeDice = snakeran.Next(1, 7);
                                count = count - snakeDice;
                                Console.WriteLine("Got snake and Player moves the behand by postion");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("No play and player staty in same postion");
                                break;
                            }
                    }
                }
                else
                {
                    count = 0;
                }

            }
            Console.WriteLine("Player reach the wining postion" + count);
        }

        //UC5 Program

        public static void UC5()
        {
            int ladder = 1, ladderDice = 0;
            int snake = 2, snakeDice;
            int winLevel = 100;
            int count = 0, num = 0;
            while (count != winLevel)
            {
                if (count >= 0 && count < 100)
                {
                    Random random = new Random();
                    int randomCheck = random.Next(3);

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Console.WriteLine("Got Ladder and move the postion by ahead");
                                Random ladder_random = new Random();
                                ladderDice = ladder_random.Next(1, 7);
                                count = count + ladderDice;
                                num = count;
                                break;
                            }
                        case 2:
                            {
                                Random snakeRandom = new Random();
                                snakeDice = snakeRandom.Next(1, 7);
                                count = count - snakeDice;
                                Console.WriteLine("Got snake and move the postion by behind");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("No play and player stay in same postion");
                                break;
                            }
                    }
                }
                else if (num > 100)
                {
                    count = num - ladderDice;
                }
                else
                {
                    count = 0;
                }

            }
            Console.WriteLine("Player exact wining postion " + count);
        }
    }
}

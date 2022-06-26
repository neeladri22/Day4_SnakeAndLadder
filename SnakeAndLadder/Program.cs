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
            Program.UC6();
            Program.UC7();

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

        //UC6 program

        public static void UC6()
        {
            int ladder = 1, ladderDice = 0;
            int snake = 2, snakeDice;
            int winLevel = 100;
            int diceRoll = 0;
            int count = 0, a = 0;
            
            while (count != winLevel)
            {
                if (count >= 0 && count < 100)
                {
                    Random random = new Random();
                    int randomCheck = random.Next(3);
                    diceRoll++;

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Console.WriteLine("Got Ladder and move the postion by ahead");
                                Random rnd = new Random();
                                ladderDice = rnd.Next(1, 7);
                                count = count + ladderDice;
                                Console.WriteLine("Position count is " + count);
                                a = count;
                                break;
                            }
                        case 2:
                            {
                                Random snakeRandom = new Random();
                                snakeDice = snakeRandom.Next(1, 7);
                                Console.WriteLine("Got snake and move the postion by behand");
                                count = count - snakeDice;
                                Console.WriteLine("Position count is: " + count);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("No play and player stay in same postion");
                                Console.WriteLine("Position count is: " + count);
                                break;
                            }
                    }
                }
                else if (a > 100)
                {
                    count = a - ladderDice;
                }
                else
                {
                    count = 0;
                }

            }
            Console.WriteLine("Player wins the postion" + count);
            Console.WriteLine("Number of time Dice Roll is to win: " + diceRoll);
        }

        //UC7 Program

        public static void UC7()
        {
            int ladder = 1, ldice = 0, ldice2 = 0;
            int snake = 2, sdice, sdice2;
            int win = 100;
            int diceRoll = 0, diceRoll2 = 0;
            int count = 0, count2 = 0, a = 0, b = 0;
            
            while (count != win && count2 != win)
            {
                if ((count >= 0 && count < 100) && (count2 >= 0 && count2 < 100)) 
                {
                    Random random = new Random();
                    int randomCheck = random.Next(3);
                    diceRoll++;

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Console.WriteLine("Player 1 Got Ladder");
                                Random rnd = new Random();
                                ldice = rnd.Next(1, 7);
                                count = count + ldice;
                                if (count > 100)
                                {
                                    count -= ldice;
                                }
                                Console.WriteLine("Player 1 Position is " + count);
                                a = count;
                                break;
                            }
                        case 2:
                            {
                                Random sran = new Random();
                                sdice = sran.Next(1, 7);
                                count = count - sdice;
                                if (count < 0)
                                {
                                    count += sdice;
                                }
                                Console.WriteLine("Player 1 Got snake");
                                Console.WriteLine("Player 1 position is: " + count);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Player 1 No play");
                                Console.WriteLine("Player 1 Position is: " + count);
                                break;
                            }
                    }

                    if (randomCheck == 1)
                    {
                        Random random3 = new Random();
                        int randomCheck3 = random3.Next(3);
                        diceRoll++;

                        switch (randomCheck3)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Player 1 Got Ladder");
                                    Random rnd3 = new Random();
                                    ldice = rnd3.Next(1, 7);
                                    count = count + ldice;
                                    if (count > 100)
                                    {
                                        count -= ldice;
                                    }
                                    Console.WriteLine("Player 1 Position is " + count);
                                    a = count;
                                    break;
                                }
                            case 2:
                                {
                                    Random sran3 = new Random();
                                    sdice = sran3.Next(1, 7);
                                    count = count - sdice;
                                    if (count < 0)
                                    {
                                        count += sdice;
                                    }
                                    Console.WriteLine("Player 1 Got snake");
                                    Console.WriteLine("Player 1 position is: " + count);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Player 1 No play");
                                    Console.WriteLine("Player 1 Position is: " + count);
                                    break;
                                }
                        }
                    }
                    
                    Random random2 = new Random();
                    int randomCheck2 = random2.Next(3);
                    diceRoll2++;

                    switch (randomCheck2)
                    {
                        case 1:
                            {
                                Console.WriteLine("Player 2 Got Ladder");
                                Random rnd2 = new Random();
                                ldice2 = rnd2.Next(1, 7);
                                count2 = count2 + ldice2;
                                if (count2 > 100)
                                {
                                    count2 -= ldice2;
                                }
                                Console.WriteLine("Player 2 Position is " + count2);
                                b = count2;
                                break;
                            }
                        case 2:
                            {
                                Random sran2 = new Random();
                                sdice2 = sran2.Next(1, 7);
                                count2 = count2 - sdice2;
                                if (count2 < 0)
                                {
                                    count2 += sdice2;
                                }
                                Console.WriteLine("Player 2 Got snake");
                                Console.WriteLine("Player 2 Position is: " + count2);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Player 2 No play");
                                Console.WriteLine("Player 2 Position is: " + count2);
                                break;
                            }
                    }

                    if (randomCheck2 == 1)
                    {
                        Random random4 = new Random();
                        int randomCheck4 = random4.Next(3);
                        diceRoll2++;

                        switch (randomCheck4)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Player 2 Got Ladder");
                                    Random rnd4 = new Random();
                                    ldice2 = rnd4.Next(1, 7);
                                    count2 = count2 + ldice2;
                                    if (count2 > 100)
                                    {
                                        count2 -= ldice2;
                                    }
                                    Console.WriteLine("Player 2 Position is " + count2);
                                    b = count2;
                                    break;
                                }
                            case 2:
                                {
                                    Random sran4 = new Random();
                                    sdice2 = sran4.Next(1, 7);
                                    count2 = count2 - sdice2;
                                    if (count2 < 0)
                                    {
                                        count2 += sdice2;
                                    }
                                    Console.WriteLine("Player 2 Got snake");
                                    Console.WriteLine("Player 2 Position is: " + count2);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Player 2 No play");
                                    Console.WriteLine("Player 2 Position is: " + count2);
                                    break;
                                }
                        }
                    }
                }
            }
            if (count > count2)
            {
                Console.WriteLine("Player 1 win and the point is: " + count);
                Console.WriteLine("Number of times dice roll is: " + diceRoll);
            }
            else
            {
                Console.WriteLine("Player 2 win and the point is: " + count2);
                Console.WriteLine("Number of times dice roll is: " + diceRoll2);
            }
        }
    }
}

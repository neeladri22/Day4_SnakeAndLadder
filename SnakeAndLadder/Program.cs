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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AP
{
    class Program
    {
        public static int[] map = new int[100];
        static void Main(string[] args)
        {
            Console.WriteLine(@"□◎卐▲☆");
            GameHeadline();
            Console.ReadKey();
        }
        /// <summary>
        /// Draw the game's headline
        /// </summary>
        public static void GameHeadline()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("********Flying Chess  By Jian ********");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("**************************************");
        }
        /// <summary>
        /// Initial the game's map
        /// </summary>
        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//Luckyturn
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//Landmine
            int[] pause = { 9, 27, 60, 93 };//Pause
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };
        }
    }
}
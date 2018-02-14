using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_03
{
    class Program
    {
        public static string _rec = null;
        public static string[] _grades = new string[10];
        static void Main(string[] args)
        {
            string iNum = null;
            for (int i = 0; i < _grades.Length; i++)
            {
                iNum = i.ToString();
                _grades[i] = "Tester" + iNum;
            }
            for (int i = 0; i < _grades.Length; i++)
            {
                Console.WriteLine(_grades[i]);
                _rec = Console.ReadLine();
                Test(_rec);
            }
        }
        /// <summary>
        /// Grades checker
        /// </summary>
        /// <param name="s">The user's input</param>
        /// <returns>A bool value</returns>
        public static bool Test(string s)
        {
            while (true)
            {
                try
                {
                    double tester = double.Parse(s);
                    return true;
                }
                catch
                {
                    Console.WriteLine("Inputted error, please try again");
                    s = Console.ReadLine();
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        public static int _timer = 0;
        public static int _temp = 0;
        public static string[] _temps = new string[3];
        static void Main(string[] args)
        {
            string[] DispTester = new string[3];
            DispTester[0] = "Math: ";
            DispTester[1] = "Chinese: ";
            DispTester[2] = "English: ";
            string[] UserInputsTester = new string[3];
            if (_timer == 0)
            {
                for (int i = 0; i < DispTester.Length; i++)
                {
                    Console.WriteLine(DispTester[i]);
                    UserInputsTester[i] = Console.ReadLine();
                    _temps[i] = UserInputsTester[i];
                    if (int.TryParse(UserInputsTester[i], out int number) == false)
                    {
                        Console.WriteLine("Inputted error!");
                        _temps[i] = UserInputsTester[i];
                        _temp = i;
                        i -= 1;
                        _timer++;
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                    }
                }
            }
            else
            {
                for (int i = 0; i < _temp; i++)
                {
                    Console.WriteLine("{0}\n{1}", DispTester[i], _temps[i]);
                }
            }
        }
    }
}
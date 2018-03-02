using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades_Calculator
{
    class Program
    {
        public static string _languageReceiver = null;
        public static string[] _en_US = { "GC_Calculator", "v2.1 beta", "Powered by Jian", "Welcome to send feedbacks", "if you find bugs or have some good ideas", "Feedback email: xxx@outlook.com      Thank you  ^_^", "New UI", "Lighter and more powerful", "Less bugs", "You can close the program by inputting 'exit' while using it.", @"You can input one of the numbers on the 'DisplayBoard' to use its function
   in this interface.
   If you want to start now, just press 'Enter' key on your keyboard." };
        public static string[] _zh_CN = { "分数计算器", "版本 2.1 测试副本", "Jian 制作", "如果在使用本程序时遇到问题或有好的建议", "欢迎随时反馈", "反馈邮箱: xxx@outlook.com      多谢 ^_^" };
        public static string[] _languageChooser = new string[11];
        public static string _displayBoard = null;
        public static int _recTimer = 0;
        public static int _disTimer = 0;
        public static bool _languager = true;
        public static bool _runner = true;
        public static bool _recChecker = true;
        public static bool _breaker = true;
        static void Main(string[] args)
        {

            if (_runner)
            {

                if (_languager)
                {
                    if (_recTimer == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Choose your language");
                        Console.ForegroundColor = ConsoleColor.White;
                        _languageReceiver = Console.ReadLine();
                        Breaker(_languageReceiver, args);
                    }
                    switch (_languageReceiver)
                    {
                        case "1":
                            for (int i = 0; i < _languageChooser.Length; i++)
                            {
                                _languageChooser[i] = _en_US[i];
                            }
                            break;
                        case "2":
                            for (int i = 0; i < _languageChooser.Length; i++)
                            {
                                _languageChooser[i] = _zh_CN[i];
                            }
                            break;
                        default:
                            while (true)
                            {
                                _breaker = Breaker(_languageReceiver, args);
                                if (_breaker == false)
                                {
                                    Console.WriteLine("Inputted error, please try again/Chinese");
                                    _languageReceiver = Console.ReadLine();
                                    if (_languageReceiver == "1" || _languageReceiver == "2")
                                    {
                                        _recTimer += 1;
                                        Console.Clear();
                                        Main(args);
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
■                                                                           ■
■                                                                           ■
■                               {0}                               ■
■                                 {1}                                 ■
■                                                                           ■
■                              {2}                              ■    
■                                                                           ■
■                         {3}                         ■
■                  {4}                 ■
■                                                                           ■ 
■           {5}             ■", _languageChooser[0], _languageChooser[1], _languageChooser[2], _languageChooser[3], _languageChooser[4], _languageChooser[5]);
                    if (_disTimer == 0)
                    {
                        Console.WriteLine(@"■                                                                           ■
■              1. What's new     2. How to use     3. exit                  ■");
                    }
                    Console.WriteLine(@"■                                                                           ■
■                                                                           ■
■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
");
                    if (_disTimer == 0)
                    {
                        _displayBoard = Console.ReadLine();
                        Features(_displayBoard, args);
                    }
                }
            }
        }
        public static void Features(string disp, string[] args)
        {
            switch (disp)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(@"
----------------------------------------------------------------------------
----------------------------------------------------------------------------

1. {0}
2. {1}
3. {2}

----------------------------------------------------------------------------
----------------------------------------------------------------------------
", _languageChooser[6], _languageChooser[7], _languageChooser[8]);
                    _recTimer++;
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "2":
                    Console.WriteLine(@"
----------------------------------------------------------------------------
----------------------------------------------------------------------------

1. {0}
2. {1}

----------------------------------------------------------------------------
----------------------------------------------------------------------------
", _languageChooser[9], _languageChooser[10]);
                    _recTimer++;
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "3":
                default:
                    Breaker(disp, args);
                    _disTimer += 1;
                    Console.Clear();
                    Main(args);
                    break;
            }
        }
        public static bool Breaker(string input, string[] args)
        {
            if (input == "exit" || input == "EXIT" || _displayBoard == "3")
            {
                _runner = false;
                Main(args);
                return true;
            }
            return false;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        public static string _languageReceiver = null;
        public static string[] _en_US = { "Maths: ", "Chinese: ", "English: ", "Politics: ", "History: ", "Chemistry: ", "Physics: ", "Biology: ", "Geography: ", "PE: ", "Press any key to exit . . .", "Inputted error, try again please!", "Your total marks:{0} \n\nYour last marks: ", "Congratulations!\nYou've got {0} more marks~", "It seems that there's no differences between the marks.\nKeep trying!", "Emm...Just keep trying and you'll be successful!", "Would you like to calculate others' scores?\t y/n", "GC_Calculator", "v2.1 beta", "Powered by Jian", "Welcome to send feedbacks", "if you find bugs or have some good ideas", "Feedback email: xxx@outlook.com      Thank you  ^_^", "New UI", "Lighter and more powerful", "Less bugs", "You can close the program by inputting 'exit' while using it.", "Just input one of the numbers above or leave blank to skip\nLearn about the features: " };
        public static string[] _zh_CN = { "数学：", "语文：", "英语： ", "政治：", "历史：", "化学：", "物理", "生物：", "地理：", "体育：", "按下任意键退出 . . .", "输入有误，请重新输入！", "你的总分数：{0} \n\n上次的分数：", "太棒了！你比上次多得了{0}分", "继续保持！", "继续努力！", "你想计算其他人的成绩吗？", "分数计算器", "版本 2.1 测试副本", "Jian 制作", "如果在使用本程序时遇到问题或有好的建议", "欢迎随时反馈", "反馈邮箱: xxx@outlook.com      多谢 ^_^", "程序体积更小，功能更加实用", "修复漏洞", "在使用时，通过输入 \"exit\" 来退出程序",
"输入以上数字序号之一，或者保留空白以跳过\n了解功能："};
        public static string[] _languageChooser = new string[28];
        public static string _displayBoard = null;
        public static int _recTimer = 0;
        public static int _disTimer = 0;
        public static int _totalScore = 0;
        public static int _difference = 0;
        public static bool _languager = true;
        public static bool _runner = true;
        public static bool _recChecker = true;
        public static bool _breaker = true;
        public static bool _rec = true;
        public static bool _ex = true;
        public static bool _languageController = true;
        static void Main(string[] args)
        {

            if (_runner)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                string[] inpt = new string[10];
                int[] inps = new int[10];
                int temp = 0;
                int number = 0;
                #region Languager
                if (_languager)
                {
                    if (_recTimer == 0)
                    {

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Choose your language");
                        _languageReceiver = Console.ReadLine();
                        Breaker(_languageReceiver, args);
                    }
                    if (_languageController)
                    {
                        switch (_languageReceiver)
                        {
                            case "1":
                                for (int i = 0; i < _languageChooser.Length; i++)
                                {
                                    _languageChooser[i] = _en_US[i];
                                    Console.Clear();
                                }
                                break;
                            case "2":
                                for (int i = 0; i < _languageChooser.Length; i++)
                                {
                                    _languageChooser[i] = _zh_CN[i];
                                    Console.Clear();
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
                    }
                    #endregion
                    #region Display Board

                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                    Console.WriteLine(@"■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
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
■           {5}             ■", _languageChooser[17], _languageChooser[18], _languageChooser[19], _languageChooser[20], _languageChooser[21], _languageChooser[22]);
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
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(_languageChooser[27]);
                        _displayBoard = Console.ReadLine();
                        Features(_displayBoard, args);
                    }
                    #endregion
                }
            }
        }
        /// <summary>
        /// DisplayBoard
        /// </summary>
        /// <param name="disp">The display number</param>
        /// <param name="args">Main Method</param>
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
----------------------------------------------------------------------------
----------------------------------------------------------------------------
", _languageChooser[6], _languageChooser[7]);
                    _recTimer++;
                    _languageController = false;
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
                    _languageController = false;
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "3":
                default:
                    Breaker(disp, args);
                    _disTimer += 1;
                    _recTimer++;
                    _languageController = false;
                    Console.Clear();
                    Main(args);
                    break;
            }
        }
        /// <summary>
        /// A method to close the program
        /// </summary>
        /// <param name="input">The user's input</param>
        /// <param name="args">Main Method</param>
        /// <returns></returns>
        public static bool Breaker(string input, string[] args)
        {
            if (input == "exit" || input == "EXIT" || _displayBoard == "3")
            {
                _runner = false;
                _rec = false;
                _ex = false;
                Main(args);
                return true;
            }
            return false;
        }
    }
}
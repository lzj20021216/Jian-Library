﻿using System;

namespace Core_01
{
    class Program
    {
        public static int _totalScore = 0;
        public static int _difference = 0;
        public static bool _rec = true;
        public static bool _ex = true;
        public static bool _languager = true;
        public static string[] _en_US = { "Maths: ", "Chinese: ", "English: ", "Politics: ", "History: ", "Chemistry: ", "Physics: ", "Biology: ", "Geography: ", "PE: ", "Press any key to exit . . .", "Inputted error, try again please!", "Your total marks:{0} \n\nYour last marks: ", "Congratulations!\nYou've got {0} more marks~", "It seems that there's no differences between the marks.\nKeep trying!", "Emm...Just keep trying and you'll be successful!", "Would you like to calculate others' scores?\t y/n" };
        public static string[] _zh_CN = { "数学：", "语文：", "英语： ", "政治：", "历史：", "化学：", "物理", "生物：", "地理：", "体育：", "按下任意键退出 . . .", "输入有误，请重新输入！", "你的总分数：{0} \n\n上次的分数：", "太棒了！你比上次多得了{0}分", "继续保持！", "继续努力！", };
        public static string[] _languageChooser = new string[17];
        public static string _languageReceiver = null;
        static void Main(string[] args)
        {
            #region GC_Body
            string[] inpt = new string[10];
            string displayBoard = null;
            int[] inps = new int[10];
            int number = 0;
            int temp = 0;
            if (_languager)
            {
                Console.WriteLine(@"Choose your language/请选择你的语言
1. English
2. 中文（简体）");
                _languageReceiver = Console.ReadLine();
                switch (_languageReceiver)
                {
                    case "1":
                        for (int i = 0; i < _en_US.Length; i++)
                        {
                            _languageChooser[i] = _en_US[i];
                        }
                        Console.WriteLine(@"
■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
■                                                                           ■
■                                                                           ■
■                               GC_Calculator                               ■
■                                 v2.1 beta                                 ■
■                                                                           ■
■                              Powered by Jian                              ■    
■                                                                           ■
■                         Welcome to send feedbacks                         ■
■                  if you find bugs or have some good ideas!                ■
■                                                                           ■ 
■           Feedback email: xxx@outlook.com      Thank you  ^_^             ■
■                                                                           ■
■              1. What's new     2. How to use     3. exit                  ■
■                                                                           ■
■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
");
                        displayBoard = Console.ReadLine();
                        switch (displayBoard)
                        {
                            case "1":
                                Console.WriteLine();
                                break;
                            case "2":
                                Console.WriteLine("");
                                break;
                            case "3":
                                _languager = false;
                                _rec = false;
                                _ex = false;
                                Main(args);
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        for (int i = 0; i < _zh_CN.Length; i++)
                        {
                            _languageChooser[i] = _zh_CN[i];
                        }
                        break;
                    default:
                        if (_languageReceiver == "exit" || _languageReceiver == "EXIT")
                        {
                            _languager = false;
                            _rec = false;
                            _ex = false;
                            Console.WriteLine(_en_US[10] + "\n" + _zh_CN[10]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("------------------------------------------------------------------------");
                            Console.WriteLine(_en_US[11] + "\n" + "\n");
                            Console.WriteLine(_zh_CN[11]);
                            Console.WriteLine("------------------------------------------------------------------------\n");
                            Main(args);
                        }
                        break;
                }
            }
            while (_rec)
            {
                for (int i = 0; i < 10; i++)
                {
                    temp = i;
                    Console.WriteLine(_languageChooser[i]);
                    inpt[i] = Console.ReadLine();
                    bool a = int.TryParse(inpt[i], out number);
                    if (a == false)
                    {
                        if (inpt[i] == "exit" || inpt[i] == "EXIT")
                        {
                            Console.WriteLine(_languageChooser[10]);
                            _ex = false;
                            _rec = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(_languageChooser[11]);
                            i -= 1;
                            continue;
                        }
                    }
                    else
                    {
                        inps[temp] = int.Parse(inpt[temp]);
                        if (temp == 9)
                        {
                            _rec = false;
                        }
                    }
                }
            }
            #endregion

            #region Ending Checker
            if (_ex)
            {
                Viewer(inps, number, args);
            }

            else
            {

            }
            #endregion
            //Console.ReadKey();
        }
        /// <summary>
        /// A method of calculating
        /// </summary>
        /// <param name="inps">An array to save users' scores</param>
        public static void Viewer(int[] inps, int number, string[] args)
        {
            string permission = null;
            for (int i = 0; i < inps.Length; i++)
            {
                _totalScore += inps[i];
            }
            Console.WriteLine(_languageChooser[12], _totalScore);
            string lastS = null;
            for (int i = 0; i < 1; i++)
            {
                lastS = Console.ReadLine();
                bool b = int.TryParse(lastS, out number);
                if (b == false)
                {
                    if (lastS == "exit" || lastS == "EXIT")
                    {
                        Console.WriteLine(_languageChooser[10]);
                        break;
                    }
                    else
                    {
                        i -= 1;
                        Console.WriteLine(_languageChooser[11]);
                        continue;
                    }
                }
                else
                {
                    int lastSC = int.Parse(lastS);
                    _difference = _totalScore - lastSC;
                    if (_difference > 0)
                    {
                        Console.WriteLine(_languageChooser[13], _difference);
                    }
                    else if (_difference == 0)
                    {
                        Console.WriteLine(_languageChooser[14]);
                    }
                    else
                    {
                        Console.WriteLine(_languageChooser[15]);
                    }
                    Console.WriteLine(_languageChooser[16]);
                    RecycleChecker(permission, args);
                }
            }
        }
        /// <summary>
        /// A method of controlling if the user wants to calculate other's grades
        /// </summary>
        /// <param name="permission">The user's permission</param>
        /// <param name="args">An array from Main</param>
        public static void RecycleChecker(string permission, string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 1)
                {
                    permission = "n";
                }
                else
                {
                    permission = Console.ReadLine();
                }
                switch (permission)
                {
                    case "y":
                    case "Y":
                        _rec = true;
                        Console.WriteLine(@"
-----------------------------------------------------------------------------------

The second part
Tips: Your can exit at any time by entering 'exit' or 'Exit'

-----------------------------------------------------------------------------------

");
                        _languager = false;
                        Main(args);
                        break;
                    case "n":
                    case "N":
                        Console.WriteLine(_languageChooser[10]);
                        i = 3;
                        break;
                    default:
                        if (permission == "exit" || permission == "EXIT")
                        {
                            Console.WriteLine(_languageChooser[10]);
                            i = 20;
                        }
                        else
                        {
                            Console.WriteLine(_languageChooser[11]);
                            i -= 1;
                            continue;
                        }
                        break;
                }
            }
        }
    }
}
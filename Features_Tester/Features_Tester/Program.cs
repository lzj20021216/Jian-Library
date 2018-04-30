using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_Tester
{
    class Program
    {
        public static string _languageReceiver = null;
        public static string[] _en_US = { "Maths: ", "Chinese: ", "English: ", "Politics: ", "History: ", "Chemistry: ", "Physics: ", "Biology: ", "Geography: ", "PE: ", "Press any key to exit . . .", "Inputted error, try again please!", "Your total marks:{0} \n\nYour last marks: ", "Congratulations!\nYou've got {0} more marks~", "It seems that there's no differences between the marks.\nKeep trying!", "Emm...Just keep trying and you'll be successful!", "Would you like to calculate others' scores?\t y/n", "GC_Calculator", "v2.1 beta", "Powered by Jian", "Welcome to send feedbacks", "if you find bugs or have some good ideas", "Feedback email: xxx@outlook.com      Thank you  ^_^", "1. What's new     2. How to use     3. exit", "New UI", "Lighter and more powerful", "Less bugs", "You can close the program by inputting 'exit' while using it.", "Just input one of the numbers above or leave blank to skip\nLearn about the features: ", };
        public static string[] _zh_CN = { "数学：", "语文：", "英语： ", "政治：", "历史：", "化学：", "物理", "生物：", "地理：", "体育：", "按下任意键退出 . . .", "输入有误，请重新输入！", "你的总分数：{0} \n\n上次的分数：", "太棒了！你比上次多得了{0}分", "继续保持！", "继续努力！", "你想计算其他人的成绩吗？", "     分数计算器", "\b 版本 2.1 测试副本", "       Jian 制作", "\b如果在使用本程序时遇到问题或有好的建议", "\t\t  欢迎随时反馈", "\t     反馈邮箱: xxxx@outlook.com      多谢 ^_^", "    1. 新增功能     2. 使用方法     3. 退出程序", "新的界面", "小体积，大功能", "修复bug", "在使用时，通过输入 \"exit\" 来退出程序", "输入以上数字序号之一，或者保留空白以跳过\n了解功能：" };
        public static string[] _languageChooser = new string[29];
        public static string[] _inpt = new string[10];
        public static string _displayBoard = null;
        public static string _colorChooser = null;
        public static string _sNum = null;
        public static int[] _inps = new int[10];
        public static int _recTimer = 0;
        public static int _disTimer = 0;
        public static int _clearTimer = 0;
        public static int _totalScore = 0;
        public static int _difference = 0;
        public static int _temp = 0;
        public static int _number = 0;
        public static bool _languager = true;
        public static bool _runner = true;
        public static bool _recChecker = true;
        public static bool _breaker = true;
        public static bool _rec = true;
        public static bool _ex = true;
        public static bool _languageController = true;
        public static bool _tester = true;
        public static bool _clearPermission = false;
        static void Main(string[] args)
        {
            if (_runner)
            {
                #region Languager
                if (_languager)
                {
                    if (_recTimer == 0)
                    {
                        #region Console Color
                        if (_tester)
                        {
                            Console.WriteLine("Codes: ");
                            _colorChooser = "Light";
                            _sNum = "1";
                            if (_colorChooser == null && _colorChooser != "Light" && _colorChooser != "light" && _colorChooser != "Dark" && _colorChooser != "dark")
                            {
                                _colorChooser = "dark";
                            }
                            ColorController(_colorChooser, _sNum, args);
                        }
                        #endregion
                        _sNum = "2";
                        ColorController(_colorChooser, _sNum, args);
                        Console.WriteLine("Choose your language");
                        _languageReceiver = "1";
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
                                }
                                Console.Clear();
                                break;
                            case "2":
                                for (int i = 0; i < _languageChooser.Length; i++)
                                {
                                    _languageChooser[i] = _zh_CN[i];
                                }
                                Console.Clear();
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
                    _sNum = "3";
                    ColorController(_colorChooser, _sNum, args);
                    Console.WriteLine(@"
--------------------------------------------------------------------------------
                               {0}                                
                                {1}                                  
                                                                           
                             {2}                                  
                                                                        
                       {3}                         
                {4}                 
                                                                        
         {5}             
", _languageChooser[17], _languageChooser[18], _languageChooser[19], _languageChooser[20], _languageChooser[21], _languageChooser[22]);
                    if (_disTimer == 0)
                    {
                        Console.WriteLine(@"                                                                       
              {0}
                 
--------------------------------------------------------------------------------
", _languageChooser[23]);
                    }
                    if (_disTimer == 0)
                    {
                        _sNum = "4";
                        ColorController(_colorChooser, _sNum, args);
                        Console.Write(_languageChooser[28]);
                        _displayBoard = "";
                        Features(_displayBoard, args);
                    }
                    #endregion
                    Calculator_DisplayBoard(args);
                    #region Ending Checker
                    if (_ex)
                    {
                        Viewer(_inps, _number, args);
                    }

                    else
                    {

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
                    _sNum = "6";
                    ColorController(_colorChooser, _sNum, args);
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
                    _languager = false;
                    _tester = false;
                    Console.Clear();
                    Main(args);
                    break;
            }
        }
        /// <summary>
        /// A method to collect information
        /// </summary>
        /// <param name="args">Main Method</param>
        public static void Calculator_DisplayBoard(string[] args)
        {
            while (_rec)
            {
                _sNum = "5";
                ColorController(_colorChooser, _sNum, args);
                for (int i = 0; i < 10; i++)
                {
                    _temp = i;
                    Console.WriteLine(_languageChooser[i]);
                    _inpt[i] = Console.ReadLine();
                    bool a = int.TryParse(_inpt[i], out _number);
                    if (a == false)
                    {
                        ++_clearTimer;
                        if (Breaker(_inpt[i], args))
                        {
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
                        if (_clearTimer != 0)
                        {
                            Console.Clear();
                            Calculator_DisplayBoard(args);
                        }
                        _inps[_temp] = int.Parse(_inpt[_temp]);
                        if (_temp == 9)
                        {
                            _rec = false;
                        }
                    }
                }
            }
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
                    if (Breaker(lastS, args) == true)
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
        /// <param name="args">An array from Main Method</param>
        public static void RecycleChecker(string permission, string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 1 || i == 3)
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
                        _languager = true;
                        _languageController = false;
                        _disTimer = 0;
                        Console.Clear();
                        Main(args);
                        break;
                    case "n":
                    case "N":
                        Console.WriteLine(_languageChooser[10]);
                        permission = "exit";
                        Breaker(permission, args);
                        break;
                    default:
                        if (Breaker(permission, args) == true)
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
        /// <summary>
        /// A method of Colors Controller
        /// </summary>
        /// <param name="colorReceiver">The user's input</param>
        /// <param name="cl">Collection</param>
        /// <param name="args">An array form Main Method</param>
        public static void ColorController(string colorReceiver, string cl, string[] args)
        {
            switch (colorReceiver)
            {
                case "Light":
                case "light":
                    switch (cl)
                    {
                        case "1":
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            break;
                        case "2":
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case "3":
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case "4":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case "5":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case "6":
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;

                    }
                    break;
                case "Dark":
                case "dark":
                default:
                    switch (cl)
                    {
                        case "1":
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            break;
                        case "2":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case "3":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case "4":
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case "5":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case "6":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                    }
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_ToolBox
{
    class Program
    {
        public static string[] _dpLpk = new string[3000];
        public static string[] _userInputs = new string[3000];
        public static string[] _DP_One = new string[3000];
        public static string[] _DP_Two = new string[3000];
        public static string[] _displayBoardShow = new string[2];
        public static bool _recPermission = true;
        public static bool _showPermission = true;
        public static bool _showPermissionTwo = true;
        public static bool _showPermissionThree = true;
        public static bool _showPermissionFour = true;
        public static bool _WindowAdaptor = false;
        public static string[] _protectionCase = { "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*" };
        public static int _recTimeController = 0;
        static void Main(string[] args)
        {
            if (_recPermission == true)
            {
                Console.Clear();
                if (_recTimeController == 0)
                {
                    _WindowAdaptor = ApplicationWindowsShellAdaptor(args, "", Console.WindowWidth, Console.WindowHeight);
                    _recTimeController++;
                }
                Console.Title = "Ultimate Toolbox By lzj20021216";
                Console.WriteLine("Choose your language:\n1. English\n2. Chinese (Simplified)");
                _userInputs[0] = null;
                LanguagePacks lpks = new LanguagePacks(_userInputs[0]);
                _dpLpk = lpks.DisplayLpk();
                Console.Clear();
                UserInterface(args);
            }
            else
            {
                Console.WriteLine(_dpLpk[30]);
            }
            Console.ReadKey(true);
        }
        /// <summary>
        /// A method to show the user's interface
        /// </summary>
        /// <param name="args">A 'string[]' type array to support Main method</param>
        public static void UserInterface(string[] args)
        {
            if (_WindowAdaptor == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(_dpLpk[0]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n\n" + _dpLpk[1]);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n\n" + _dpLpk[2]);
                Console.Write("\n\n" + _dpLpk[3]);
                Console.Write("\n\n" + _dpLpk[4]);
                Console.ForegroundColor = ConsoleColor.White;
                if (_showPermissionFour == true)
                {
                    Console.Write("\n\n" + _dpLpk[5]);
                    Console.Write("\t" + _dpLpk[6]);
                    Console.Write("\t" + _dpLpk[7]);
                    Console.Write("\t" + _dpLpk[8]);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                   " + _dpLpk[26] + "     ");
                    Console.Write(_dpLpk[27] + "     ");
                    Console.Write(_dpLpk[28] + "     ");
                    Console.Write(_dpLpk[29]);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\n" + _dpLpk[0]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(_dpLpk[31]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n\n\n" + _dpLpk[32]);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n\n\n" + _dpLpk[33]);
                Console.Write("\n\n\n" + _dpLpk[34]);
                Console.Write("\n\n\n" + _dpLpk[35]);
                Console.ForegroundColor = ConsoleColor.White;
                if (_showPermissionFour == true)
                {
                    Console.Write("\n\n\n" + _dpLpk[36]);
                    Console.Write("\t" + "      " + _dpLpk[37]);
                    Console.Write("\t" + "      " + _dpLpk[38]);
                    Console.Write("       " + _dpLpk[39]);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                                                           " + _dpLpk[26] + "     ");
                    Console.Write(_dpLpk[27] + "     ");
                    Console.Write(_dpLpk[28] + "     ");
                    Console.Write(_dpLpk[29]);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\n\n\n" + _dpLpk[31]);
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            if (_showPermissionTwo == true && _showPermissionThree == true)
            {
                Console.Write(_dpLpk[9]);
                _userInputs[1] = Console.ReadLine();
                ApplicationWindowsShellAdaptor(args, _userInputs[1], Console.WindowWidth, Console.WindowHeight);
            }
            else
            {
                if (_showPermissionFour == true)
                {
                    Console.Write(_dpLpk[9] + _userInputs[1] + "\n");
                }
                else
                {
                    Console.Write(_dpLpk[9]);
                    _userInputs[1] = Console.ReadLine();
                    ApplicationWindowsShellAdaptor(args, _userInputs[1], Console.WindowWidth, Console.WindowHeight);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (int.TryParse(_userInputs[1], out int number1) == true)
            {
                if (_showPermissionFour == true)
                {
                    if (int.Parse(_userInputs[1]) > 0 && int.Parse(_userInputs[1]) < 5)
                    {
                        ShowBoard(args);
                    }
                }
                else
                {
                    ShowBoardTwo(args);
                }
            }
            else
            {
                Console.Clear();
                UserInterface(args);
            }
        }
        /// <summary>
        /// A method that is able to show some information to the user
        /// </summary>
        /// <param name="args">A 'string[]' type array to support Main method</param>
        public static void ShowBoard(string[] args)
        {
            switch (_userInputs[1])
            {
                case "1":
                default:
                    _showPermission = false;
                    LoginModel(args);
                    break;
                case "2":
                    _displayBoardShow[0] = _dpLpk[11];
                    _displayBoardShow[1] = _dpLpk[12];
                    break;
                case "3":
                    _displayBoardShow[0] = _dpLpk[13];
                    _displayBoardShow[1] = _dpLpk[14];
                    break;
                case "4":
                    _showPermission = false;
                    _recPermission = false;
                    Console.Clear();
                    Main(args);
                    break;
            }
            if (_showPermission)
            {
                Console.WriteLine("\n" + _dpLpk[10] + "\n\n\n" + _displayBoardShow[0] + "\n\n\n" + _displayBoardShow[1] + "\n\n\n" + _dpLpk[10] + "\n");
                Console.ReadKey(true);
                Console.Clear();
                UserInterface(args);
            }
        }
        /// <summary>
        /// A user can choose a feature to use with this method
        /// </summary>
        /// <param name="args">A 'string[]' type array to support Main method</param>
        public static void ShowBoardTwo(string[] args)
        {
            switch (_userInputs[1])
            {
                case "1":
                    GradesCalculatorLauncher(args);
                    break;
                case "2":
                    WordMasterLauncher(args);
                    break;
                case "3":
                    RandomNumbersCreatorLauncher(args);
                    break;
                case "4":
                    _showPermission = false;
                    _recPermission = false;
                    Console.Clear();
                    Main(args);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// A security model to check if the user have a license
        /// </summary>
        /// <param name="args">A 'string[]' type array to support Main Method</param>
        public static void LoginModel(string[] args)
        {
            if (_showPermissionThree == true)
            {
                Console.Write(_dpLpk[16]);
                _userInputs[2] = "lzj20021216";
                if (_userInputs[2] == "Exit" || _userInputs[2] == "exit" || _userInputs[3] == "Back" || _userInputs[4] == "back")
                {
                    Console.WriteLine(_dpLpk[19]);
                    _showPermission = false;
                    _showPermissionThree = false;
                }
                Console.Write(_dpLpk[17]);
                Console.ForegroundColor = ConsoleColor.Black;
                _userInputs[3] = "toolbox.com12345lzj";
                _showPermissionThree = false;
                Console.Clear();
                UserInterface(args);
            }
            else
            {
                if (_showPermissionFour == true)
                {
                    string s = "";
                    for (int i = 0; i < _userInputs[3].Length; i++)
                    {
                        s += _protectionCase[i];
                    }
                    Console.Write(_dpLpk[16] + _userInputs[2] + "\n");
                    Console.Write(_dpLpk[17] + s + "\n");
                }
            }
            if (_userInputs[2] == "lzj20021216" && _userInputs[3] == "toolbox.com12345lzj" && _showPermissionFour == true)
            {
                Console.WriteLine(_dpLpk[20]);
                _showPermissionThree = false;
                _showPermissionFour = false;
            }
            else
            {
                if (_showPermissionFour == true)
                {
                    Console.WriteLine(_dpLpk[21]);
                    Console.ReadKey(true);
                    Console.Clear();
                    _showPermissionTwo = false;
                    _showPermissionThree = true;
                    UserInterface(args);
                }
                else
                {
                    _showPermissionTwo = false;
                    _showPermissionThree = true;
                    Console.Title = "Ultimate Toolbox By lzj20021216    -----     Login as " + _userInputs[2];
                    Console.ReadKey();
                    _userInputs[1] = null;
                    Console.Clear();
                    UserInterface(args);
                }
            }
        }
        /// <summary>
        /// To launch the application: Grades Calculator
        /// </summary>
        /// <param name="args">A 'string[]' type array to support Main method</param>
        public static void GradesCalculatorLauncher(string[] args)
        {
            GC gcLauncher = new GC();
            Console.Clear();
            gcLauncher.Indoor(args);
        }
        /// <summary>
        /// To launch the application: Word Master
        /// </summary>
        /// <param name="args">A 'string[]' type array to support Main method</param>
        public static void WordMasterLauncher(string[] args)
        {

        }
        /// <summary>
        /// To launch the application: Random Numbers Creator
        /// </summary>
        /// <param name="args">A 'string[]' type array to support Main method</param>
        public static void RandomNumbersCreatorLauncher(string[] args)
        {
            RMCreator rm = new RMCreator();
            Console.Clear();
            rm.Indoor(args);
        }
        /// <summary>
        /// An inportant shell that is able to control the appearance of the user interface
        /// </summary>
        /// <param name="args">A 'string[]' type array to support Main method</param>
        /// <param name="WindowResetCommand">A 'string' type value, making sure that whether the user want to change the interface</param>
        /// <param name="Width">A 'int' type value to get the Window's Width</param>
        /// <param name="Height">A 'int' type value to get the Window's Height</param>
        /// <returns></returns>
        public static bool ApplicationWindowsShellAdaptor(string[] args, string WindowResetCommand, int Width, int Height)
        {
            //Full Screen --> Width:197 Height:58
            //Normal Screen --> Width: 120 Height: 30
            //WindowResetCommand = "";
            //Width = 0;
            //Height = 0;
            if (_recTimeController == 0)
            {
                //Full Screen Mode
                if (Width == 197 && Height == 58)
                {
                    _recTimeController++;
                    return true;
                }
            }
            //In-application Checker
            if (WindowResetCommand.Contains("reset window") || WindowResetCommand.Contains("rewind"))
            {
                if (_recTimeController == 1)
                {
                    if (Width == 197 && Height == 58)
                    {
                        _WindowAdaptor = true;
                        Main(args);
                        return _WindowAdaptor;
                    }
                    if (Width == 120 && Height == 30)
                    {
                        _WindowAdaptor = false;
                        Main(args);
                        return _WindowAdaptor;
                    }
                }
            }
            return false;//Normal Screen Mode
        }
    }
}

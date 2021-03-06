﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Word_Master
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
        public static int _recTimer = 0;
        public static int _permitedTimer = 0;
        static void Main(string[] args)
        {
            if (_recPermission == true)
            {
                Console.Title = "Word Master";
                Console.WriteLine("Choose your language:\n1. English\n2. Chinese (Simplified)");
                _userInputs[0] = Console.ReadLine();
                LanguagePacks lpks = new LanguagePacks(_userInputs[0]);
                _dpLpk = lpks.DisplayLpk();
                WordList wlShow = new WordList(_DP_One, _DP_Two);
                _DP_One = wlShow.DisplayPortOne();
                _DP_Two = wlShow.DisplayPortTwo();
                Console.Clear();
                UserInterface(args);
            }
            else
            {
                Console.WriteLine(_dpLpk[18]);
            }
            Console.ReadKey(true);
        }
        /// <summary>
        /// A method to show the user's interface
        /// </summary>
        public static void UserInterface(string[] args)
        {
            if (_recTimer == 0)
            {
                Console.WriteLine("\n" + _dpLpk[0] + "\n\n" + _dpLpk[1] + "\n\n\n" + "\t\t\t\t\t" + _dpLpk[2] + "\n\n" + "\t\t\t\t\t\t" + _dpLpk[3] + "\n\n" + "\t\t\t\t" + _dpLpk[4] + "\n");
                Console.Write("\t\t\t" + _dpLpk[5] + "\t" + _dpLpk[6] + "\t" + _dpLpk[7] + "\t" + _dpLpk[8] + "\n\n\n" + _dpLpk[0] + "\n\n" + _dpLpk[9]);
                _userInputs[1] = Console.ReadLine();
                if (int.TryParse(_userInputs[1], out int number2) == true)
                {
                    if (int.Parse(_userInputs[1]) > 0 && int.Parse(_userInputs[1]) < 5)
                    {
                        ShowBoard(args);
                    }
                    else
                    {
                        LoginModel(args);
                    }
                }
                else
                {
                    LoginModel(args);
                }
            }
            else
            {
                Console.WriteLine(_dpLpk[0] + "\n\n" + _dpLpk[1] + "\n\n\n" + "\t\t\t\t\t" + _dpLpk[2] + "\n\n" + "\t\t\t\t\t\t" + _dpLpk[3] + "\n\n" + "\t\t\t\t" + _dpLpk[4] + "\n" + "\n\n" + _dpLpk[0]);
                Console.Write(_dpLpk[23]);
                _userInputs[7] = Console.ReadLine();
                switch (_userInputs[7])
                {
                    case "1":
                        WordMasterMode1(args);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                }
                
            }
        }
        /// <summary>
        /// A meothod to show the features of this application
        /// </summary>
        /// <param name="args"></param>
        public static void ShowBoard(string[] args)
        {
            switch (_userInputs[1])
            {
                case "1":
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
        /// A method to check the passport so that the user can use this application
        /// </summary>
        public static void LoginModel(string[] args)
        {
            Console.WriteLine(_dpLpk[15]);
            _userInputs[3] = Console.ReadLine();
           
            bool temp = ps.Result();
            if (temp == false)
            {
                Console.WriteLine(_dpLpk[19]);
                return;
            }
            Console.WriteLine(_dpLpk[16]);
            _userInputs[4] = Console.ReadLine();
            Console.WriteLine(_dpLpk[17]);
            _userInputs[5] = Console.ReadLine();
            PasswordChecker pwdChecker = new PasswordChecker(_userInputs[4], _userInputs[5]);
            temp = pwdChecker.Result();
            if (temp == false)
            {
                Console.WriteLine(_dpLpk[19]);
                return;
            }
            else
            {
                _recTimer++;
                Console.Clear();
                UserInterface(args);
            }
        }
        /// <summary>
        /// The core feature of this application
        /// </summary>
        public static void WordMasterMode1(string[] args)
        {
            Console.WriteLine("\n"+"Word List");
            Console.WriteLine(_dpLpk[20]);
            Console.WriteLine(_dpLpk[21] + "\n");
            Console.WriteLine(_dpLpk[20]);
            Console.Write(_dpLpk[22]);
            _userInputs[6] = Console.ReadLine();
            switch (_userInputs[6])
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
                case "10":
                    break;
                case "11":
                    break;
                case "12":
                    break;
                case "13":
                    break;
                case "14":
                    break;
                case "15":
                    break;
                case "16":
                    break;
                case "17":
                    break;
                case "18":
                    break;
                case "19":
                    break;
                case "20":
                    break;
                case "21":
                    break;
                case "22":
                    break;
                case "23":
                    break;
                case "24":
                    break;
                case "25":
                    break;
                case "26":
                    break;
                case "27":
                    break;
                default:
                    break;
            }
        }
    }
}
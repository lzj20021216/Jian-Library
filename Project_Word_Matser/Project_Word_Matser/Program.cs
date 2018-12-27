using System;
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
                Console.WriteLine("Choose your language:\n1. English\n2. Chinese (Simplified)");
                _userInputs[0] = Console.ReadLine();
                LanguagePacks lpks = new LanguagePacks(_userInputs[0]);
                _dpLpk = lpks.DisplayLpk();
                WordList wlShow = new WordList(_DP_One, _DP_Two);
                _DP_One = wlShow.DisplayPortOne();
                _DP_Two = wlShow.DisplayPortTwo();
                Console.Clear();
                UserInterface();
            }
            Console.ReadKey(true);
        }
        /// <summary>
        /// A method to show the user's interface
        /// </summary>
        public static void UserInterface()
        {
            Console.WriteLine("\n" + _dpLpk[0] + "\n\n" + _dpLpk[1] + "\n\n\n" + "\t\t\t\t\t" + _dpLpk[2] + "\n\n" + "\t\t\t\t\t\t" + _dpLpk[3] + "\n\n" + "\t\t\t\t" + _dpLpk[4] + "\n");
            Console.Write("\t\t\t" + _dpLpk[5] + "\t" + _dpLpk[6] + "\t" + _dpLpk[7] + "\t" + _dpLpk[8] + "\n\n\n" + _dpLpk[0] + "\n\n" + _dpLpk[9]);
            _userInputs[1] = Console.ReadLine();
            ShowBoard();
        }
        public static void ShowBoard()
        {
            switch (_userInputs[1])
            {
                case "1":
                    break;
                case "2":
                    _displayBoardShow[0] = null;
                    _displayBoardShow[1] = null;
                    break;
                case "3":
                    _displayBoardShow[0] = null;
                    _displayBoardShow[1] = null;
                    break;
                default:
                    break;
            }
            if (_showPermission)
            {
                Console.WriteLine(_dpLpk[10] + "\n\n" + "{0}" + "\n\n\n" + "{1}" + "\n\n" + _dpLpk[10]);
            }
        }
    }
}
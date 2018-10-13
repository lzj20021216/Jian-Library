using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks_Plus_Plus
{
    public class Program
    {
        public static string[] _dpLpk = new string[30];
        public static ConsoleColor[] _theme = new ConsoleColor[6];
        public static string[] usersInputs = new string[14];
        public static bool _recController = true;
        public static bool _firstUse = true;
        static void Main(string[] args)
        {
            while (_recController)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("Choose your default language/请选择您的语言\n1. English\n2. 中文（简体）");
                usersInputs[0] = Console.ReadLine();
                Console.Clear();
                LanguagePacks lpk = new LanguagePacks(usersInputs[0]);
                _dpLpk = lpk.DisplayLpk();
                Console.WriteLine("══════════════════════════════════════════\n\nChange your theme:     /     改变您的主题    \n1. Light(浅色)\n2. Dark(深色)\n  \n══════════════════════════════════════════");
                usersInputs[1] = Console.ReadLine();
                ThemeSelector cps = new ThemeSelector(usersInputs[1]);
                _theme = cps.ColorPack();
                Console.BackgroundColor = _theme[0];
                Console.ForegroundColor = _theme[1];
                Console.Clear();
                UserInterface();
            }
            //Console.WriteLine(Tips);
            Console.ReadKey();
        }
        /// <summary>
        /// A method of showing the features of the program
        /// </summary>
        public static void UserInterface()
        {
            Console.ForegroundColor = _theme[2];
            Console.WriteLine("{0}\n\n{1}\n\n{2}\n\n{3}\n\n{4}\n\n{5}\n\n{6}\n\n{7}\n\n{8}", _dpLpk[29], _dpLpk[17], _dpLpk[18], _dpLpk[19], _dpLpk[20], _dpLpk[21], _dpLpk[22], _dpLpk[23], _dpLpk[29]);
            Console.ForegroundColor = _theme[3];
            Console.Write(_dpLpk[28]);
            usersInputs[2] = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
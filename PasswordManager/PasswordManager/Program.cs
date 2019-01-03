using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class Program
    {
        public static int[] _unnums = new int[10];
        public static char[] _unchara = new char[3];
        public static int[] _uneNum = new int[10];
        public static int[] _pwdnums = new int[10];
        public static char[] _pwdchara = new char[6];
        public static int[] _pwdeNum = new int[10];
        public static bool _permission = false;
        public static string _userInp = null;
        static void Main(string[] args)
        {
            Console.Title = "Passport Manager";
            Console.Write("Input the key\n(Leave blank if you don't have one): ");
            _userInp = Console.ReadLine();
            PassportKeyValue pkv = new PassportKeyValue(_permission, _userInp);
            _permission = pkv.ProgramChecker();
            Console.Clear();
            if (_permission == true)
            {
                Console.Clear();
                Console.Write("Input the key\n(Leave blank if you don't have one): ");
                for (int i = 0; i < _userInp.Length; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                RandomUserName un = new RandomUserName(_unnums, _unchara, _uneNum);
                string username = un.UserNameMaker();
                PasswordCalculator pwd = new PasswordCalculator(_pwdnums, _pwdchara, _pwdeNum);
                string password = pwd.PasswordMaker();
                Console.WriteLine("User Name: {0}\nPassword: {1}", username, password);
            }
            else
            {
                Console.WriteLine("Press any key to exit . . .");
            }
            Console.ReadKey();
        }
    }
}
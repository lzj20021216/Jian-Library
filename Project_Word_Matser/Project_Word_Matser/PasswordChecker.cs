using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Word_Master
{
    public class PasswordChecker
    {
        public static bool _Passport = false;
        public static int _temp = 0;
        public PasswordChecker(string inputOne, string inputTwo)
        {
            this.UserName = inputOne;
            this.Password = inputTwo;
        }
        private string _username;
        public string UserName
        {
            get { return _username; }
            set
            {
                string[] uns1 = new string[10];
                int[] uni1 = new int[10];
                char[] unc1 = value.ToCharArray();
                for (int i = 3; i < value.Length; i++)
                {
                    uns1[i - 3] = unc1[i].ToString();
                }
                for (int i = 0; i < uni1.Length; i++)
                {
                    if (int.TryParse(uns1[i], out int numberOne) == true)
                    {
                        uni1[i] = int.Parse(uns1[i]);
                    }
                }
                for (int i = 0; i < uni1.Length; i++)
                {
                    _temp += uni1[i];
                }
                if (_temp > 34 && _temp < 70)
                {
                    if (value.Contains("l"))
                    {
                        _Passport = true;
                    }
                }
                _username = value;
            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _temp = 0;
                string[] uns1 = new string[10];
                int[] uni1 = new int[10];
                char[] unc1 = value.ToCharArray();
                for (int i = 6; i < value.Length; i++)
                {
                    uns1[i - 6] = unc1[i].ToString();
                }
                for (int i = 0; i < uni1.Length; i++)
                {
                    if (int.TryParse(uns1[i], out int numberOne) == true)
                    {
                        uni1[i] = int.Parse(uns1[i]);
                    }
                }
                for (int i = 0; i < uni1.Length; i++)
                {
                    _temp += uni1[i];
                }
                if (_temp > 34 && _temp < 70)
                {
                    if (value.Contains("E") && value.Contains("L"))
                    {
                        _Passport = true;
                    }
                    else if (value.Contains("l") && value.Contains("z") && value.Contains("j"))
                    {
                        _Passport = true;
                    }
                    else
                    {
                        _Passport = false;
                    }
                }
                _password = value;
            }
        }
        public bool Result()
        {
            return _Passport;
        }
    }
}
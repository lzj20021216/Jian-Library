using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Word_Master
{
    public class PassportChecker
    {
        public PassportChecker(string input)
        {
            this.PsChecker = input;
        }
        public static bool _Passport = false;
        private string _passportChecker;
        public string PsChecker
        {
            get { return _passportChecker; }
            set
            {
                if (value == "lzj20021216%")
                {
                    _Passport = true;
                }
                _passportChecker = value;
            }
        }
        public bool Result()
        {
            return _Passport;
        }
    }
}

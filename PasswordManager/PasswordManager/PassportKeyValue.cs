using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public class PassportKeyValue
    {
        public PassportKeyValue(bool permission, string passportKey)
        {
            this.Permission = permission;
            this.PassportKey = passportKey;
        }
        private bool _permission;
        public bool Permission
        {
            get { return _permission; }
            set { _permission = value; }
        }
        private string _passportKey;
        public string PassportKey
        {
            get { return _passportKey; }
            set { _passportKey = value; }
        }
        public bool Checker()
        {
            if (PassportKey == "lzj021216@%")
            {
                return true;
            }
            return false;
        }
    }
}
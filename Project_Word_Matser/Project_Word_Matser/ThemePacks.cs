using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Word_Master
{
    public class ThemePacks
    {
        private ConsoleColor[] _dark = new ConsoleColor[10];
        public ConsoleColor[] Dark
        {
            get { return _dark; }
            set { _dark = value; }
        }
        private ConsoleColor[] _light = new ConsoleColor[10];
        public ConsoleColor[] Light
        {
            get { return _light; }
            set { _light = value; }
        }
    }
}
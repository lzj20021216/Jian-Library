using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks_Plus_Plus
{
    public class ThemeSelector
    {
        public ThemeSelector(string choice)
        {
            this.Choice = choice;
        }
        private ConsoleColor[] _colorPacks;
        public ConsoleColor[] ColorPacks
        {
            get { return _colorPacks; }
            set { _colorPacks = value; }
        }
        private string _choice;
        public string Choice
        {
            get { return _choice; }
            set
            {
                switch (value)
                {
                    case "Light":
                    case "light":
                    case "1":
                    case "One":
                    case "one":
                        Light();
                        break;
                    case "Dark":
                    case "dark":
                    case "2":
                    case "Two":
                    case "two":
                        Dark();
                        break;
                    default:
                        Dark();
                        break;
                }
                _choice = value;
            }
        }
        /// <summary>
        /// A method of Light Theme
        /// </summary>
        /// <returns>Color Pack</returns>
        public ConsoleColor[] Light()
        {
            ConsoleColor[] ltColors = { ConsoleColor.White, ConsoleColor.DarkGreen, ConsoleColor.DarkBlue, ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Magenta };
            return ColorPacks = ltColors;
        }
        /// <summary>
        /// A method of Dark Theme
        /// </summary>
        /// <returns>Color Pack</returns>
        public ConsoleColor[] Dark()
        {
            ConsoleColor[] dkColors = { ConsoleColor.Black, ConsoleColor.Yellow, ConsoleColor.Cyan, ConsoleColor.Red, ConsoleColor.DarkMagenta, ConsoleColor.Blue };
            return ColorPacks = dkColors;
        }
        /// <summary>
        /// A method to show the result
        /// </summary>
        /// <returns>The theme</returns>
        public ConsoleColor[] ColorPack()
        {
            return ColorPacks;
        }
    }
}
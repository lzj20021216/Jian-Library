using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Word_Master
{
    public class LanguagePacks
    {
        public LanguagePacks(string choices)
        {
            this.Choices = choices;
        }
        private string[] _displayLanguagePack = new string[0];
        public string[] DisplayLanguagePack
        {
            get { return _displayLanguagePack; }
            set { _displayLanguagePack = value; }
        }
        private string _choices;
        public string Choices
        {
            get { return _choices; }
            set
            {
                switch (value)
                {
                    case "1":
                    case "One":
                    case "one":
                        _en_US();
                        break;
                    case "2":
                    case "Two":
                    case "two":
                        _zh_CN();
                        break;
                    case "3":
                    case "Three":
                    case "three":
                        //ja_JP
                        break;
                    //etc
                    default:
                        _en_US();
                        break;
                }
                _choices = value;
            }
        }
        /// <summary>
        /// A method of a lpk
        /// </summary>
        /// <returns>English(United States)</returns>
        public string[] _en_US()
        {
            string[] _en_US = {
            "■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■", //0
            @"
            \\\\     ////    00000     1OOO0     DDDDD               MM       MM        /\        Z Z Z
             \\\  ^  ///    0     0    1   0     D    D              M M     M M       A  A          Z
              \\ / \ //     0     0    1 \\      D    D              M  M   M  M      A----A       Z
               \/   \/       00000     1  \\     DDDDD               M    M    M     A      A     Z Z Z   ", //1
            "Word Maz(Code name: Project \"Word Master\")", //2
            "Powered by lzj20021216", //3
            "For testing purpose only.build.csapplicationPJ_WMlzj02 ", //4
            "1. Login", //5
            "2. How-to", //6
            "3. About the developer", //7
            "     4. Exit", //8
            "Just input one of the numbers above or leave blank to skip\nLearn about the features: ", //9
            "-----------------------------------------------------------------------------------------------------------------------", //10
            };
            return DisplayLanguagePack = _en_US;
        }
        /// <summary>
        /// A method of a lpk
        /// </summary>
        /// <returns>Chinese(Simplified)</returns>
        public string[] _zh_CN()
        {
            string[] _zh_CN = {
            };
            return DisplayLanguagePack = _zh_CN;
        }
        /// <summary>
        /// A method to show the result
        /// </summary>
        /// <returns>The lpk</returns>
        public string[] DisplayLpk()
        {
            return DisplayLanguagePack;
        }
    }
}
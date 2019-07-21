using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_ToolBox
{
    public class WordList
    {
        public WordList(string[] dpOne, string[] dpTwo)
        {
            this.ChineseCharacters = dpOne;
            this.Words = dpTwo;
        }
        private string[] _ChineseCharacters = new string[3000];
        private string[] _words = new string[3000];
        public string[] ChineseCharacters
        {
            get { return _ChineseCharacters; }
            set
            {
                value[0] = "";
                _ChineseCharacters = value;
            }
        }
        public string[] Words
        {
            get { return _words; }
            set
            {
                value[0] = "";
                _words = value;
            }
        }
        public string[] DisplayPortOne()
        {
            return ChineseCharacters;
        }
        public string[] DisplayPortTwo()
        {
            return Words;
        }
    }
}
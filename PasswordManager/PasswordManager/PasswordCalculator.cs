using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public class PasswordCalculator
    {
        public static int _temp = 0;
        public char[] _letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public PasswordCalculator(int[] nums, char[] characters, int[] numtester)
        {
            this.Nums = nums;
            this.Characters = characters;
            this.NumTester = numtester;
        }
        private int[] _nums = new int[10];
        public int[] Nums
        {
            get { return _nums; }
            set { _nums = value; }
        }
        private char[] _characters = new char[6];
        public char[] Characters
        {
            get { return _characters; }
            set
            {
                Random r = new Random();
                int rNumber = 0;
                while (true)
                {
                    for (int i = 0; i < Characters.Length; i++)
                    {
                        rNumber = r.Next(1, 50);
                        value[i] = _letters[rNumber];
                    }
                    if ((value.Contains('E') && value.Contains('L')))
                    {
                        break;
                    }
                    else if ((value.Contains('l') && value.Contains('z') && value.Contains('j')))
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                _characters = value;
            }
        }
        private int[] _numTester = new int[10];
        public int[] NumTester
        {
            get { return _numTester; }
            set { _numTester = value; }
        }
        private string _fullPassword;
        public string FullPassword
        {
            get { return _fullPassword; }
            set { _fullPassword = value; }
        }
        public string PasswordMaker()
        {
            Random rNumber = new Random();
            int RandomNumber = 0;
            for (int i = 0; i < this.Nums.Length; i++)
            {
                RandomNumber = rNumber.Next(5, 10);
                this.NumTester[i] = RandomNumber;
                _temp += NumTester[i];
                if (_temp > 34 && _temp < 70)
                {
                    this.Nums[i] = this.NumTester[i];
                }
            }
            string chara = new string(Characters);
            FullPassword = chara;
            for (int i = 0; i < Nums.Length; i++)
            {
                FullPassword += Nums[i].ToString();
            }
            return FullPassword;
        }
    }
}
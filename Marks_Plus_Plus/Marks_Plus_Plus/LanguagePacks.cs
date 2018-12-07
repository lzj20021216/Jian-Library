using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks_Plus_Plus
{
    public class LanguagePacks
    {
        public LanguagePacks(string choices)
        {
            this.Choices = choices;
        }
        private string[] _displayLanguagePack = new string[34];
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
                "Maths: ", //0
                "Chinese: ", //1
                "English: ", //2
                "Politics: ", //3
                "History: ", //4
                "Chemistry: ", //5
                "Physics: ", //6
                "Biology: ", //7
                "Geography: ", //8
                "PE: ", //9
                "Press any key to exit . . .", //10
                "Inputted error, try again please!", //11
                "Your total marks:{0} \n\nYour last marks: ", //12
                "Congratulations!\nYou've got {0} more marks~", //13
                "It seems that there's no differences between the marks.\nKeep trying!", //14
                "Emm...Just keep trying and you'll be successful!", //15
                "Would you like to calculate others' scores?\t y/n", //16
                "\t\t\t\t    GC_Calculator", //17
                "\t\t\t\t      v2.1 beta", //18
                "\t\t\t\t   Powered by Jian", //19
                "\t\t\t      Welcome to send feedbacks", //20
                "\t\t       if you find bugs or have some good ideas", //21
                "\t      Feedback email: lzj20021216@outlook.com      Thank you  ^_^", //22
                "\t\t      1. What's new     2. How to use     3. exit", //23
                "New UI", //24
                "Lighter and more powerful", //25
                "Less bugs", //26
                "You can close the program by inputting 'exit' while using it.", //27
                "Just input one of the numbers above or leave blank to skip\nLearn about the features: ", //28
                "-----------------------------------------------------------------------------------", //29
                "Lighter and more powerful", //30
                "Less bugs", //31
                "You can close the program by inputting 'exit' while using it.", //32
                "Just input one of the numbers above or leave blank to skip\nLearn about the features: " //33
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
                "数学：",
                "语文：",
                "英语： ",
                "政治：",
                "历史：",
                "化学：",
                "物理",
                "生物：",
                "地理：",
                "体育：",
                "按下任意键退出 . . .",
                "输入有误，请重新输入！",
                "你的总分数：{0} \n\n上次的分数：",
                "太棒了！你比上次多得了{0}分",
                "继续保持！",
                "继续努力！",
                "你想计算其他人的成绩吗？y/n",
                "     分数计算器",
                "\b 版本 2.1 测试副本",
                "       Jian 制作",
                "\b如果在使用本程序时遇到问题或有好的建议",
                "\t\t  欢迎随时反馈",
                "\t 反馈邮箱: lzj20021216@outlook.com      多谢 ^_^",
                "    1. 新增功能     2. 使用方法     3. 退出程序",
                "新的界面", "小体积，大功能",
                "修复bug",
                "在使用时，通过输入 \"exit\" 来退出程序",
                "输入以上数字序号之一，或者保留空白以跳过\n了解功能：",
                "--------------------------------------------------------------",
                "新的界面", "小体积，大功能",
                "修复bug",
                "在使用时，通过输入 \"exit\" 来退出程序",
                "输入以上数字序号之一，或者保留空白以跳过\n了解功能："
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
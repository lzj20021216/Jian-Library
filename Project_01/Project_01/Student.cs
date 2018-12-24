using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    public class Student : Person
    {
        public Student(string name, int age, char gender, int math, int chinese, int english, string job) : base(name, age, gender)
        {
            math = this.Math;
            chinese = this.Chinese;
            english = this.English;
            job = this.Job;
        }
        private string _job;
        public string Job
        {
            get { return _job; }
            set { _job = value; }
        }
        private int _math;
        public int Math
        {
            get { return _math; }
            set
            {
                if (value < 0 || value > 150)
                {
                    value = 0;
                }
                _math = value;
            }
        }
        private int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _chinese = value;
            }
        }
        private int _english;
        public int English
        {
            get { return _english; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _english = value;
            }
        }
        public void StudentSayHello()
        {
            Console.WriteLine("Math: {0}\nChinese: {1}\nEnglish: {2},Total: {3},Average Score: {4}", this.Math, this.Chinese, this.English, this.Math + this.Chinese + this.English, (this.Math + this.Chinese + this.English) / 3);
        }
    }
}
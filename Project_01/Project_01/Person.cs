using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    public class Person
    {
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        private char _gender;
        public char Gender
        {
            get
            {
                if (_gender != 'M' && _gender != 'F')
                {
                    return _gender = 'M';
                }
                return _gender;
            }
            set { _gender = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("Hi, I'm{0}.I'm {1} years old, I'm a {2}", this.Name, this.Age, this.Gender);
        }
    }
}
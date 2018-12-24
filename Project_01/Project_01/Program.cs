using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ZhangSan = new Student("Zhang San", 15, 'M', 120, 110, 149, "Student");
            ZhangSan.SayHello();
            Console.ReadKey();
        }
    }
}
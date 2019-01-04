using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            string tester = "lzj20021216";
            char[] tes = tester.ToCharArray();
            string[] tesTwo = new string[8];
            int[] tesThree = new int[8];
            for (int i = 3; i < tester.Length; i++)
            {
                tesTwo[i-3] = tes[i].ToString();
            }
            for (int i = 0; i < tesThree.Length; i++)
            {
                tesThree[i] = int.Parse(tesTwo[i]);
            }
            for (int i = 0; i < tesThree.Length; i++)
            {
                temp += tesThree[i];
            }
            Console.WriteLine(temp);
            Console.ReadKey(true);
        }
    }
}
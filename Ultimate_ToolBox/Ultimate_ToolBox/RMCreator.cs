using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_ToolBox
{
    public class RMCreator
    {
        public static int[] nums = new int[5];
        public static string[] numbers = new string[100];
        public void Indoor(string[] args)
        {
            RandomNumbersCreators();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(numbers[i] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            for (int i = 0; i < 5; i++)
            {
                nums[i] = 0;
            }
            for (int i = 0; i < 100; i++)
            {
                numbers[i] = "";
            }
            Console.WriteLine();
            Indoor(args);
        }
        public void RandomNumbersCreators()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Random number = new Random();
                    int nNumber = number.Next(1, 10);
                    nums[j] = nNumber;
                }
                for (int k = 0; k < 5; k++)
                {
                    numbers[i] += nums[k].ToString();
                }
            }
        }
    }
}

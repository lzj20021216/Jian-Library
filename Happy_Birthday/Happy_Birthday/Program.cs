using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            const bool BirthdayIsHappy = true;
            Console.WriteLine("Happy birthday and thank you!");
            //You know that these names can't be displayed in a line! >_<
            string[] SayingThanksTo = {"lz","zb","yxh","gjt","wwl","dyhg","Kylian Mbappé",
                "gza","xlx","tzy","zsx & why","lxy","yax","lyt","wj","My Daughter",
                "Hard Hard","hst","nzc","djx","zs","ly","lb","gsh","and you" };
            if (BirthdayIsHappy == true)
            {
                for (int i = 0; i < SayingThanksTo.Length; i++)
                {
                    Console.WriteLine("Thank you, {0}! ^_^", SayingThanksTo[i]);
                }
            }
            //Get them if you find this link! But only for one day!
            string key1 = "27h7d60";//Guess what will happen if the numbers++ ?
            string key2 = "PowerPoint File Name Extensions";
            string key3 = "eQ27uj6iy_46B";//Guess what will happen if both the numbers++ and the characters++ ?
            string gifts = "https://pan.baidu.com/s/" + key1 + key2 + key3;
            string password = null;
            int SingleNumber = 2;
            SingleNumber -= 1;//Step 1
            SingleNumber += 1;//Step 2
            password = "n" + "Steps";
            Console.WriteLine("Link: {0}\nPassword: {1}", gifts, password);
            Console.ReadKey();
        }
    }
}
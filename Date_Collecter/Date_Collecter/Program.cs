using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Collecter
{
    class Program
    {
        public static int _numbersCollected = 0;
        public static bool _recControllerOne = true;
        public static string[] _dates = new string[1000];
        public static int _cyclingTimer = 0;
        public static int _temp1 = 0;
        public static string[] _tester = { };
        static void Main(string[] args)
        {
            while (_recControllerOne == true)
            {
                Console.WriteLine("How many dates would you like to handle with this application?\nNumbers only. eg. 10  The maximum is 1000");
                string times = Console.ReadLine();
                if (int.TryParse(times, out int number) == true)
                {
                    if (int.Parse(times) > 1000 || int.Parse(times) < 1)
                    {
                        WarningsMaker();
                        continue;
                    }
                    else
                    {
                        _recControllerOne = false;
                        _numbersCollected = int.Parse(times);
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    WarningsMaker();
                    continue;
                }
            }
            if (_cyclingTimer == 0)
            {
                _temp1 = 0;
            }
            for (_temp1 = _cyclingTimer; _temp1 < _numbersCollected; _temp1++)
            {
                Console.WriteLine("[{0}]Input the date(eg. 10:16:34 --> 101634)", _temp1 + 1);
                _dates[_temp1] = Console.ReadLine();
                Checker(_dates[_temp1]);
            }
            for (int i = 0; i < _numbersCollected; i++)
            {
                char[] splits = _dates[i].ToCharArray();
                char[] hour = { splits[0], splits[1] };
                char[] minute = { splits[2], splits[3] };
                char[] second = { splits[4], splits[5] };
                string strHour = new string(hour);
                string strMinute = new string(minute);
                string strSecond = new string(second);
                Console.WriteLine("{0}:{1}:{2}",strHour,strMinute,strSecond);
            }
            Console.ReadKey();
        }
        public static void WarningsMaker()
        {
            Console.WriteLine("Inputted error, try again.");
            Console.ReadKey(true);
            Console.Clear();
        }
        public static void Checker(string userInput)
        {
            if (int.TryParse(userInput, out int number) == false)
            {
                WarningsMaker();
                _cyclingTimer = _temp1;
                DataMonitor();
                Main(_tester);
            }
            else
            {
                if (userInput.Length != 6)
                {
                    WarningsMaker();
                    _cyclingTimer = _temp1;
                    DataMonitor();
                    Main(_tester);
                }
            }
        }
        public static void DataMonitor()
        {
            if (_cyclingTimer == 0)
            {

            }
            else
            {
                for (int i = 0; i < _cyclingTimer; i++)
                {
                    Console.WriteLine("Date[{0}]" + _dates[i], i + 1);
                }
            }
        }
    }
}

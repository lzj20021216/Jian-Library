using System;

namespace Project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now I'm 1 year older than before, congratulations!
            Console.WriteLine("Happy Birthday!");
            string[] peoplewhosentmeagift = { "Meng", "Liu", "Huang", "Mu", "Minghui", "etc" };
        }
        public static void Wishes(ref string peoplewhosentmeagift)
        {
            /* peoplewhosentmeagift[2], peoplewhosentmeagift[3] 
             * and peoplewhosentmeagift[4] will get this */
            bool wantobebeautiful = false;  
            bool wanttobeagay = false;
            //♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂
            if (wantobebeautiful == true)
            {
                Console.WriteLine(@"Magic mirror! Magic mirror!
Who is the most beautiful w♂man in the world?");
            }
            //♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂♂
            if (wanttobeagay == true)
            {
                Console.WriteLine("Fuck ♂ you~");//Now others, this belongs to you! Hei hei
            }
            Console.ReadKey();
        }
    }
}
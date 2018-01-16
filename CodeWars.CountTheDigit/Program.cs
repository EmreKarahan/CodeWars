using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodeWars.CountTheDigit
{
    class Program
    {
        static void Main(string[] args)
        {

            //CountDig.NbDig(5750, 0);
            CountDig.NbDig(11011, 2);
            CountDig.NbDig(12224, 8);
            CountDig.NbDig(11549, 1);
        }
    }

    public class CountDig
    {

        public static int NbDig(int n, int d)
        {
            var num_d = 0;
            for (int i = 1; i <= n; i++)



            {
                var iStr = i.ToString();
                var re = new Regex("g");
                num_d += re.Match(d.ToString()).Length;
            }
            return num_d;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.FindTheDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
          var result =  Kata.Divisors(12);
        }
    }

    

    public class Kata
    {
        public static int[] Divisors(int n)
        {
            List<int> l = new List<int>();
            for (int i = 2; i <= Math.Sqrt(n); i++) if (n % i == 0) l.Add(i);
            if (l.Count == 0) return null;
            List<int> k = new List<int>(l.ToArray().Select(x => n / x).ToArray().Where(x => !l.Contains(x)).Reverse());
            l.AddRange(k);
            return l.ToArray();
        }
    }    
    }    

}

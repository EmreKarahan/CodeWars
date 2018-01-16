using System;
using System.Collections.Generic;

namespace CodeWars.ValueTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            char Search = 'e';
            Char[] Letters = "Herkese Benden Çay Şakire Yok".ToCharArray();
            GetLetter(Search, Letters);
            Console.ReadLine();
        }

        public static void GetLetter(char letter, char[] letters)
        {
            List<int> indexList = new List<int>();

            for (int i = 0; i < letters.Length; i++)
            {
                if (letter == letters[i])
                {
                    indexList.Add(i + 1);
                }
            }

            var result = (letter, indexList);

            foreach (var item in result.Item2)
            {
                Console.WriteLine(item + ":" + result.Item1);
            }
        }
    }
}

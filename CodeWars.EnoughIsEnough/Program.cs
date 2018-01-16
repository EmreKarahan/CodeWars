using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.EnoughIsEnough
{
    class Program
    {
        static void Main(string[] args)
        {

            var data1 = Kata.DeleteNth(new int[] { 3, 1, 2, 3, 1, 1, 1, 3, 3, 1 }, 2); // return [20,37,21]
           

            Console.WriteLine(data1.ToString());
        }
    }

        internal class Kata
        {
            public static int[] DeleteNth(int[] arr, int p1)
            {
                List<int> resultTemp = new List<int>();
                List<int> result = new List<int>();

                var grp = arr.GroupBy(p => p);

                foreach (IGrouping<int, int> item in grp.ToList())
                {
                    resultTemp.AddRange(item.Take(p1));
                }

                foreach (var item in arr)
                {
                    if (resultTemp.FirstOrDefault(w => w == item) == 0) continue;
                
                        result.Add(resultTemp.FirstOrDefault(f => f == item));
                        resultTemp.Remove(resultTemp.FirstOrDefault(f => f == item));
                }
                return result.ToArray();
            }
        }
}

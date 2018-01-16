using System;
using System.Threading;
using System.Threading.Tasks;

namespace CodeWars.AsyncExamplesTAP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            TaskBasedAsyncPattern.CallSelamAsync();
            //CallContinueSelamAsync();
            Console.WriteLine("Running");
            var a = 10 + 4;
            Console.WriteLine(a);
            Thread.Sleep(500);
            Console.WriteLine("Running");
            Console.ReadKey();
        }
    }
}

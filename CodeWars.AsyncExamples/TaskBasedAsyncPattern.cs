using System;
using System.Threading;
using System.Threading.Tasks;

namespace CodeWars.AsyncExamplesTAP
{
    public class TaskBasedAsyncPattern
    {
        // Async olan SelamAsync metodunu çağırıyoruz.
        public static async void CallSelamAsync()
        {
            string result = await SelamAsync("Ali");
            Console.WriteLine(result);
        }

        // SelamAsync tamamlanır tamamlanmaz çağırılacak bölümdür.
        private static void CallContinueSelamAsync()
        {
            Task<string> t1 = SelamAsync("Ali");
            t1.ContinueWith(t =>
            {
                string result = t.Result;

                Console.WriteLine(result);
            });
        }

        // Senkron metodumuz
        static string Selam(string name)
        {
            Thread.Sleep(1000);
            return $"Selam, {name}";

        }

        // Task<> task dönürecek async metodumuz
        static Task<string> SelamAsync(string name)
        {

            return Task.Run(() => Selam(name));
        }
    }
}

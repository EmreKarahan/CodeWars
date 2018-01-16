using System;
using System.Net;
using System.Threading.Tasks;

namespace CodeWars.AsyncWebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = GetWebStringAsync();
            Console.WriteLine(data.Result);
        }


        internal static async Task<string> GetWebStringAsync()
        {
            WebClient web = new WebClient();
            string gelen = await web.DownloadStringTaskAsync(new Uri("http://www.eksisozluk.com"));
            return gelen;
        }
    }
}

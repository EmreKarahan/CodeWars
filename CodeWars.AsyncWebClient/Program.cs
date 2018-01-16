using System;
using System.Net;
using System.Threading.Tasks;

namespace CodeWars.AsyncWebClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var data = await GetWebStringAsync();
            Console.WriteLine(data);
        }


        internal static async Task<string> GetWebStringAsync()
        {
            WebClient web = new WebClient();
            string gelen = await web.DownloadStringTaskAsync(new Uri("http://www.eksisozluk.com"));
            return gelen;
        }
    }
}

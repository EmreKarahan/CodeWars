using System;
using System.Net;
using System.Threading.Tasks;

namespace CodeWars.AsyncWebClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //construct Progress<T>, passing ReportProgress as the Action<T> 
            var progressIndicator = new Progress<ProgressInfo>(ReportProgress);
            //call async method
            await DownloadFileAsync("https://download-cf.jetbrains.com/resharper/JetBrains.Rider-2017.3.exe", progressIndicator);
        }

        private static int ProgressValue;

        static void ReportProgress(ProgressInfo progress)
        {
            //ProgressValue = value;
            Console.WriteLine($"{progress.Received} tamamlandı...");

        }



        internal static async Task Tamtam()
        {
            await Task.Run(async () =>
            {
                Console.WriteLine(await GetWebStringAsync("http://www.eksisozluk.com"));
                Console.WriteLine(await GetWebStringAsync("http://www.hurriyet.com.tr"));
            });
        }

        internal static string GetWebString(string s)
        {
            WebClient web = new WebClient();
            string gelen = web.DownloadString(new Uri("http://www.eksisozluk.com"));
            return gelen;
        }

        internal static async Task<string> GetWebStringAsync(string url)
        {
            WebClient web = new WebClient();
            string gelen = await web.DownloadStringTaskAsync(new Uri(url));
            return gelen;
        }



        public static async Task<string> DownloadFileAsync(string url, IProgress<ProgressInfo> progress)
        {
            WebClient web = new WebClient();           

            web.DownloadProgressChanged += (sender, args) =>
            {
                progress.Report(new ProgressInfo(args.ProgressPercentage, args.BytesReceived, args.TotalBytesToReceive));
            };

            string gelen = await web.DownloadStringTaskAsync(new Uri(url));


            return gelen;
        }
    }

    internal class ProgressInfo
    {
        public ProgressInfo(int progress, long received, long total)
        {
            Progress = progress;
            Received = received;
            Total = total;
        }
        public int Progress { get; set; }
        public long Received { get; set; }
        public long Total { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.TxtAsync
{
    class Program
    {

        private const int DefaultBufferSize = 4096;
        private const FileOptions DefaultOptions = FileOptions.Asynchronous | FileOptions.SequentialScan;

        static async Task Main(string[] args)
        {
            var aa = await ReadAllLinesAsync("big.txt");
            var bb = await ReadAllLinesAsync("handbook.txt");
        }




        public static async Task<string[]> ReadAllLinesAsync(string path)
        {
            return await ReadAllLinesAsync(path, Encoding.UTF8);
        }


        public static async Task<string[]> ReadAllLinesAsync(string path, Encoding encoding)
        {
            var lines = new List<string>();
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, DefaultOptions))
            using (var reader = new StreamReader(stream, encoding))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine($"P:{path} L:{line}");
                    lines.Add(line);
                }
            }
            return lines.ToArray();
        }

    }
}

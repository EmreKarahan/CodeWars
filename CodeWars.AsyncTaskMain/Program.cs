using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CodeWars.AsyncTaskMain
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "http://webapiblog.azurewebsites.net/api/products";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                var model = JsonConvert.DeserializeObject<List<Product>>(response.Content.ReadAsStringAsync().Result);
                foreach (var product in model)
                {
                    Console.WriteLine(product.Name + ":" + product.Price);
                }
                Console.ReadLine();
            }
        }
    }


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}

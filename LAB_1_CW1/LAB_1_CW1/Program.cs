using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LAB_1_CW1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //JS - Promise async await
            //Java - Future
            //Task -> async await

            Console.WriteLine("Bardzo prosty crawler...");

            var client = new HttpClient();
            var response = await client.GetAsync("https://www.pja.edu.pl");
            if (response.IsSuccessStatusCode)
            {
                string html = await response.Content.ReadAsStringAsync();
                Console.WriteLine(html);
            }

            Console.WriteLine("Strona została zhakowana !");
        }
    }
}

using System;
using System.Net.Http;
using System.Text.RegularExpressions;
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

            Console.WriteLine("Bardzo prosty crawler..."+"\n");

            var url = args.Length > 0 ? args[0] : "https://www.pja.edu.pl";
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string html = await response.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z0-9]+\\.[a-z]+",RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(html);
                foreach(var m in matches)
                {
                    Console.WriteLine(m);
                }
                
            }

            Console.WriteLine("\n"+"Strona została zhakowana !");
        }
    }
}

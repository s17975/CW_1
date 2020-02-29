using System;
using System.Net.Http;

namespace LAB_1_CW1
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Bardzo prosty crawler...");
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(args[0]);

        }
    }
}

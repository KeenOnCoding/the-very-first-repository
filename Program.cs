using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace YouTube
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"- - - - - - - - - - {++i} - - - - - - - - - -");
                Positive().GetAwaiter().GetResult();
                WillWaitForYou().GetAwaiter().GetResult();
                OldCar().GetAwaiter().GetResult();
                Light().GetAwaiter().GetResult();

                Thread.Sleep(new TimeSpan(0, 10, 0));
            }
            Console.WriteLine("----------------------DONE-------------------------------");
            Console.ReadLine();
        }

        public static async Task Positive()
        {
            var handler = new HttpClientHandler
            {
                CookieContainer = new CookieContainer(),
                UseCookies = true,
                UseDefaultCredentials = false,
                Proxy = new WebProxy("http://93.187.167.54", false),
                UseProxy = true,
            };
            HttpClient client = new HttpClient(handler)
            {
                Timeout = System.TimeSpan.FromSeconds(220)
            };
            var uri = new Uri("https://www.youtube.com/watch?v=QNlBj5exupQ");

            Console.WriteLine(await Task.Run(async () =>
            {
                var response = await client.GetAsync(uri);

                return response.StatusCode.ToString() + "   POSITIVE";
            }));
        }

        public static async Task OldCar()
        {
            HttpClient client = new HttpClient
            {
                Timeout = System.TimeSpan.FromSeconds(210)
            };
            var uri = new Uri("https://www.youtube.com/watch?v=lC1d6dnhjrI&t=48s");

            Console.WriteLine(await Task.Run(async () =>
            {
                var response = await client.GetAsync(uri);

                return response.StatusCode.ToString() + "   OLD CAR";
            }));
        }

        public static async Task WillWaitForYou()
        {
            HttpClient client = new HttpClient
            {
                Timeout = System.TimeSpan.FromSeconds(184)
            };
            var uri = new Uri("https://www.youtube.com/watch?v=Qs4r8CmbU2M");

            Console.WriteLine(await Task.Run(async () =>
            {
                var response = await client.GetAsync(uri);

                return response.StatusCode.ToString() + "   WillWaitForYou";
            }));
        }

        public static async Task Light()
        {
            HttpClient client = new HttpClient
            {
                Timeout = System.TimeSpan.FromSeconds(135)
            };
            var uri = new Uri("https://www.youtube.com/watch?v=42gbK7B1w94");

            Console.WriteLine(await Task.Run(async () =>
            {
                var response = await client.GetAsync(uri);

                return response.StatusCode.ToString() + "   LIGHT";
            }));
        }
    }
}
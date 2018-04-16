using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SuperAwesomeFancyPants.Threading.Logic;

namespace SuperAwesomeFancyPants.Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //JsonManager jsonManager = new JsonManager();
            //jsonManager.

            //Thread thread = new Thread(Start);
            //thread.Start();

            //ThreadPool.QueueUserWorkItem((o) => ScheduleThing());

            //for (int i = 0; i < 10; i++)
            //{
            //    ThreadPool.QueueUserWorkItem((o) => ScheduleThing());
            //}

            // APM
            // EAP

            // TAP
            //Task.Run(() => Start());



            Console.ReadKey();
        }

        private static async Task MainAsync()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");

            Console.WriteLine(result);
            

        }

        private static void CallBack(object state)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);

                Thread.Sleep(500);
            }
        }

        private static void Start()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);

                Thread.Sleep(500);
            }
        }

        private static void ScheduleThing()
        {
            Thread.Sleep(1000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Hi");
        }
    }
}

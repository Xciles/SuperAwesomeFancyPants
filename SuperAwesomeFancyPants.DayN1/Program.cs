using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SuperAwesomeFancyPants.DayN1
{
    public class Program
    {
        //[ThreadStatic]
        public static int _field;
        private static object _lockobject = new object();

        //public static void Main()
        //{

        //    //new Thread(() =>
        //    //{
        //    //    for (int x = 0; x < 10; x++)
        //    //    {
        //    //        //Interlocked.Increment(ref _field);
        //    //        //_field++;
        //    //        //Console.WriteLine("Thread A: {0}", _field);
        //    //        Console.WriteLine($"{DateTime.UtcNow.ToString("ss:FFFFFFF")} - Thread A: {0}", Interlocked.Increment(ref _field));
        //    //        //Thread.Sleep(10);

        //    //    }
        //    //}).Start();

        //    //new Thread(() =>
        //    //{
        //    //    for (int x = 0; x < 10; x++)
        //    //    {
        //    //        //Interlocked.Increment(ref _field);
        //    //        //_field++;
        //    //        //Console.WriteLine("Thread B: {0}", _field);
        //    //        Console.WriteLine($"{DateTime.UtcNow.ToString("ss:FFFFFFF")} - Thread A: {0}", Interlocked.Increment(ref _field));
        //    //        //Thread.Sleep(10);
        //    //        //_field++;
        //    //        //Console.WriteLine($"{DateTime.UtcNow.ToString("ss:fffffff")} - Thread B: {0}", Interlocked.Increment(ref _field));
        //    //        ////Thread.Sleep(10);
        //    //    }
        //    //}).Start();

        //    //// TaskFactory
        //    //Task.Run(() =>
        //    //{

        //    //});
        //    //Task.Factory.StartNew(() =>
        //    //{

        //    //});
        //    //var cts = new CancellationTokenSource();

        //    //var taskFactory = new TaskFactory(cts.Token);
        //    //taskFactory.StartNew(() =>
        //    //{
        //    //    Thread.Sleep(10_000);
        //    //    Console.WriteLine("Hello");
        //    //});
        //    //taskFactory.StartNew(() =>
        //    //{
        //    //    Thread.Sleep(10_000);
        //    //    Console.WriteLine("Hello");
        //    //});
        //    //taskFactory.StartNew(() =>
        //    //{
        //    //    Thread.Sleep(10_000);
        //    //    Console.WriteLine("Hello");
        //    //});

        //    //cts.Cancel();
        //    //Task.Factory.
        //    //var cts = new CancellationTokenSource();
        //    //var fact = new TaskFactory(cts.Token);
        //    //fact.StartNew(() => { Thread.Sleep(1_0000); });

        //    //cts.Cancel();

        //    var list = new List<string>()
        //    {
        //        "Hi",
        //        "Hello",
        //        "LIWUht"
        //    };//.AsEnumerable();

        //    var item = list.First();
        //    foreach (var s in list)
        //    {
        //        Console.WriteLine(s);
        //    }
        //    //foreach (var s in list)
        //    //{
        //    //    Console.WriteLine(s);
        //    //}

        //    foreach (var s in Thats())
        //    {

        //    }

        //    Console.ReadKey(true);
        //}

        //private static IEnumerable<string> Thats()
        //{
        //    yield return "Hallo";
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("i");
        //    }

        //    yield return "Hallo";

        //    yield return "Hallo";
        //    yield return "Hallo";
        //    yield return "Hallo";
        //    yield return "Hallo";
        //    yield return "Hallo";
        //}



        public struct MyStruct
        {
            public int Number { get; set; }   
        }


        public static void Main()
        { 
            MyStruct myStruct = new MyStruct(){ Number = 10};
            int _number = 10;

            Console.WriteLine(_number);

            //OtherMethod(ref _number, ref myStruct);
            OtherMethod(_number, myStruct);

            Console.WriteLine(_number);

            Console.ReadKey();
        }

        //private static void OtherMethod(ref int number, ref MyStruct myStruct)
        private static void OtherMethod(int number, MyStruct myStruct)
        {
            number = 20;
            myStruct.Number = 20;
            //OtherMethod(ref number, ref myStruct);
        }
    }

    //public class Program
    //{
    //[ThreadStatic]
    //public static int _field;

    //public static void Main()
    //{
    //    new Thread(() =>
    //    {
    //        for (int x = 0; x < 10; x++)
    //        {
    //            _field++;
    //            Console.WriteLine($"{DateTime.UtcNow:ss.fffff} Thread A: {_field}", _field);
    //            Thread.Sleep(10);
    //        }
    //    }).Start();

    //    new Thread(() =>
    //    {
    //        for (int x = 0; x < 10; x++)
    //        {
    //            _field++;
    //            Console.WriteLine($"{DateTime.UtcNow:ss.fffff} Thread B: {_field}", _field);
    //            Thread.Sleep(10);
    //        }
    //    }).Start();

    //    Console.ReadKey(true);
    //}

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Hello World!");



    //    Console.ReadKey();
    //}
    //}
}

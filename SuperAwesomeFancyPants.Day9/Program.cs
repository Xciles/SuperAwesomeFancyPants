using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace SuperAwesomeFancyPants.Day9
{
    public class MyClass
    {
        public int MyInt { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            Nullable<int> nI = null;
            nI = 128746286;

            int? i = 1233;

            int x = 10, y = 15;

            var temp = Add(x, y);
            var myClass = new MyClass() { MyInt = 10 };
            Add(myClass, 15);

            Console.WriteLine("Hello World!");
            Console.WriteLine($"x: {x}, temp: {temp}");
            Console.WriteLine($"myClass.MyInt: {myClass.MyInt}");

            int a = 10, b = 15;
            AddByRef(ref a, b);
            Console.WriteLine($"a: {a}");

            var str = "Hello, this will be written to Disk";
            byte[] strAsBytes = Encoding.UTF8.GetBytes(str);

            using (var fileStream = File.Create("Text.txt"))
            {
                fileStream.Write(strAsBytes, 0, strAsBytes.Length);
                fileStream.Flush();
            }

            var list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 12, 13};

            foreach (var i1 in list)
            {
                Console.WriteLine(i1);
            }

            Timer timer = new Timer(state =>
            {
                Console.WriteLine("It triggered again!");

            }, null, 1_000, 1_000);

            Timer timerOnce = new Timer(state =>
            {
                Console.WriteLine("It triggered Just the once!");

            }, null, 1_000, -1);

            Console.ReadKey();
        }

        private static void CheckInt(int? i)
        {
            if (!i.HasValue)
            {
            }
            else
            {
                Console.WriteLine(i.Value);
            }
        }

        private static int Add(int x, int y)
        {
            return x += y;
        }

        private static void AddByRef(ref int a, int b)
        {
            a += b;
        }

        private static void Add(MyClass myClass, int y)
        {
            myClass.MyInt += y;
        }
    }
}

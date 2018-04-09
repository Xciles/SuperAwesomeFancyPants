using System;
using System.Collections;
using System.Collections.Generic;

namespace SuperAwesomeFancyPants.Generics
{
    public class Program
    {
        // yield
        public static void Consumer()
        {
            foreach (int i in Integers())
            {
                Console.WriteLine(i.ToString());
            }
        }

        public static IEnumerable<int> Integers()
        {
            yield return 1;
            yield return 2;
            yield return 4;
            yield return 8;
            yield return 16;
            yield return 16777216;
        }

















        //private static int Sum(int x, int y)
        //{
        //    return x + y;
        //}
        //private static long Sum(long x, long y)
        //{
        //    return x + y;
        //}
        //private static float Sum(float x, float y)
        //{
        //    return x + y;
        //}

        //private static T Sum<T>(T x, T y) 
        //where T : new
        //{
        //    return x + y;
        //}

        public static void Main(string[] args)
        {
            //    Consumer();

            //    Console.WriteLine("Hello World!");

            //    Queue queue = new Queue();
            //    queue.Enqueue("string 1");
            //    queue.Enqueue("string 2");
            //    queue.Enqueue("string 3");

            //    var s = queue.Dequeue();
            //    Console.WriteLine(s);
            //    s = queue.Dequeue();
            //    queue.Enqueue("string 4");
            //    Console.WriteLine(s);
            //    s = queue.Dequeue();
            //    Console.WriteLine(s);
            //    s = queue.Dequeue();

            //    Console.WriteLine(s);

            //    Console.ReadKey();
            //    //FiFo
            //    Stack stack = new Stack();
            //    stack.Push("string 1");
            //    stack.Push("string 2");
            //    stack.Push("string 3");

            //    s = stack.Pop();
            //    Console.WriteLine(s);
            //    s = stack.Pop();
            //    stack.Push("string 4");
            //    Console.WriteLine(s);
            //    s = stack.Pop();
            //    Console.WriteLine(s);
            //    s = stack.Pop();
            //    Console.WriteLine(s);
            //    //FiLo


            //    //var result = Sum(1, 2);

            //    //string[] stringList = new string[];
            //    //ArrayList list = new ArrayList();
            //    //list.Add(1);
            //    //list.Add("string");
            //    //list.Add(11313.1414);
            //    //list.Add(new SomeTupe());

            //    //List<SomeTupe>
            //    IList<SomeTupe> list= new List<SomeTupe>();


            //    foreach (var someTupe in list)
            //    {

            //    }

            //    IDictionary<string, int> dict = new Dictionary<string, int>();
            //    dict.Add("one", 1);
            //    dict.Add("two", 2);
            //    dict.Add("three", 3);

            //    int value = dict["one"];

            //    int i = 1;
            //    object o = i;
            //    i = (int)o;

            GenericList<SomeTupe> genList = new GenericList<SomeTupe>();
            genList.AddNode(new SomeTupe());
            genList.AddNode(new SomeTupe());
            genList.AddNode(new SomeTupe());
            genList.AddNode(new SomeTupe());

            foreach (var v in genList)
            {
                Console.WriteLine(v);
            }

            Console.ReadKey();
        }
    }

    public class SomeTupe
    {

    }
}

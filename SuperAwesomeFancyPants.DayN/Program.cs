using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace SuperAwesomeFancyPants.DayN
{

    //class Program
    //{
    //    public static void Main(string[] a)
    //    {
    //        var ms = new MemoryStream();

    //        Console.WriteLine(ms.ToString());


    //        IEnumerable<string> list = new List<string>();

    //        list.ToList().ForEach(s =>
    //        {

    //        });

    //        foreach (var s in list)
    //        {
                
    //        }

    //        Console.ReadKey();
    //    }
    //}

    //class Program
    //{
    //    public delegate void Del(string message);

    //    public delegate string Combine(string s1, string s2);

    //    // Create a method for a delegate.
    //    public static void DelegateMethod(string message)
    //    {
    //        System.Console.WriteLine(message);
    //    }

    //    public static void Main(string[] args)
    //    {
    //        Del someName = message => Console.WriteLine($"Other message {message}");
    //        Del someName1 = delegate(string message) { Console.WriteLine("w/e"); };
    //        Del someName2 = SomeName2;

    //        Combine combine1 = delegate(string s1, string s2) { return s1 + s2; };
    //        Combine combine2 = (s1, s2) => { return s1 + s2; };
    //        Combine combine3 = Combine3;

    //        someName("weiuthwiltuh");

    //        // Instantiate the delegate.
    //        Del handler = DelegateMethod;

    //        // Call the delegate.
    //        handler("Hello World");
    //        handler("SOmething else");

    //        MethodWithCallback(1, 2, handler);

    //        Console.ReadKey();
    //    }

    //    private static string Combine3(string s1, string s)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    private static void SomeName2(string s)
    //    {
            
    //    }

    //    public static void MethodWithCallback(int param1, int param2, Del callback)
    //    {
    //        callback("The number is: " + (param1 + param2).ToString());
    //    }
    //}

    //class Program
    //{
    //    delegate void PointToAdd(int numberOne, int numberTwo);

    //    static void Main(string[] args)
    //    {
    //        PointToAdd pointToAdd = AddTwoNumber;

    //        pointToAdd.Invoke(10, 20);

    //        Console.Read();
    //    }
    //    static void AddTwoNumber(int numberOne, int numberTwo)
    //    {
    //        Console.WriteLine((numberOne + numberTwo).ToString());
    //    }
    //}

    //class Program
    //{
    //    static FileStream fs;
    //    static StreamWriter sw;

    //    // delegate declaration
    //    public delegate void PrintString(string s);

    //    // this method prints to the console
    //    public static void WriteToScreen(string str)
    //    {
    //        Console.WriteLine("The String is: {0}", str);
    //    }

    //    //this method prints to a file
    //    public static void WriteToFile(string s)
    //    {
    //        fs = new FileStream("c:\\message.txt", FileMode.Append, FileAccess.Write);
    //        sw = new StreamWriter(fs);
    //        sw.WriteLine(s);
    //        sw.Flush();
    //        sw.Close();
    //        fs.Close();
    //    }

    //    // this method takes the delegate as parameter and uses it to
    //    // call the methods as required
    //    public static void SendString(PrintString ps)
    //    {
    //        ps("Hello World");
    //    }

    //    static void Main(string[] args)
    //    {
    //        PrintString ps1 = new PrintString(WriteToScreen);
    //        PrintString ps2 = new PrintString(WriteToFile);
    //        SendString(ps1);
    //        SendString(ps2);
    //        Console.ReadKey();
    //    }
    //}

    //class TestDelegate
    //{
    //    delegate int NumberChanger(int n);

    //    static int num = 10;

    //    public static int AddNum(int p)
    //    {
    //        num += p;
    //        return num;
    //    }
    //    public static int MultNum(int q)
    //    {
    //        num *= q;
    //        return num;
    //    }
    //    public static int getNum()
    //    {
    //        return num;
    //    }
    //    static void Main(string[] args)
    //    {
    //        //create delegate instances
    //        NumberChanger nc;
    //        NumberChanger nc1 = AddNum;
    //        NumberChanger nc2 = MultNum;
    //        NumberChanger nc3 = AddNum;
    //        NumberChanger nc4 = MultNum;
    //        NumberChanger nc5 = AddNum;

    //        nc = nc1;
    //        nc += nc2;
    //        nc += nc3;
    //        nc += MultNum;
    //        nc += nc5;

    //        nc += nc3;

    //        //calling multicast
    //        nc(5);
    //        Console.WriteLine("Value of Num: {0}", getNum());
    //        Console.ReadKey();
    //    }
    //}

    //// Hiero
    //public class Math
    //{
    //    public delegate void PointToMathsOperation(int numberOne, int numberTwo);
    //    private PointToMathsOperation _pointToMathsOperation = null;

    //    public PointToMathsOperation Operation(string operationName)
    //    {

    //        switch (operationName)
    //        {
    //            case "Add":
    //                _pointToMathsOperation = Add;
    //                return _pointToMathsOperation;
    //            case "Sub":
    //                _pointToMathsOperation = Sub;
    //                return _pointToMathsOperation;
    //            case "Div":
    //                _pointToMathsOperation = Mul;
    //                return _pointToMathsOperation;
    //            case "Mul":
    //                _pointToMathsOperation = Div;
    //                return _pointToMathsOperation;
    //        }
    //        return _pointToMathsOperation;
    //    }

    //    private void Add(int numberOne, int numberTwo)
    //    {
    //        Console.WriteLine((numberOne + numberTwo).ToString());
    //    }

    //    private void Sub(int numberOne, int numberTwo)
    //    {
    //        Console.WriteLine((numberOne - numberTwo).ToString());
    //    }

    //    private void Div(int numberOne, int numberTwo)
    //    {
    //        Console.WriteLine((numberOne / numberTwo).ToString());
    //    }

    //    private void Mul(int numberOne, int numberTwo)
    //    {
    //        Console.WriteLine((numberOne * numberTwo).ToString());
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Please enter two numbers:-");

    //        var numberOneString = Console.ReadLine();
    //        var numberTwoString = Console.ReadLine();

    //        Console.WriteLine("Please enter operation to perform like add,mul,sub and div :-");

    //        var choice = Console.ReadLine();
    //        int numberOne, numberTwo;

    //        Math math = new Math();

    //        int.TryParse(numberOneString, out numberOne);
    //        int.TryParse(numberTwoString, out numberTwo);

    //        math.Operation(choice).Invoke(numberOne, numberTwo);

    //        Console.ReadLine();
    //    }
    //}

    //public class SomeClass
    //{
    //    public string SOmeString { get; set; }
    //    public int SOmeInto { get; set; }
    //}

    class Program
    {
        //public static Action<SomeClass> NotifyUpdatedBl;

        //public delegate void NotifyDelegate(SomeClass mySomeClass);
        //public static event NotifyDelegate NotifyUpdated;

        public static void Main()
        {
            //Timer timer = new Timer(state =>
            //{

            //}, null, 100, 100);

            //NotifyUpdatedBl += param => { Console.WriteLine(param.SOmeInto + param.SOmeString); };
            //NotifyUpdatedBl += param => { Console.WriteLine("Bla: " + param.SOmeInto + param.SOmeString); };


            //NotifyUpdatedBl.Invoke(new SomeClass());

            //NotifyUpdated += my => { }


            Adder a = new Adder();
            a.OnMultipleOfFiveReached += a_MultipleOfFiveReached;

            int iAnswer = a.Add(4, 3);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            iAnswer = a.Add(4, 6);
            Console.WriteLine("iAnswer = {0}", iAnswer);

            Console.ReadKey();
        }

        static void a_MultipleOfFiveReached(string message)
        {
            Console.WriteLine("Multiple of five reached!");
        }
    }

    public class Adder
    {
        public delegate void DgEventRaiser(string message);
        public event DgEventRaiser OnMultipleOfFiveReached;

        public int Add(int x, int y)
        {
            int iSum = x + y;
            if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))
            {
                OnMultipleOfFiveReached("Multiple of five");
            }
            return iSum;
        }
    }
}

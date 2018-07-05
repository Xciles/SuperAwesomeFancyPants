using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

namespace SuperAwesomeFancyPants.DayN1
{
    /// <summary>
    /// Events and Delegates
    /// THreading
    ///
    /// BlockingCollection
    /// Dispose
    /// </summary>
    public class Program5
    {
        public static void Main(string[] args)
        {
            var file = File.Create("path.json");

            file.Dispose();

            using (var fileStream = File.Create("different.json"))
            {

            }


            BlockingCollection<string> strings = new BlockingCollection<string>();
            strings.Add("1");
            strings.Add("2");
            strings.Add("3");
            strings.Add("4");

            Task.Run(() =>
            {
                Thread.Sleep(1_000);
                strings.Add("new thing");
            });

            foreach (var s in strings.GetConsumingEnumerable())
            {
                Console.WriteLine(s);
            }
        }
        //public static void Main(string[] args)
        //{
        //    // Concurrent

        //    // BlockingCollection<>
        //    // Disposable

        //    BlockingCollection<string> strings = new BlockingCollection<string>();
        //    strings.Add("1");
        //    strings.Add("2");
        //    strings.Add("3");
        //    strings.Add("4");

        //    Task.Run(() =>
        //    {
        //        Thread.Sleep(1_000);
        //        strings.Add("new thing");
        //    });

        //    foreach (var s in strings.GetConsumingEnumerable())
        //    {
        //        Console.WriteLine(s);
        //    }
        //}

        //private static void Process()
        //{

        //}

        //private static void ParameterProcess(object obj)
        //{

        //}

        //public static void Main(string[] args)
        //{
        //    int numberOfIterations = 10;

        //    var thread = new Thread(ParameterProcess);
        //    thread.Start(numberOfIterations);
        //}
        
        //// https://www.akadia.com/services/dotnet_delegates_and_events.html
        //// Delegate Specification
        //public class MyClass
        //{
        //    // Declare a delegate that takes a single string parameter
        //    // and has no return type.
        //    public delegate void LogHandler(string message);

        //    // The use of the delegate is just like calling a function directly,
        //    // though we need to add a check to see if the delegate is null
        //    // (that is, not pointing to a function) before calling the function.
        //    public void Process(LogHandler logHandler)
        //    {
        //        if (logHandler != null)
        //        {
        //            logHandler("Process() begin");
        //        }

        //        if (logHandler != null)
        //        {
        //            logHandler("Process() end");
        //        }
        //    }
        //}

        //// The FileLogger class merely encapsulates the file I/O
        //public class FileLogger
        //{
        //    FileStream fileStream;
        //    StreamWriter streamWriter;

        //    // Constructor
        //    public FileLogger(string filename)
        //    {
        //        fileStream = new FileStream(filename, FileMode.Create);
        //        streamWriter = new StreamWriter(fileStream);
        //    }

        //    // Member Function which is used in the Delegate
        //    public void Logger(string s)
        //    {
        //        streamWriter.WriteLine(s);
        //    }

        //    public void Close()
        //    {
        //        streamWriter.Close();
        //        fileStream.Close();
        //    }
        //}

        //// Test Application which calls both Delegates
        //public class TestApplication
        //{
        //    // Static Function which is used in the Delegate
        //    static void Logger(string s)
        //    {
        //        Console.WriteLine(s);
        //    }

        //    static void Main(string[] args)
        //    {
        //        FileLogger fl = new FileLogger("process.log");

        //        MyClass myClass = new MyClass();

        //        // Crate an instance of the delegates, pointing to the static
        //        // Logger() function defined in the TestApplication class and
        //        // then to member function on the fl instance of a FileLogger.
        //        MyClass.LogHandler myLogger = null;
        //        myLogger += new MyClass.LogHandler(Logger);
        //        myLogger += new MyClass.LogHandler(fl.Logger);

        //        myClass.Process(myLogger);
        //        fl.Close();

        //        Console.ReadKey();
        //    }
        //}


        //public delegate void LogHandler(string message);

        //public static void Hello(string message)
        //{
        //    Console.WriteLine($"Hello: {message}");
        //}

        //public static void Goodbye(string message)
        //{
        //    Console.WriteLine($"Goodbye: {message}");
        //}

        //public static void Main()
        //{
        //    LogHandler hello = Hello;
        //    LogHandler goodbye = Goodbye;

        //    LogHandler helloGoodbye = Hello;
        //    helloGoodbye += Goodbye;

        //    Console.WriteLine("hello:");
        //    hello("you all!");
        //    Console.WriteLine("goodbye:");
        //    goodbye("you all!");
        //    Console.WriteLine("both:");
        //    helloGoodbye("cruel world!");

        //    Console.ReadKey();
        //}

        //public delegate void LogHandler(string message);

        //public static void ProcessLog(string message)
        //{
        //    Console.WriteLine(message);
        //}

        //public static void Main()
        //{
        //    var del = new LogHandler(ProcessLog);

        //    del("some kind of message");

        //    ExampleMethod(del);
        //}

        //private static void ExampleMethod(LogHandler del)
        //{
        //    del("");
        //}


        //public delegate void SimpleDelegateExample();

        //public static void WriteToConsole()
        //{
        //    Console.WriteLine("This will be called via the delegate.");
        //}

        //public static void Main()
        //{
        //    SimpleDelegateExample del = new SimpleDelegateExample(WriteToConsole);

        //    del();
        //    del.Invoke();

        //    SecondMethod(del);

        //    Console.ReadKey();
        //}

        //private static void SecondMethod(SimpleDelegateExample del)
        //{
        //    del.Invoke();
        //}
    }
}

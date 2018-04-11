using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperAwesomeFancyPants.Day7
{
    public class MyType
    {
        public string MyField { get; set; }
        public int MyInt { get; set; }
        public string MyField2 { get; set; }
        public int MyInt2 { get; set; }
    }
    public class SubMyType
    {
        public string MyField { get; set; }
        public string MyField2 { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var list = new List<MyType>();
            list.Add(new MyType { MyField = "field 1", MyInt = 1 });
            list.Add(new MyType { MyField = "field 2", MyInt = 11 });
            list.Add(new MyType { MyField = "field 23", MyInt = 13 });
            list.Add(new MyType { MyField = "field 24", MyInt = 154 });
            list.Add(new MyType { MyField = "field 25", MyInt = 168 });

            var result = GetMyType(list);

            var sumResult = list.Sum(myType => myType.MyInt);

            IList<MyType> listResult = list.Where(myType => myType.MyInt >= 11 && myType.MyInt <= 13).ToList();

            var anReuslt = list.Where(myType => myType.MyInt >= 11 && myType.MyInt <= 13)
                                .Select(type => new { MyField = type.MyField, MyField2 = type.MyField2 });
            foreach (var name in anReuslt)
            {
                
            }

            var sReuslt = list.Where(myType => myType.MyInt >= 11 && myType.MyInt <= 13)
                                .Select(type => new SubMyType { MyField = type.MyField, MyField2 = type.MyField2 });
            foreach (var name in sReuslt)
            {
                
            }
        }

        private static MyType GetMyType(IList<MyType> list)
        {
            return list.Where(myType => myType.MyInt == 11).FirstOrDefault();

            foreach (var myType in list)
            {
                if (myType.MyInt == 11)
                {
                    return myType;
                }
            }

            return null;
        }
    }
}

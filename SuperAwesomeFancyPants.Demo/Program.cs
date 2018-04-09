using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SuperAwesomeFancyPants.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Task.Run(() => { var test = new Test(); });
            

            Console.ReadKey();
        }
    }

    public class Test
    {
        public Test()
        {
            Bla();
            Bla();
            Bla();
            Bla();
            Bla();
            Bla();
            Blo();
            Bli();
        }

        private bool _blaaa = false;

        public async Task Bla()
        {
            if (_blaaa) return;
            _blaaa = true;
            Console.WriteLine("Bla Start");
            await Task.Delay(10000);
            Console.WriteLine("Bla Stop");
            _blaaa = false;
        }

        public async void Blo()
        {
            Console.WriteLine("Blo Start");
            await Task.Delay(10000);
            Console.WriteLine("Blo Stop");
        }

        public void Bli()
        {
            Console.WriteLine("Bli Start");
            Console.WriteLine("Bli Stop");
        }
    }
}

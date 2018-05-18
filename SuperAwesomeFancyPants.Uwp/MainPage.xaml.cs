using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SuperAwesomeFancyPants.Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            //RunSomething();
            //RunSomething();
            //RunSomething();
            //RunSomething();
            //RunSomething();
            this.InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ListView.Items.Add("ButtonBase_OnClick");

            Task.Delay(5000).Wait();

            ListView.Items.Add("ButtonBase_OnClick end");
        }

        private async void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            ListView.Items.Add("ButtonBase2_OnClick");

            await Task.Delay(5000);

            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");

            ListView.Items.Add("ButtonBase2_OnClick end");
        }

        private void ButtonBase3_OnClick(object sender, RoutedEventArgs e)
        {
            ListView.Items.Add("ButtonBase3_OnClick");

            Object o;
            object b;

            String ss;
            string sss;
            String.IsNullOrWhiteSpace("assdgkuywegts");

            Int32 i;
            int ii;
            long l;


            Task.Run(() =>
            {
                RunSomething();
            });

            var a = new ConcurrentBag<string>();
            a.Add("s");

            var dict = new Dictionary<int, string>();
            dict[0] = "some string";

            var cDict = new ConcurrentDictionary<int, string>();

            SemaphoreSlim semSlim = new SemaphoreSlim(0, 1);
            Semaphore sem = new Semaphore(0, 1);
            AutoResetEvent are = new AutoResetEvent(false);

            are.WaitOne();
            are.Set();


            CountdownEvent cde = new CountdownEvent(10);

            cde.Wait();

            cde.Signal();


            ManualResetEvent mre = new ManualResetEvent(false);

            mre.WaitOne();

            mre.Set();


            sem.WaitOne();

            try
            {
                //throw new WhateverException();
            }
            catch (Exception exception)
            {
                throw exception.InnerException;
            }


            sem.Release();

            var list = new List<string>
            {
                "a", "B","a", "B","a", "B","a", "B","a", "B","a", "B","a", "B"
            };

            list.AsParallel().AsOrdered();

            foreach (string c in list)
            {
            }

            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 100
            };
            Parallel.ForEach(list, options, (inputString) =>
            {
                lock (list)
                {
                    list.Add("a");
                }
            });


            foreach (var s in list)
            {

            }

            ListView.Items.Add("ButtonBase3_OnClick end");
        }

        private async void RunSomething()
        {
            await Task.Delay(10000);

            ListView.Items.Add("RunSomething end");
        }
    }
}

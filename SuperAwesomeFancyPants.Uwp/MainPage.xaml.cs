using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            RunSomething();
            RunSomething();
            RunSomething();
            RunSomething();
            RunSomething();
            this.InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ListView.Items.Add("ButtonBase_OnClick");

            Task.Delay(1000).Wait();

            ListView.Items.Add("ButtonBase_OnClick end");
        }

        private async void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            ListView.Items.Add("ButtonBase2_OnClick");

            await Task.Delay(1000);

            ListView.Items.Add("ButtonBase2_OnClick end");
        }

        private void ButtonBase3_OnClick(object sender, RoutedEventArgs e)
        {
            ListView.Items.Add("ButtonBase3_OnClick");

            RunSomething();

            ListView.Items.Add("ButtonBase3_OnClick end");
        }

        private async void RunSomething()
        {
            await Task.Delay(10000);

            ListView.Items.Add("RunSomething end");
        }
    }
}

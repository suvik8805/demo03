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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace teht02_laskuri
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private double luku;
        private double markka;
        private double euro;

         private void syote_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {
            double.TryParse(number.Text, out luku);

        } private void markkabuttin_Click(object sender, RoutedEventArgs e)
        {
            
            markka = luku * 5.94573;
            string value = markka.ToString("0.00");
            markka = int.Parse(tulos.Text);
            
        }

        private void eurobutton_Click(object sender, RoutedEventArgs e)
        {
            euro = luku / 5.94573;
            string value = euro.ToString("0.00");
            euro = int.Parse(tulos.Text);
            
        }

        private void markkabutton_ContextCanceled(UIElement sender, RoutedEventArgs args)
        {

        }

        private void syote_ContextRequested(UIElement sender, ContextRequestedEventArgs args)
        {

        }
    }
}

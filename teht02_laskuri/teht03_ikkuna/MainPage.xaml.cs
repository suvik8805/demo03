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

namespace teht03_ikkuna
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
        // i = ikkuna, l = lasi
        private double ileveys;
        private double ikorkeus;
        private double kleveys;
        private double piiri;
        private double iala;
        private double lala;


        private void laskuButton_Click(object sender, RoutedEventArgs e)
        {
            iala = (ileveys * ikorkeus;
            lala = (ileveys - (2 * kleveys)) * (ikorkeus - (2 * kleveys));
            piiri = (2 * ileveys) + (2 * ikorkeus);
            iala = double.Parse(ikkunaTextBlock.Text);
            lala = double.Parse(lasiTextBlock.Text);
            piiri = double.Parse(karmiTextBlock2.Text);
        }
    }
}

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

namespace lotteryapp
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

            bool numbers = true;
            int rows;
            int i, j;
            


        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            Lottery lottery = new Lottery();
            if (!int.TryParse(RowsTextbox.Text, out rows))
            {
                numbers = false;
            }

            ResultBlock.Text = "Random numbers:";
            //Kaikkien lottorivien arvonta
            for (j = 0; j < rows; j++)
            {

                // Yhden lottorivin arvonta
                for (i = 0; i < 7; i++)
                {
                    lottery.Draw();
                    ResultBlock.Text = "Row: " + list.Count;
                }
            }
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
            rows = 0;
            ResultBlock.Text = " ";


        }
    }



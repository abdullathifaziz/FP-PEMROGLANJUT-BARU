using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FP_PEMROGLANJUT.View
{
    /// <summary>
    /// Interaction logic for PilihPaketDataPage.xaml
    /// </summary>
    public partial class PilihPaketDataPage : Page
    {
        public PilihPaketDataPage()
        {
            InitializeComponent();
        }

        private void menuPaketData1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NoTelpPaketPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PaketDataPage paketDataPage = new PaketDataPage();
            NavigationService.Navigate(paketDataPage);
        }

        private void menuPaketData2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NoTelpPaketPage());
        }

        private void menuPaketData3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NoTelpPaketPage());
        }

        private void menuPaketData5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NoTelpPaketPage());
        }

        private void menuPaketData4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NoTelpPaketPage());
        }

        private void menuPaketData6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NoTelpPaketPage());
        }

        private void menuPaketData7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NoTelpPaketPage());
        }

        private void menuPaketData8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NoTelpPaketPage());
        }
    }
}

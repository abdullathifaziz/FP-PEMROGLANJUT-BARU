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
            NoTelpPembeliPage noTelpPembeliPage = new NoTelpPembeliPage();
            NavigationService.Navigate(noTelpPembeliPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PaketDataPage paketDataPage = new PaketDataPage();
            NavigationService.Navigate(paketDataPage);
        }
    }
}

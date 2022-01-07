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
    /// Interaction logic for IsiUlangPage.xaml
    /// </summary>
    public partial class IsiUlangPage : Page
    {
        public IsiUlangPage()
        {
            InitializeComponent();
        }

        private void menuPulsa_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PulsaPage());

            PembayaranPage.layanan = "Pulsa";
        }

        private void menuPaketData_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PaketDataPage paketDataPage = new PaketDataPage();
            NavigationService.Navigate(paketDataPage);
        }

        private void menuPascabayar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PascabayarPage pascabayarPage = new PascabayarPage();
            NavigationService.Navigate(pascabayarPage);
        }

        private void menuEWallet_MouseDown(object sender, MouseButtonEventArgs e)
        {
            EWalletPage eWalletPage = new EWalletPage();
            NavigationService.Navigate(eWalletPage);
        }
    }
}

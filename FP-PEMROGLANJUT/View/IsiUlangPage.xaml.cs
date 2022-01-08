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
            PembayaranPage.layanan = "Pulsa";
            NavigationService.Navigate(new PulsaPage());
        }

        private void menuPaketData_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PembayaranPage.layanan = "Paket Data";
            NavigationService.Navigate(new PaketDataPage());
        }

        private void menuPascabayar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PembayaranPage.icon = "pascabayar.png";
            PembayaranPage.layanan = "Pascabayar";
            NavigationService.Navigate(new PascabayarPage());
        }

        private void menuEWallet_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PembayaranPage.layanan = "E-Wallet";
            NavigationService.Navigate(new EWalletPage());
        }
    }
}

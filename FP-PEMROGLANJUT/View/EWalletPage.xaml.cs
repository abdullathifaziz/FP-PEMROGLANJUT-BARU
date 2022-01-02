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
    /// Interaction logic for EWalletPage.xaml
    /// </summary>
    public partial class EWalletPage : Page
    {
        public EWalletPage()
        {
            InitializeComponent();
        }

        private void menuDana_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NoEWalletPage noEWalletPage = new NoEWalletPage();
            NavigationService.Navigate(noEWalletPage);
        }

        private void menuShopeePay_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NoEWalletPage noEWalletPage = new NoEWalletPage();
            NavigationService.Navigate(noEWalletPage);
        }
        private void menuLinkAja_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NoEWalletPage noEWalletPage = new NoEWalletPage();
            NavigationService.Navigate(noEWalletPage);
        }
        private void menuGopay_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NoEWalletPage noEWalletPage = new NoEWalletPage();
            NavigationService.Navigate(noEWalletPage);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IsiUlangPage isiUlangPage = new IsiUlangPage();
            NavigationService.Navigate(isiUlangPage);
        }
    }
}

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
    /// Interaction logic for NominalVoucherPage.xaml
    /// </summary>
    public partial class NominalVoucherPage : Page
    {
        public NominalVoucherPage()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new VoucherPage());
        }

        private void manu5000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void manu10000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void manu20000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void manu50000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void manu100000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void manu150000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void manu300000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void manu500000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }
    }
}

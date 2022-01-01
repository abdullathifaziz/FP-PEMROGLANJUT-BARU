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
    /// Interaction logic for VoucherPage.xaml
    /// </summary>
    public partial class VoucherPage : Page
    {
        public VoucherPage()
        {
            InitializeComponent();
        }
        private void menuIndomaret_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
        }
        private void menuAlfamart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
        }
        private void menuOyo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
        }
        private void menuRedDoorz_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
        }
        private void menuCarrefour_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
        }
        private void menuGramedia_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
        }
        private void menuK24Klik_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
        }
        private void menuTiket_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
        }
    }
}

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
    /// Interaction logic for NoTelpPaketPage.xaml
    /// </summary>
    public partial class NoTelpPaketPage : Page
    {
        public NoTelpPaketPage()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PilihPaketDataPage());
        }

        private void btnSelanjutnya_Click(object sender, RoutedEventArgs e)
        {
            PembayaranPage.nomor = txtNoTelpPaket.Text.ToString();
            NavigationService.Navigate(new PembayaranPage());
        }
    }
}

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
    /// Interaction logic for RiwayatPage.xaml
    /// </summary>
    /// 

    public partial class RiwayatPage : Page
    {
        Controller.TransaksiController transaksi;
        public RiwayatPage()
        {
            InitializeComponent();

            transaksi = new Controller.TransaksiController(this);

            transaksi.DataRiwayat();
        }

        private void txtCari_TextChanged(object sender, TextChangedEventArgs e)
        {
            transaksi.DataRiwayat();
        }

        private void btnCari_Click(object sender, RoutedEventArgs e)
        {
            transaksi.DataRiwayat();
        }

        private void dgTransaksi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

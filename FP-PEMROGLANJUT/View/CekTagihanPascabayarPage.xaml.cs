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
    /// Interaction logic for CekTagihanPascabayarPage.xaml
    /// </summary>
    public partial class CekTagihanPascabayarPage : Page
    {
        Controller.TagihanController tagihan;

        private string no_pelanggan;
        private string periode_pelanggan;
        private string total_bayar;

        public CekTagihanPascabayarPage(string nomor)
        {
            InitializeComponent();
            tagihan = new Controller.TagihanController(this);
            Model.TagihanModel modeltagihan = new Model.TagihanModel();

            no_pelanggan = nomor;
            periode_pelanggan = modeltagihan.Periode(nomor);
            total_bayar = "Rp. " + modeltagihan.TotalTagihan(nomor);

            lblNomorKartu.Content = no_pelanggan;
            lblPeriodeKartu.Content = periode_pelanggan;
            lblTotalKartu.Content = total_bayar;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PascabayarPage pascabayarPage = new PascabayarPage();
            NavigationService.Navigate(pascabayarPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            View.PembayaranPage.nominal = "Kartu";
            View.PembayaranPage.nomor = no_pelanggan;

            PembayaranPage pembayaranPage = new PembayaranPage();
            NavigationService.Navigate(pembayaranPage);
        }
    }
}

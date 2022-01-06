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
    /// Interaction logic for CekTagihanAirPDAMPage.xaml
    /// </summary>
    public partial class CekTagihanAirPDAMPage : Page
    {
        Controller.TagihanController tagihan;
        public CekTagihanAirPDAMPage(string nomor, string wilayah)
        {
            InitializeComponent();
            tagihan = new Controller.TagihanController(this);

            Model.TagihanModel modeltagihan = new Model.TagihanModel();

            lblWilayah.Content = wilayah;
            lblNomorPelanggan.Content = nomor;
            lblPeriode.Content = modeltagihan.Periode(nomor);
            lblTagihan.Content = "Rp. " + modeltagihan.TotalTagihan(nomor);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new AirPDAMPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }
    }
}

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
            PembayaranPage.layanan = "Voucher";
            PembayaranPage.nominal = "Indomaret";
            PembayaranPage.nomor = "";
            PembayaranPage.icon = "indomaret.png";
        }
        private void menuAlfamart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
            PembayaranPage.layanan = "Voucher";
            PembayaranPage.nominal = "Alfamart";
            PembayaranPage.nomor = "";
            PembayaranPage.icon = "alfamart.png";
        }
        private void menuOyo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
            PembayaranPage.layanan = "Voucher";
            PembayaranPage.nominal = "OYO";
            PembayaranPage.nomor = "";
            PembayaranPage.icon = "oyo.png";
        }
        private void menuRedDoorz_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
            PembayaranPage.layanan = "Voucher";
            PembayaranPage.nominal = "RedDoorz";
            PembayaranPage.nomor = "";
            PembayaranPage.icon = "reddoorz.png";
        }
        private void menuCarrefour_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
            PembayaranPage.layanan = "Voucher";
            PembayaranPage.nominal = "Carrefour";
            PembayaranPage.nomor = "";
            PembayaranPage.icon = "carrefour.png";
        }
        private void menuGramedia_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
            PembayaranPage.layanan = "Voucher";
            PembayaranPage.nominal = "Gramedia";
            PembayaranPage.nomor = "";
            PembayaranPage.icon = "gramedia.png";
        }
        private void menuK24Klik_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
            PembayaranPage.layanan = "Voucher";
            PembayaranPage.nominal = "K24 Klik";
            PembayaranPage.nomor = "";
            PembayaranPage.icon = "k24klik.png";
        }
        private void menuTiket_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NominalVoucherPage());
            PembayaranPage.layanan = "Voucher";
            PembayaranPage.nominal = "Ticket.com";
            PembayaranPage.nomor = "";
            PembayaranPage.icon = "tiketcom.png";
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new HiburanPage());
        }
    }
}

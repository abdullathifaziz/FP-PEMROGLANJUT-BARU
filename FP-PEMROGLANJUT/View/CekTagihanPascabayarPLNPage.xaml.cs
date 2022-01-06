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
    /// Interaction logic for CekTagihanPascabayarPLNPage.xaml
    /// </summary>
    public partial class CekTagihanPascabayarPLNPage : Page
    {
        Controller.TagihanController tagihan;
        public CekTagihanPascabayarPLNPage(string nomor)
        {
            InitializeComponent();
            tagihan = new Controller.TagihanController(this);

            Model.TagihanModel modeltagihan = new Model.TagihanModel();
            lblNamaPelanggan.Content = modeltagihan.NamaPelanggan(nomor);
            lblNomorPelanggan.Content = nomor;
            lblPeriode.Content = modeltagihan.Periode(nomor);
            lblTotalTagihan.Content = modeltagihan.TotalTagihan(nomor);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PascabayarPLNPage pascabayarPLNPage = new PascabayarPLNPage();
            NavigationService.Navigate(pascabayarPLNPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }
    }
}

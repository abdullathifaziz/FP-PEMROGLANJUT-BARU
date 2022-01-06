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
        public CekTagihanPascabayarPage(string nomor)
        {
            InitializeComponent();
            tagihan = new Controller.TagihanController(this);

            Model.TagihanModel modeltagihan = new Model.TagihanModel();
            lblNomorKartu.Content = nomor;
            lblPeriodeKartu.Content = modeltagihan.Periode(nomor);
            lblTotalKartu.Content = "Rp. " + modeltagihan.TotalTagihan(nomor);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PascabayarPage pascabayarPage = new PascabayarPage();
            NavigationService.Navigate(pascabayarPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PembayaranPage pembayaranPage = new PembayaranPage();
            NavigationService.Navigate(pembayaranPage);
        }
    }
}

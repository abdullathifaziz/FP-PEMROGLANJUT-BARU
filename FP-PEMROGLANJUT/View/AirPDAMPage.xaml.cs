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
    /// Interaction logic for AirPDAMPage.xaml
    /// </summary>
    public partial class AirPDAMPage : Page
    {
        public string[] wilayah { get; set; }

        public AirPDAMPage()
        {
            InitializeComponent();
            wilayah = new string[] { "Aceh", "Bali", "Bandar Lampung", "Bangka Belitung", "Banten", "Bengkulu", "DKI Jakarta",
                                     "Gorontalo", "Jambi", "Jawa Barat", "Jawa Tengah", "Jawa Timur", "DI Yogyakarta", "Kalimantan Barat",
                                     "Kalimantan Selatan", "Kalimantan Tengah", "Kalimantan Timur", "Kalimantan Utara", "Kepulauan Riau", 
                                     "Lampung", "Maluku", "Maluku Utara", "Nusa Tenggara Barat", "Nusa Tenggara Timur", "Papua", "Riau",
                                     "Sulawesi Barat", "Sulawesi Selatan", "Sulawesi Tengah", "Sulawesi Utara", "Sumatera Barat", "Sumatera Selatan",
                                     "Sumatera Utara"};
            DataContext = this;

        }

        private void btnCekTagihan_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CekTagihanAirPDAMPage(noSambunganAirPDAM.Text.ToString(), cmbAirPDAM.Text.ToString()));
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new TagihanPage());
        }

    }
}

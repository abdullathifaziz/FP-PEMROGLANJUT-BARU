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
    /// Interaction logic for PembayaranPage.xaml
    /// </summary>
    public partial class PembayaranPage : Page
    {
        public static string icon;
        public PembayaranPage()
        {
            InitializeComponent();

            string path = "/Images/" + icon;
            Uri resourceUri = new Uri(path, UriKind.Relative);
            imgIcon.Source = new BitmapImage(resourceUri);
        }

        private void btnBayar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NominalBayarPage());
        }
    }
}

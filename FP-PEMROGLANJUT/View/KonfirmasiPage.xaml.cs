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
    /// Interaction logic for KonfirmasiPage.xaml
    /// </summary>
    public partial class KonfirmasiPage : Page
    {
        public KonfirmasiPage()
        {
            InitializeComponent();
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HasilTransaksiPage hasilTransaksiPage = new HasilTransaksiPage();
            NavigationService.Navigate(hasilTransaksiPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

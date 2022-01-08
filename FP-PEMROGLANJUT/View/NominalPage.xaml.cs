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
    /// Interaction logic for NominalPage.xaml
    /// </summary>
    public partial class NominalPage : Page
    {
        public NominalPage()
        {
            InitializeComponent();
        }

        private void menuNominal5000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PembayaranPage.nominal = "Rp 5.000";
            NavigationService.Navigate(new NoTelpPembeliPage());
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PulsaPage());
        }

        private void menuNominal10000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NoTelpPembeliPage());
            PembayaranPage.nominal = "Rp 10.000";
        }

        private void menuNominal15000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PembayaranPage.nominal = "Rp 15.000";
            NavigationService.Navigate(new NoTelpPembeliPage());

        }

        private void menuNominal20000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PembayaranPage.nominal = "Rp 20.000";
            NavigationService.Navigate(new NoTelpPembeliPage());
        }

        private void menuNominal35000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PembayaranPage.nominal = "Rp 35.000";
            NavigationService.Navigate(new NoTelpPembeliPage());
        }

        private void menuNominal50000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PembayaranPage.nominal = "Rp 50.000";
            NavigationService.Navigate(new NoTelpPembeliPage());
        }

        private void menuNominal100000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PembayaranPage.nominal = "Rp 100.000";
            NavigationService.Navigate(new NoTelpPembeliPage());
        }

        private void menuNominal150000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PembayaranPage.nominal = "Rp 150.000";
            NavigationService.Navigate(new NoTelpPembeliPage());
        }
    }
}

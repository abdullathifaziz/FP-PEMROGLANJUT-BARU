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
            NavigationService.Navigate(new NoTelpPembeliPage());
            PembayaranPage.nominal = "Rp 5.000";
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PulsaPage pulsaPage = new PulsaPage();
            NavigationService.Navigate(pulsaPage);
        }

        private void menuNominal10000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new NoTelpPembeliPage());
            PembayaranPage.nominal = "Rp 10.000";
        }

        private void menuNominal15000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NoTelpPembeliPage noTelpPembeliPage = new NoTelpPembeliPage();
            NavigationService.Navigate(noTelpPembeliPage);
        }

        private void menuNominal20000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NoTelpPembeliPage noTelpPembeliPage = new NoTelpPembeliPage();
            NavigationService.Navigate(noTelpPembeliPage);
        }

        private void menuNominal35000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NoTelpPembeliPage noTelpPembeliPage = new NoTelpPembeliPage();
            NavigationService.Navigate(noTelpPembeliPage);
        }

        private void menuNominal50000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NoTelpPembeliPage noTelpPembeliPage = new NoTelpPembeliPage();
            NavigationService.Navigate(noTelpPembeliPage);
        }

        private void menuNominal100000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NoTelpPembeliPage noTelpPembeliPage = new NoTelpPembeliPage();
            NavigationService.Navigate(noTelpPembeliPage);
        }

        private void menuNominal150000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NoTelpPembeliPage noTelpPembeliPage = new NoTelpPembeliPage();
            NavigationService.Navigate(noTelpPembeliPage);
        }
    }
}

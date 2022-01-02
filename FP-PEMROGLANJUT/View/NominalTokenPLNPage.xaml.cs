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
    /// Interaction logic for NominalTokenPLNPage.xaml
    /// </summary>
    public partial class NominalTokenPLNPage : Page
    {
        public NominalTokenPLNPage()
        {
            InitializeComponent();
        }

        private void menuNominal20K_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void menuNominal50K_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void menuNominal100K_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void menuNominal200K_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void menuNominal500K_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void menuNominal1JT_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void menuNominal5JT_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void menuNominal10JT_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage());
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new TokenPLNPage());
        }
    }
}

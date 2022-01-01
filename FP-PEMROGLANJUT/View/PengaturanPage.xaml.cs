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
    /// Interaction logic for PengaturanPage.xaml
    /// </summary>
    public partial class PengaturanPage : Page
    {
        public PengaturanPage()
        {
            InitializeComponent();
        }

        private void btnEditNama_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPengaturanPage());
        }
        private void btnEditUsername_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPengaturanPage());
        }
        private void btnEditEmail_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPengaturanPage());
        }
        private void btnEditPassword_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPengaturanPage());
        }
        private void btnEditNoTelp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPengaturanPage());
        }
    }
}

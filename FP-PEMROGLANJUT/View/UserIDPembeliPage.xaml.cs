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
    /// Interaction logic for UserIDPembeliPage.xaml
    /// </summary>
    public partial class UserIDPembeliPage : Page
    {
        public UserIDPembeliPage()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PilihGamePage());
        }

        private void btnSelanjutnya_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmailPage());
        }
    }
}

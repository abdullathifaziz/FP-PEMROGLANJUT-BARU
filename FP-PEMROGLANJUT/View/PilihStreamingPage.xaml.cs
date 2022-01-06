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
    /// Interaction logic for PilihStreamingPage.xaml
    /// </summary>
    public partial class PilihStreamingPage : Page
    {
        public PilihStreamingPage()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new StreamingPage());
        }

        private void menu1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new EmailStreamingPage());
        }

        private void menu2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new EmailStreamingPage());
        }

        private void menu3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new EmailStreamingPage());
        }

        private void menu4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new EmailStreamingPage());
        }
    }
}

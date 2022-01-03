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
    /// Interaction logic for TagihanPage.xaml
    /// </summary>
    public partial class TagihanPage : Page
    {
        public TagihanPage()
        {
            InitializeComponent();
        }

        private void menuListrikPLN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new TagihanListrikPLNPage());
        }

        private void menuAirPDAM_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AirPDAMPage airPDAMPage = new AirPDAMPage();
            airPDAMPage.header.Content = "Air PDAM";
            NavigationService.Navigate(airPDAMPage);
        }

        private void menuInternet_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new InternetPage());
        }
    }
}

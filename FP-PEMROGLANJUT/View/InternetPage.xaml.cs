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
    /// Interaction logic for InternetPage.xaml
    /// </summary>
    public partial class InternetPage : Page
    {
        public string[] internet { get; set; }

        public InternetPage()
        {
            InitializeComponent();

            internet = new string[] { "Indihome", "Firstmedia", "MNC Play", "Indosat GIG", "XL Home", "Biznet", "Oxygen",
                                      "Life Media", "Citranet"};

            DataContext = this;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new TagihanPage());
        }

        private void btnCekTagihan_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CekTagihanInternetPage());
        }
    }
}

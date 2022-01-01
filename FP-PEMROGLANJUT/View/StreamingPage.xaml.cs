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
    /// Interaction logic for StreamingPage.xaml
    /// </summary>
    public partial class StreamingPage : Page
    {
        public StreamingPage()
        {
            InitializeComponent();
        }
        private void menuNetflix_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihStreamingPage pilihStreamingPage = new PilihStreamingPage();

            pilihStreamingPage.logoNetflix.Visibility = Visibility.Visible;
            pilihStreamingPage.logoiFlix.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoVidio.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoViu.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoMaxStream.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihStreamingPage);
        }
        private void menuiFlix_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihStreamingPage pilihStreamingPage = new PilihStreamingPage();

            pilihStreamingPage.logoNetflix.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoiFlix.Visibility = Visibility.Visible;
            pilihStreamingPage.logoVidio.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoViu.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoMaxStream.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihStreamingPage);
        }
        private void menuVidio_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihStreamingPage pilihStreamingPage = new PilihStreamingPage();

            pilihStreamingPage.logoNetflix.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoiFlix.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoVidio.Visibility = Visibility.Visible;
            pilihStreamingPage.logoViu.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoMaxStream.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihStreamingPage);
        }
        private void menuViu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihStreamingPage pilihStreamingPage = new PilihStreamingPage();

            pilihStreamingPage.logoNetflix.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoiFlix.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoVidio.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoViu.Visibility = Visibility.Visible;
            pilihStreamingPage.logoMaxStream.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihStreamingPage);
        }
        private void menuMaxStream_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihStreamingPage pilihStreamingPage = new PilihStreamingPage();

            pilihStreamingPage.logoNetflix.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoiFlix.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoVidio.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoViu.Visibility = Visibility.Hidden;
            pilihStreamingPage.logoMaxStream.Visibility = Visibility.Visible;

            NavigationService.Navigate(pilihStreamingPage);
        }
    }
}

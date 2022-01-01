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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void menuIsiUlangUtama_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IsiUlangPage isiUlangPage = new IsiUlangPage();
            NavigationService.Navigate(isiUlangPage);
        }

        private void menuTagihanUtama_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TagihanPage tagihanPage = new TagihanPage();
            NavigationService.Navigate(tagihanPage);
        }

        private void menuHiburanUtama_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HiburanPage hiburanPage = new HiburanPage();
            NavigationService.Navigate(hiburanPage);
        }
    }
}

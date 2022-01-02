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
    /// Interaction logic for CekTagihanPascabayarPage.xaml
    /// </summary>
    public partial class CekTagihanPascabayarPage : Page
    {
        public CekTagihanPascabayarPage()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PascabayarPage pascabayarPage = new PascabayarPage();
            NavigationService.Navigate(pascabayarPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PembayaranPage pembayaranPage = new PembayaranPage();
            NavigationService.Navigate(pembayaranPage);
        }
    }
}

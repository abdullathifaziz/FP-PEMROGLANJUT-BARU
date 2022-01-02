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
    /// Interaction logic for PascabayarPage.xaml
    /// </summary>
    public partial class PascabayarPage : Page
    {
        public PascabayarPage()
        {
            InitializeComponent();
        }

        private void btnSelanjutnya_Click(object sender, RoutedEventArgs e)
        {
            CekTagihanPascabayarPage cekTagihanPascabayarPage = new CekTagihanPascabayarPage();
            NavigationService.Navigate(cekTagihanPascabayarPage);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IsiUlangPage isiUlangPage = new IsiUlangPage();
            NavigationService.Navigate(isiUlangPage);
        }
    }
}

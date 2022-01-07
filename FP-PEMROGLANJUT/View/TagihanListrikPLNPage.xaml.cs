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
    /// Interaction logic for TagihanListrikPLNPage.xaml
    /// </summary>
    public partial class TagihanListrikPLNPage : Page
    {
        public TagihanListrikPLNPage()
        {
            InitializeComponent();
        }

        private void menuTokenListrik_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new TokenPLNPage());

            PembayaranPage.icon = "tokenlistrikpln.png";
        }

        private void menuPascabayar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PascabayarPLNPage());

            PembayaranPage.icon = "pascabayarpln.png";
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TagihanPage tagihanPage = new TagihanPage();
            NavigationService.Navigate(tagihanPage);
        }
    }
}

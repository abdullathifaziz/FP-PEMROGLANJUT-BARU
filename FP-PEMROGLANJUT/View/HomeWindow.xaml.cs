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
using System.Windows.Shapes;

namespace FP_PEMROGLANJUT.View
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();

            string hariIni = DateTime.Now.ToString("dddd, dd MMMM yyyy", new System.Globalization.CultureInfo("id-ID"));
            lblTanggalan.Content = hariIni;
        }

        private void menuBeranda_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.HomePage());
        }

        private void menuIsiUlang_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.IsiUlangPage());
        }

        private void menuTagihan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.TagihanPage());
        }

        private void menuHiburan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.HiburanPage());
        }

        private void menuPengaturan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.Pengaturan());
        }

        private void logout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult keluar = MessageBox.Show("Yakin Ingin Keluar?", "KELUAR", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(keluar == MessageBoxResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Close();
            }
        }

        private void menuRiwayat_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.RiwayatPage());
            
        }
    }
}

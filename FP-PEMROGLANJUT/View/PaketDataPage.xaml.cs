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
    /// Interaction logic for PaketDataPage.xaml
    /// </summary>
    public partial class PaketDataPage : Page
    {
      
        public PaketDataPage()
        {
            InitializeComponent();
        }

        private void menuPaketDataXL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihPaketDataPage pilihPaketDataPage = new PilihPaketDataPage();

            pilihPaketDataPage.logoXL.Visibility = Visibility.Visible;
            pilihPaketDataPage.logoIndosat.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTri.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTelkomsel.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoSmartfren.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoAxis.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoByu.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoFlexi.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketXL1.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketXL2.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketXL3.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketXL4.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketXL5.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketXL6.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketXL7.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketXL8.Visibility = Visibility.Visible;

            pilihPaketDataPage.menuPaketIndosat1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTri1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTelkomsel1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketSmartfren1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketAxis1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketByu1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketFlexi1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi8.Visibility = Visibility.Hidden;
            
            NavigationService.Navigate(pilihPaketDataPage);

            PembayaranPage.icon = "xl.png";
            
        }

        private void menuPaketDataIndosat_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihPaketDataPage pilihPaketDataPage = new PilihPaketDataPage();

            pilihPaketDataPage.logoXL.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoIndosat.Visibility = Visibility.Visible;
            pilihPaketDataPage.logoTri.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTelkomsel.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoSmartfren.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoAxis.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoByu.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoFlexi.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketXL1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketIndosat1.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketIndosat2.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketIndosat3.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketIndosat4.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketIndosat5.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketIndosat6.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketIndosat7.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketIndosat8.Visibility = Visibility.Visible;

            pilihPaketDataPage.menuPaketTri1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTelkomsel1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketSmartfren1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketAxis1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketByu1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketFlexi1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi8.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihPaketDataPage);

            PembayaranPage.icon = "indosat.png";
        }

        private void menuPaketDataTri_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihPaketDataPage pilihPaketDataPage = new PilihPaketDataPage();

            pilihPaketDataPage.logoXL.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoIndosat.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTri.Visibility = Visibility.Visible;
            pilihPaketDataPage.logoTelkomsel.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoSmartfren.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoAxis.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoByu.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoFlexi.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketXL1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketIndosat1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTri1.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTri2.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTri3.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTri4.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTri5.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTri6.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTri7.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTri8.Visibility = Visibility.Visible;

            pilihPaketDataPage.menuPaketTelkomsel1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketSmartfren1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketAxis1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketByu1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketFlexi1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi8.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihPaketDataPage);

            PembayaranPage.icon = "Tri.png";
        }

        private void menuPaketDataTelkomsel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihPaketDataPage pilihPaketDataPage = new PilihPaketDataPage();

            pilihPaketDataPage.logoXL.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoIndosat.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTri.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTelkomsel.Visibility = Visibility.Visible;
            pilihPaketDataPage.logoSmartfren.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoAxis.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoByu.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoFlexi.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketXL1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketIndosat1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTri1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTelkomsel1.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTelkomsel2.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTelkomsel3.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTelkomsel4.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTelkomsel5.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTelkomsel6.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTelkomsel7.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketTelkomsel8.Visibility = Visibility.Visible;

            pilihPaketDataPage.menuPaketSmartfren1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketAxis1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketByu1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketFlexi1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi8.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihPaketDataPage);

            PembayaranPage.icon = "Telkomsel.png";
        }

        private void menuPaketDataSmartfren_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihPaketDataPage pilihPaketDataPage = new PilihPaketDataPage();

            pilihPaketDataPage.logoXL.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoIndosat.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTri.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTelkomsel.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoSmartfren.Visibility = Visibility.Visible;
            pilihPaketDataPage.logoAxis.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoByu.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoFlexi.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketXL1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketIndosat1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTri1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTelkomsel1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketSmartfren1.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketSmartfren2.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketSmartfren3.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketSmartfren4.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketSmartfren5.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketSmartfren6.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketSmartfren7.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketSmartfren8.Visibility = Visibility.Visible;

            pilihPaketDataPage.menuPaketAxis1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketByu1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketFlexi1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi8.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihPaketDataPage);

            PembayaranPage.icon = "Smartfren.png";
        }

        private void menuPaketDataAxis_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihPaketDataPage pilihPaketDataPage = new PilihPaketDataPage();

            pilihPaketDataPage.logoXL.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoIndosat.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTri.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTelkomsel.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoSmartfren.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoAxis.Visibility = Visibility.Visible;
            pilihPaketDataPage.logoByu.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoFlexi.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketXL1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketIndosat1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTri1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTelkomsel1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketSmartfren1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketAxis1.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketAxis2.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketAxis3.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketAxis4.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketAxis5.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketAxis6.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketAxis7.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketAxis8.Visibility = Visibility.Visible;

            pilihPaketDataPage.menuPaketByu1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketFlexi1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi8.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihPaketDataPage);

            PembayaranPage.icon = "Axis.png";
        }

        private void menuPaketDataByu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihPaketDataPage pilihPaketDataPage = new PilihPaketDataPage();

            pilihPaketDataPage.logoXL.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoIndosat.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTri.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTelkomsel.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoSmartfren.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoAxis.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoByu.Visibility = Visibility.Visible;
            pilihPaketDataPage.logoFlexi.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketXL1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketIndosat1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTri1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTelkomsel1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketSmartfren1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketAxis1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketByu1.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketByu2.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketByu3.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketByu4.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketByu5.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketByu6.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketByu7.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketByu8.Visibility = Visibility.Visible;

            pilihPaketDataPage.menuPaketFlexi1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketFlexi8.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihPaketDataPage);

            PembayaranPage.icon = "By u.png";
        }

        private void menuPaketDataFlexi_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihPaketDataPage pilihPaketDataPage = new PilihPaketDataPage();

            pilihPaketDataPage.logoXL.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoIndosat.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTri.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoTelkomsel.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoSmartfren.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoAxis.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoByu.Visibility = Visibility.Hidden;
            pilihPaketDataPage.logoFlexi.Visibility = Visibility.Visible;

            pilihPaketDataPage.menuPaketXL1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketXL8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketIndosat1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketIndosat8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTri1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTri8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketTelkomsel1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketTelkomsel8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketSmartfren1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketSmartfren8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketAxis1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketAxis8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketByu1.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu2.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu3.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu4.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu5.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu6.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu7.Visibility = Visibility.Hidden;
            pilihPaketDataPage.menuPaketByu8.Visibility = Visibility.Hidden;

            pilihPaketDataPage.menuPaketFlexi1.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketFlexi2.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketFlexi3.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketFlexi4.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketFlexi5.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketFlexi6.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketFlexi7.Visibility = Visibility.Visible;
            pilihPaketDataPage.menuPaketFlexi8.Visibility = Visibility.Visible;

            NavigationService.Navigate(pilihPaketDataPage);

            PembayaranPage.icon = "Flexi.png";
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IsiUlangPage isiUlangPage = new IsiUlangPage();
            NavigationService.Navigate(isiUlangPage);
        }
    }
}

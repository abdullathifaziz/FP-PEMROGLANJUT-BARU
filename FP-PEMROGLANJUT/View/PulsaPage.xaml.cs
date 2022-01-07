﻿using System;
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
    /// Interaction logic for PulsaPage.xaml
    /// </summary>
    public partial class PulsaPage : Page
    {
        public PulsaPage()
        {
            InitializeComponent();
        }

        private void menuXL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NominalPage nominalPage = new NominalPage();
            NavigationService.Navigate(nominalPage);

            PembayaranPage.icon = "xl.png";
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IsiUlangPage isiUlangPage = new IsiUlangPage();
            NavigationService.Navigate(isiUlangPage);
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void menuIndosat_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NominalPage nominalPage = new NominalPage();
            NavigationService.Navigate(nominalPage);

            PembayaranPage.icon = "indosat.png";
        }

        private void menuTri_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NominalPage nominalPage = new NominalPage();
            NavigationService.Navigate(nominalPage);
        }

        private void menuTelkomsel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NominalPage nominalPage = new NominalPage();
            NavigationService.Navigate(nominalPage);
        }

        private void menuSmartfren_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NominalPage nominalPage = new NominalPage();
            NavigationService.Navigate(nominalPage);
        }

        private void menuAxis_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NominalPage nominalPage = new NominalPage();
            NavigationService.Navigate(nominalPage);
        }

        private void menuByu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NominalPage nominalPage = new NominalPage();
            NavigationService.Navigate(nominalPage);
        }

        private void menuFlexi_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NominalPage nominalPage = new NominalPage();
            NavigationService.Navigate(nominalPage);
        }
    }
}

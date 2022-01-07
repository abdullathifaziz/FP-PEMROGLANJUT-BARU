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
    /// Interaction logic for GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        public GamePage()
        {
            InitializeComponent();
        }
        private void menuPUBG_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihGamePage pilihGamePage = new PilihGamePage();

            pilihGamePage.logoPubg.Visibility = Visibility.Visible;
            pilihGamePage.logoML.Visibility = Visibility.Hidden;
            pilihGamePage.logoFreeFire.Visibility = Visibility.Hidden;
            pilihGamePage.logoAOV.Visibility = Visibility.Hidden;
            pilihGamePage.logoSteam.Visibility = Visibility.Hidden;

            pilihGamePage.menuPubg1.Visibility = Visibility.Visible;
            pilihGamePage.menuPubg2.Visibility = Visibility.Visible;
            pilihGamePage.menuPubg3.Visibility = Visibility.Visible;
            pilihGamePage.menuPubg4.Visibility = Visibility.Visible;
            pilihGamePage.menuPubg5.Visibility = Visibility.Visible;
            pilihGamePage.menuPubg6.Visibility = Visibility.Visible;
            pilihGamePage.menuPubg7.Visibility = Visibility.Visible;
            pilihGamePage.menuPubg8.Visibility = Visibility.Visible;

            pilihGamePage.menuML1.Visibility = Visibility.Hidden;
            pilihGamePage.menuML2.Visibility = Visibility.Hidden;
            pilihGamePage.menuML3.Visibility = Visibility.Hidden;
            pilihGamePage.menuML4.Visibility = Visibility.Hidden;
            pilihGamePage.menuML5.Visibility = Visibility.Hidden;
            pilihGamePage.menuML6.Visibility = Visibility.Hidden;
            pilihGamePage.menuML7.Visibility = Visibility.Hidden;
            pilihGamePage.menuML8.Visibility = Visibility.Hidden;

            pilihGamePage.menuFreeFire1.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire2.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire3.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire4.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire5.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire6.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire7.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire8.Visibility = Visibility.Hidden;

            pilihGamePage.menuAOV1.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV2.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV3.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV4.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV5.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV6.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV7.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV8.Visibility = Visibility.Hidden;

            pilihGamePage.menuSteam1.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam2.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam3.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam4.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam5.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam6.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam7.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam8.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihGamePage);

            PembayaranPage.icon = "pubg.png";
        }
        private void menuMobileLegends_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihGamePage pilihGamePage = new PilihGamePage();

            pilihGamePage.logoPubg.Visibility = Visibility.Hidden;
            pilihGamePage.logoML.Visibility = Visibility.Visible;
            pilihGamePage.logoFreeFire.Visibility = Visibility.Hidden;
            pilihGamePage.logoAOV.Visibility = Visibility.Hidden;
            pilihGamePage.logoSteam.Visibility = Visibility.Hidden;

            pilihGamePage.menuPubg1.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg2.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg3.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg4.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg5.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg6.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg7.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg8.Visibility = Visibility.Hidden;

            pilihGamePage.menuML1.Visibility = Visibility.Visible;
            pilihGamePage.menuML2.Visibility = Visibility.Visible;
            pilihGamePage.menuML3.Visibility = Visibility.Visible;
            pilihGamePage.menuML4.Visibility = Visibility.Visible;
            pilihGamePage.menuML5.Visibility = Visibility.Visible;
            pilihGamePage.menuML6.Visibility = Visibility.Visible;
            pilihGamePage.menuML7.Visibility = Visibility.Visible;
            pilihGamePage.menuML8.Visibility = Visibility.Visible;

            pilihGamePage.menuFreeFire1.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire2.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire3.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire4.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire5.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire6.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire7.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire8.Visibility = Visibility.Hidden;

            pilihGamePage.menuAOV1.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV2.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV3.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV4.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV5.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV6.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV7.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV8.Visibility = Visibility.Hidden;

            pilihGamePage.menuSteam1.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam2.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam3.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam4.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam5.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam6.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam7.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam8.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihGamePage);

            PembayaranPage.icon = "ml.png";
        }
        private void menuFreeFire_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihGamePage pilihGamePage = new PilihGamePage();

            pilihGamePage.logoPubg.Visibility = Visibility.Hidden;
            pilihGamePage.logoML.Visibility = Visibility.Hidden;
            pilihGamePage.logoFreeFire.Visibility = Visibility.Visible;
            pilihGamePage.logoAOV.Visibility = Visibility.Hidden;
            pilihGamePage.logoSteam.Visibility = Visibility.Hidden;

            pilihGamePage.menuPubg1.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg2.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg3.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg4.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg5.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg6.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg7.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg8.Visibility = Visibility.Hidden;

            pilihGamePage.menuML1.Visibility = Visibility.Hidden;
            pilihGamePage.menuML2.Visibility = Visibility.Hidden;
            pilihGamePage.menuML3.Visibility = Visibility.Hidden;
            pilihGamePage.menuML4.Visibility = Visibility.Hidden;
            pilihGamePage.menuML5.Visibility = Visibility.Hidden;
            pilihGamePage.menuML6.Visibility = Visibility.Hidden;
            pilihGamePage.menuML7.Visibility = Visibility.Hidden;
            pilihGamePage.menuML8.Visibility = Visibility.Hidden;

            pilihGamePage.menuFreeFire1.Visibility = Visibility.Visible;
            pilihGamePage.menuFreeFire2.Visibility = Visibility.Visible;
            pilihGamePage.menuFreeFire3.Visibility = Visibility.Visible;
            pilihGamePage.menuFreeFire4.Visibility = Visibility.Visible;
            pilihGamePage.menuFreeFire5.Visibility = Visibility.Visible;
            pilihGamePage.menuFreeFire6.Visibility = Visibility.Visible;
            pilihGamePage.menuFreeFire7.Visibility = Visibility.Visible;
            pilihGamePage.menuFreeFire8.Visibility = Visibility.Visible;

            pilihGamePage.menuAOV1.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV2.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV3.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV4.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV5.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV6.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV7.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV8.Visibility = Visibility.Hidden;

            pilihGamePage.menuSteam1.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam2.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam3.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam4.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam5.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam6.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam7.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam8.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihGamePage);

            PembayaranPage.icon = "freefire.png";
        }
        private void menuArenaOfValor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihGamePage pilihGamePage = new PilihGamePage();

            pilihGamePage.logoPubg.Visibility = Visibility.Hidden;
            pilihGamePage.logoML.Visibility = Visibility.Hidden;
            pilihGamePage.logoFreeFire.Visibility = Visibility.Hidden;
            pilihGamePage.logoAOV.Visibility = Visibility.Visible;
            pilihGamePage.logoSteam.Visibility = Visibility.Hidden;

            pilihGamePage.menuPubg1.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg2.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg3.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg4.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg5.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg6.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg7.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg8.Visibility = Visibility.Hidden;

            pilihGamePage.menuML1.Visibility = Visibility.Hidden;
            pilihGamePage.menuML2.Visibility = Visibility.Hidden;
            pilihGamePage.menuML3.Visibility = Visibility.Hidden;
            pilihGamePage.menuML4.Visibility = Visibility.Hidden;
            pilihGamePage.menuML5.Visibility = Visibility.Hidden;
            pilihGamePage.menuML6.Visibility = Visibility.Hidden;
            pilihGamePage.menuML7.Visibility = Visibility.Hidden;
            pilihGamePage.menuML8.Visibility = Visibility.Hidden;

            pilihGamePage.menuFreeFire1.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire2.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire3.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire4.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire5.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire6.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire7.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire8.Visibility = Visibility.Hidden;

            pilihGamePage.menuAOV1.Visibility = Visibility.Visible;
            pilihGamePage.menuAOV2.Visibility = Visibility.Visible;
            pilihGamePage.menuAOV3.Visibility = Visibility.Visible;
            pilihGamePage.menuAOV4.Visibility = Visibility.Visible;
            pilihGamePage.menuAOV5.Visibility = Visibility.Visible;
            pilihGamePage.menuAOV6.Visibility = Visibility.Visible;
            pilihGamePage.menuAOV7.Visibility = Visibility.Visible;
            pilihGamePage.menuAOV8.Visibility = Visibility.Visible;

            pilihGamePage.menuSteam1.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam2.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam3.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam4.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam5.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam6.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam7.Visibility = Visibility.Hidden;
            pilihGamePage.menuSteam8.Visibility = Visibility.Hidden;

            NavigationService.Navigate(pilihGamePage);

            PembayaranPage.icon = "aov.png";
        }
        private void menuSteam_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PilihGamePage pilihGamePage = new PilihGamePage();

            pilihGamePage.logoPubg.Visibility = Visibility.Hidden;
            pilihGamePage.logoML.Visibility = Visibility.Hidden;
            pilihGamePage.logoFreeFire.Visibility = Visibility.Hidden;
            pilihGamePage.logoAOV.Visibility = Visibility.Hidden;
            pilihGamePage.logoSteam.Visibility = Visibility.Visible;

            pilihGamePage.menuPubg1.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg2.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg3.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg4.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg5.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg6.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg7.Visibility = Visibility.Hidden;
            pilihGamePage.menuPubg8.Visibility = Visibility.Hidden;

            pilihGamePage.menuML1.Visibility = Visibility.Hidden;
            pilihGamePage.menuML2.Visibility = Visibility.Hidden;
            pilihGamePage.menuML3.Visibility = Visibility.Hidden;
            pilihGamePage.menuML4.Visibility = Visibility.Hidden;
            pilihGamePage.menuML5.Visibility = Visibility.Hidden;
            pilihGamePage.menuML6.Visibility = Visibility.Hidden;
            pilihGamePage.menuML7.Visibility = Visibility.Hidden;
            pilihGamePage.menuML8.Visibility = Visibility.Hidden;

            pilihGamePage.menuFreeFire1.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire2.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire3.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire4.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire5.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire6.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire7.Visibility = Visibility.Hidden;
            pilihGamePage.menuFreeFire8.Visibility = Visibility.Hidden;

            pilihGamePage.menuAOV1.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV2.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV3.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV4.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV5.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV6.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV7.Visibility = Visibility.Hidden;
            pilihGamePage.menuAOV8.Visibility = Visibility.Hidden;

            pilihGamePage.menuSteam1.Visibility = Visibility.Visible;
            pilihGamePage.menuSteam2.Visibility = Visibility.Visible;
            pilihGamePage.menuSteam3.Visibility = Visibility.Visible;
            pilihGamePage.menuSteam4.Visibility = Visibility.Visible;
            pilihGamePage.menuSteam5.Visibility = Visibility.Visible;
            pilihGamePage.menuSteam6.Visibility = Visibility.Visible;
            pilihGamePage.menuSteam7.Visibility = Visibility.Visible;
            pilihGamePage.menuSteam8.Visibility = Visibility.Visible;

            NavigationService.Navigate(pilihGamePage);

            PembayaranPage.icon = "steam.png";
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new HiburanPage());
        }
    }
}

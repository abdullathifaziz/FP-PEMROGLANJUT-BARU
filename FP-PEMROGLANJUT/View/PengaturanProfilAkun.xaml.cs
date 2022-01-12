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
    /// Interaction logic for PengaturanProfilAkun.xaml
    /// </summary>
    public partial class PengaturanProfilAkun : Page
    {

        Controller.AkunController akunController;

        public PengaturanProfilAkun()
        {
            InitializeComponent();

            akunController = new Controller.AkunController(this);

            lblNama.Content = getLoged();
            akunController.LoadData();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Pengaturan());
        }

        private string getLoged()
        {
            return ((HomeWindow)Application.Current.Windows[0]).lblIDUser.Content.ToString();
        }
    }
}

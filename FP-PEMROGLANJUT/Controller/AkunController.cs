using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FP_PEMROGLANJUT.Controller
{
    class AkunController
    {
        // Object
        Model.AkunModel akun;
        View.LoginPage login;
        View.BuatAkunPage register;
        View.PengaturanProfilAkunSimpan ubahSimpan;
        View.PengaturanProfilAkun akunProfil;

        // Instance
        public AkunController(View.LoginPage login)
        {
            akun = new Model.AkunModel();
            this.login = login;
        }

        public AkunController(View.BuatAkunPage register)
        {
            akun = new Model.AkunModel();
            this.register = register;
        }

        public AkunController(View.PengaturanProfilAkunSimpan ubahSimpan)
        {
            akun = new Model.AkunModel();
            this.ubahSimpan = ubahSimpan;
        }

        public AkunController(View.PengaturanProfilAkun akunProfil)
        {
            akun = new Model.AkunModel();
            this.akunProfil = akunProfil;
        }

        public void Login()
        {
            akun.usrname = login.txtUsername.Text;
            akun.passwd = login.txtPassword.Password;
            bool result = akun.CekLogin();

            akun.nama_depan = akun.CekNamaDepan(akun.usrname);
            akun.nama_belakang = akun.CekNamaBelakang(akun.usrname);

            if (result)
            {
                View.HomeWindow homeWindow = new View.HomeWindow();
                homeWindow.Show();
                homeWindow.lblIDUser.Content = akun.usrname;
                homeWindow.lblUser.Content = akun.nama_depan + " " + akun.nama_belakang;
                login.Close();
            }
            else
            {
                MessageBox.Show("ID Password Salah");
                login.txtUsername.Text = "";
                login.txtPassword.Password = "";
                login.txtUsername.Focus();
            }
        }

        public void Register()
        {
            if (register.checkboxSDK.IsChecked ?? false)
            {
                akun.nama_depan = register.txtNamaDepan.Text;
                akun.nama_belakang = register.txtNamaBelakang.Text;
                akun.usrname = register.txtUsername.Text;
                akun.passwd = register.txtPassword.Password;

                bool result = akun.InsertAkun();

                if (result)
                {
                    MessageBox.Show("Pembuatan Akun Berhasil");
                    View.LoginPage login = new View.LoginPage();
                    login.Show();
                    register.Close();
                }
                else
                {
                    MessageBox.Show("Pembuatan Akun Gagal");
                    View.BuatAkunPage register = new View.BuatAkunPage();
                    register.Show();
                    register.Close();
                }
            }
            else
            {
                MessageBox.Show("Mohon checklist Syarat dan Ketentuan");
            }
        }

        //update data siswa
        public void EditAkun()
        {
            akun.usrname = ubahSimpan.usernameAkunProfil.Text;
            akun.passwd = ubahSimpan.passowrdAkunProfil.Text;
        }

        public void LoadData()
        {
            string username = akunProfil.lblNama.Content.ToString();

            string[] data = akun.getDetail(username);

            if (data[0] == "")
            {
                MessageBox.Show("Unknown error!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                akunProfil.lblNama.Content = data[0];
                akunProfil.lblUser.Content = data[1];
                akunProfil.lblPass.Content = data[2];
            }
        }
    }
}

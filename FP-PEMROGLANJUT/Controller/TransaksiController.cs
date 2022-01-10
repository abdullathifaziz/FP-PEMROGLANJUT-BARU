using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Data;

namespace FP_PEMROGLANJUT.Controller
{
    class TransaksiController
    {
        Model.TransaksiModel transaksi;
        View.PembayaranPage pembayaran;
        View.RiwayatPage riwayat;

        public TransaksiController(View.PembayaranPage pembayaran)
        {
            transaksi = new Model.TransaksiModel();
            this.pembayaran = pembayaran;
        }

        public TransaksiController(View.RiwayatPage riwayat)
        {
            transaksi = new Model.TransaksiModel();
            this.riwayat = riwayat;
        }

        public void Counter()
        {
            string countertransaksi;
            countertransaksi = transaksi.CounterTransaksi();
            MessageBox.Show(countertransaksi);
        }

        public void InputProduk()
        {

        }

        public void DataRiwayat()
        {
            string cari = riwayat.txtCari.Text;
            DataSet data = transaksi.SelectDataGrid(cari);
            riwayat.dgTransaksi.ItemsSource = data.Tables[0].DefaultView;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FP_PEMROGLANJUT.Controller
{
    class TransaksiController
    {
        Model.TransaksiModel transaksi;
        View.PembayaranPage pembayaran;

        public TransaksiController(View.PembayaranPage pembayaran)
        {
            transaksi = new Model.TransaksiModel();
            this.pembayaran = pembayaran;
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
    }
}

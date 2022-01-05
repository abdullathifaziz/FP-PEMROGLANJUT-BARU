using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_PEMROGLANJUT.Model
{
    class PembayaranModel
    {
        DBConnector temp;

        public int id_pembayaran { get; set; }
        public int id_transaksi { get; set; }
        public int total_bayar { get; set; }

        public PembayaranModel()
        {
            temp = new DBConnector();
        }
    }
}

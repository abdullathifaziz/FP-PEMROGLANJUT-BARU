using System;
using System.Collections.Generic;
using System.Text;

namespace FP_PEMROGLANJUT.Model
{
    class TransaksiModel
    {
        DBConnector temp;

        public int id_transaksi { get; set; }
        public string id_produk { get; set; }
        public string id_tagihan { get; set; }
        public int id_pembeli { get; set; }

        public TransaksiModel()
        {
            temp = new DBConnector();
        }
    }
}

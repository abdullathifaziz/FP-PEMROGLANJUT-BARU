using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_PEMROGLANJUT.Model
{
    class ProdukModel
    {
        DBConnector temp;

        public string id_produk { get; set; }
        public string kategori_produk { get; set; }
        public string jenis_produk { get; set; }
        public string nama_produk { get; set; }
        public string nominal { get; set; }
        public int harga { get; set; }

        public ProdukModel()
        {
            temp = new DBConnector();
        }
    }
}

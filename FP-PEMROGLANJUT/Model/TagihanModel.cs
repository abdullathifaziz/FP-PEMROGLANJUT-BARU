using System;
using System.Collections.Generic;
using System.Text;

namespace FP_PEMROGLANJUT.Model
{
    class TagihanModel
    {
        DBConnector temp;

        public string id_tagihan { get; set; }
        public string kategori_tagihan { get; set; }
        public string jenis_tagihan { get; set; }
        public int nomor_tagihan { get; set; }
        public string nama_pelanggan { get; set; }
        public string daerah { get; set; }
        public string periode { get; set; }
        public int total_tagihan { get; set; }

        public TagihanModel()
        {
            temp = new DBConnector();
        }
    }
}

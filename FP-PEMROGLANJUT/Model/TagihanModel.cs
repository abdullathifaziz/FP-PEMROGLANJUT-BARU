using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

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

        public string Periode(string id_tagihan)
        {
            string result;
            DataSet dsperiode = new DataSet();
            dsperiode = temp.QueryManual("SELECT periode FROM tagihan WHERE nomor_tagihan = " + id_tagihan, "tagihan");
            result = dsperiode.Tables[0].Rows[0][0].ToString();
            return result;
        }

        public string TotalTagihan(string id_tagihan)
        {
            string result;
            DataSet dstotal = new DataSet();
            dstotal = temp.QueryManual("SELECT total_tagihan FROM tagihan WHERE nomor_tagihan = " + id_tagihan, "tagihan");
            result = dstotal.Tables[0].Rows[0][0].ToString();
            return result;
        }

        public string NamaPelanggan(string id_tagihan)
        {
            string result;
            DataSet dsnamapelanggan = new DataSet();
            dsnamapelanggan = temp.QueryManual("SELECT nama_pelanggan FROM tagihan WHERE nomor_tagihan = " + id_tagihan, "tagihan");
            result = dsnamapelanggan.Tables[0].Rows[0][0].ToString();
            return result;
        }
    }
}

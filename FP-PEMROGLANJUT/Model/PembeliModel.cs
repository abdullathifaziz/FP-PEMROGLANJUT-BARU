using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_PEMROGLANJUT.Model
{
    class PembeliModel
    {
        DBConnector temp;

        public int id_pembeli { get; set; }
        public int id_transaksi { get; set; }
        public int nomor_pembeli { get; set; }
        public string userid_pembeli { get; set; }
        public string email { get; set; }

        public PembeliModel()
        {
            temp = new DBConnector();
        }

        public bool InputNoTelp()
        {
            string data = id_transaksi + "," + "'" + nomor_pembeli + "'";
            return temp.Insert("pembeli(id_transaksi,nomor_pembeli)", data);
        }

        public bool InputUserID()
        {
            string data = id_transaksi + "," + "'" + userid_pembeli + "'";
            return temp.Insert("pembeli(id_transaksi,userid_pembeli)", data);
        }

        public bool InputEmail()
        {
            string data = id_transaksi + "," + "'" + email + "'";
            return temp.Insert("pembeli(id_transaksi,email)", data);
        }
    }
}

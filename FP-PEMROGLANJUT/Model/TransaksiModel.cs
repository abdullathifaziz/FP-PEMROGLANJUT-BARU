using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_PEMROGLANJUT.Model
{
    class TransaksiModel
    {
        DBConnector temp;

        public int id_transaksi { get; set; }
        public string id_produk { get; set; }
        public string id_tagihan { get; set; }

        public TransaksiModel()
        {
            temp = new DBConnector();
        }

        public string CounterTransaksi()
        {
            string result;
            DataSet dscounter = new DataSet();
            dscounter = temp.QueryManual("SELECT COUNT(id_transaksi) FROM transaksi", "transaksi");
            result = dscounter.Tables[0].Rows[0][0].ToString();
            return result;
        }

        public bool InsertProduk()
        {
            string data = "'" + id_produk + "'";
            return temp.Insert("transaksi(id_produk)", data);
        }

        public bool InsertTagihan()
        {
            string data = "'" + id_tagihan + "'";
            return temp.Insert("transaksi(id_tagihan)", data);
        }

        public DataSet SelectDataGrid(string search)
        {
            DataSet dsSelectDataGrid = new DataSet();
            if (search == "")
            {
                dsSelectDataGrid = temp.CustomSelectJoin("transaksi FULL JOIN produk ON produk.id_produk = transaksi.id_produk FULL JOIN tagihan ON tagihan.id_tagihan = transaksi.id_tagihan FULL JOIN pembeli ON pembeli.id_transaksi = transaksi.id_transaksi JOIN pembayaran ON pembayaran.id_transaksi = transaksi.id_transaksi", null);
            }
            else
            {
                string kondisi = "produk.kategori_produk LIKE '%" + search + "%' OR produk.jenis_produk LIKE '%" + search + "%' OR produk.nama_produk LIKE '%" + search + "%' OR produk.nominal LIKE '%" + search + "%' OR produk.harga LIKE '%" + search + "%' OR tagihan.kategori_tagihan LIKE '%" + search + "%' OR tagihan.jenis_tagihan LIKE '%" + search + "%' OR tagihan.nomor_tagihan LIKE '%" + search + "%' OR tagihan.nama_pelanggan LIKE '%" + search + "%' OR tagihan.daerah LIKE '%" + search + "%' OR tagihan.periode LIKE '%" + search + "%' OR tagihan.total_tagihan LIKE '%" + search + "%' OR pembeli.nomor_pembeli LIKE '%" + search + "%' OR pembeli.userid_pembeli LIKE '%" + search + "%' OR pembeli.email LIKE '%" + search + "%' OR pembayaran.total_bayar LIKE '%" + search + "%'";
                dsSelectDataGrid = temp.CustomSelectJoin("transaksi FULL JOIN produk ON produk.id_produk = transaksi.id_produk FULL JOIN tagihan ON tagihan.id_tagihan = transaksi.id_tagihan FULL JOIN pembeli ON pembeli.id_transaksi = transaksi.id_transaksi JOIN pembayaran ON pembayaran.id_transaksi = transaksi.id_transaksi", kondisi);
            }
            return dsSelectDataGrid;
        }
    }
}

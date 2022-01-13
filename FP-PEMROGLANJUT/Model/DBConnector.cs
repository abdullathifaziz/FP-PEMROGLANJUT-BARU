using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace FP_PEMROGLANJUT.Model
{
    class DBConnector
    {
        private static SqlConnection connector;
        private SqlCommand command;
        private bool result;

        public static SqlConnection GetConnection()
        {
            
            // Ganti Data Source dadi Jneng Server e dewe-dewe
            connector = new SqlConnection();
            connector.ConnectionString = "Data Source = PLENG;" +
                                         "Initial Catalog = ppob;" +
                                         "Integrated Security = True";

            return connector;
        }

        public void dbChecker()
        {
            GetConnection();

            try
            {
                connector.Open();
                MessageBox.Show("Connected");
            }
            catch(SqlException se)
            {
                MessageBox.Show("Fail" + se);
            }
            connector.Close();
        }

        // CRUD
        // Constructor
        public DBConnector()
        {
            GetConnection();
        }

        // SELECT DATA
        public DataSet Select(string tabel, string kondisi)
        {
            DataSet ds = new DataSet();
            
            try
            {
                connector.Open();
                command = new SqlCommand();
                command.Connection = connector;
                command.CommandType = CommandType.Text;
                if (kondisi == null)
                {
                    command.CommandText = "SELECT * FROM " + tabel;
                }
                else
                {
                    command.CommandText = "SELECT * FROM " + tabel + " WHERE " + kondisi;
                }
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, tabel);
            }
            catch(SqlException)
            {
                ds = null;
            }
            connector.Close();
            return ds;
        }

        // INSERT DATA
        public bool Insert(string tabel, string data)
        {
            result = false;
            try
            {
                string query = "INSERT INTO " + tabel + " VALUES (" + data + ")";
                connector.Open();
                command = new SqlCommand();
                command.Connection = connector;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch(SqlException)
            {
                result = false;
            }
            connector.Close();
            return result;
        }

        // UPDATE DATA
        public bool Update(string tabel, string data, string kondisi)
        {
            result = false;
            try
            {
                string query = "UPDATE " + tabel + " SET " + data + " WHERE " + kondisi;
                connector.Open();
                command = new SqlCommand();
                command.Connection = connector;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            connector.Close();
            return result;
        }

        // DELETE DATA
        public bool Delete(string tabel, string kondisi)
        {
            result = false;
            try
            {
                string query = "DELETE FROM " + tabel + " WHERE " + kondisi;
                connector.Open();
                command = new SqlCommand();
                command.Connection = connector;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch(SqlException)
            {
                result = false;
            }
            connector.Close();
            return result;
        }

        public DataSet QueryManual(string query, string tabel)
        {
            DataSet ds = new DataSet();

            try
            {
                connector.Open();
                command = new SqlCommand();
                command.Connection = connector;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, tabel);
            }
            catch (SqlException)
            {
                ds = null;
            }
            connector.Close();
            return ds;
        }

        public DataSet CustomSelectJoin(string tabel, string kondisi)
        {
            DataSet ds = new DataSet();

            try
            {
                connector.Open();
                command = new SqlCommand();
                command.Connection = connector;
                command.CommandType = CommandType.Text;
                if (kondisi == null)
                {
                    command.CommandText = "SELECT produk.kategori_produk AS 'Kategori Produk',produk.jenis_produk AS 'Jenis Produk',produk.nama_produk AS 'Nama Produk',produk.nominal AS 'Paket Yang Dipilih',produk.harga AS 'Harga Paket',tagihan.kategori_tagihan AS 'Kategori Tagihan',tagihan.jenis_tagihan AS 'Jenis Tagihan',tagihan.nomor_tagihan AS 'Nomor Tagihan Pelanggan',tagihan.nama_pelanggan AS 'Nama Pelanggan',tagihan.daerah AS 'Daerah Pelanggan',tagihan.periode AS 'Periode Tagihan',tagihan.total_tagihan AS 'Total Tagihan',pembeli.nomor_pembeli AS 'Nomor Telepon Pembeli',pembeli.userid_pembeli AS 'User ID Pembeli',pembeli.email AS 'E-Mail Pembeli',pembayaran.total_bayar AS 'Total Yang Dibayarkan' FROM " + tabel;
                }
                else
                {
                    command.CommandText = "SELECT produk.kategori_produk AS 'Kategori Produk',produk.jenis_produk AS 'Jenis Produk',produk.nama_produk AS 'Nama Produk',produk.nominal AS 'Paket Yang Dipilih',produk.harga AS 'Harga Paket',tagihan.kategori_tagihan AS 'Kategori Tagihan',tagihan.jenis_tagihan AS 'Jenis Tagihan',tagihan.nomor_tagihan AS 'Nomor Tagihan Pelanggan',tagihan.nama_pelanggan AS 'Nama Pelanggan',tagihan.daerah AS 'Daerah Pelanggan',tagihan.periode AS 'Periode Tagihan',tagihan.total_tagihan AS 'Total Tagihan',pembeli.nomor_pembeli AS 'Nomor Telepon Pembeli',pembeli.userid_pembeli AS 'User ID Pembeli',pembeli.email AS 'E-Mail Pembeli',pembayaran.total_bayar AS 'Total Yang Dibayarkan' FROM " + tabel + " WHERE " + kondisi;
                }
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, tabel);
            }
            catch (SqlException)
            {
                ds = null;
            }
            connector.Close();
            return ds;
        }
    }
}

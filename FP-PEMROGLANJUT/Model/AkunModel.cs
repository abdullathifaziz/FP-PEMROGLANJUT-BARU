using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace FP_PEMROGLANJUT.Model
{
    class AkunModel
    {
        DBConnector temp;

        public string usrname { get; set; }
        public string passwd { get; set; }
        public string nama_depan { get; set; }
        public string nama_belakang { get; set; }
        public string email_akun { get; set; }
        public int no_telp { get; set; }

        public AkunModel()
        {
            temp = new DBConnector();
        }

        public bool CekLogin()
        {
            bool result = false;
            DataSet ds = new DataSet();
            ds = temp.Select("akun", "usrname = '" + usrname + "' AND passwd = '" + passwd + "'");
            if(ds.Tables[0].Rows.Count > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public bool InsertAkun()
        {
            string data = "'" + usrname + "','" + passwd + "','" + nama_depan + "','" + nama_belakang + "'";
            return temp.Insert("akun (usrname,passwd,nama_depan,nama_belakang)", data);
        }

        public string CekNamaDepan(string username)
        {
            string result;
            DataSet dsnamadepan = new DataSet();
            dsnamadepan = temp.QueryManual("SELECT nama_depan FROM akun WHERE usrname = '"+ username +"'","akun");
            result = dsnamadepan.Tables[0].Rows[0][0].ToString();
            return result;
        }

        public string CekNamaBelakang(string username)
        {
            string result;
            DataSet dsnamabelakang = new DataSet();
            dsnamabelakang = temp.QueryManual("SELECT nama_belakang FROM akun WHERE usrname = '" + username + "'", "akun");
            result = dsnamabelakang.Tables[0].Rows[0][0].ToString();
            return result;
        }

        public bool UbahUser(string baru, string lama)
        {
            bool result = false;
            result = temp.Update("akun", "usrname = '" + baru + "'", "usrname = '" + lama + "'");
            return result;
        }

        public bool UbahPass(string baru, string lama)
        {
            bool result = false;
            result = temp.Update("akun", "passwd = '" + baru + "'", "passwd = '" + lama + "'");
            return result;
        }

        public string[] getDetail(string username)
        {
            string[] accountDetail = { "", "", "" };
            try
            {
                accountDetail[0] = temp.Select("akun", "usrname='" + username + "'").Tables[0].Rows[0]["nama_depan"].ToString();
                accountDetail[0] += " " + temp.Select("akun", "usrname='" + username + "'").Tables[0].Rows[0]["nama_belakang"].ToString();
                accountDetail[1] = temp.Select("akun", "usrname='" + username + "'").Tables[0].Rows[0]["usrname"].ToString();
                accountDetail[2] = temp.Select("akun", "usrname='" + username + "'").Tables[0].Rows[0]["passwd"].ToString();
                
            }
            catch (Exception e)
            {
                accountDetail[0] = "";
                MessageBox.Show(username);
                MessageBox.Show(e.Message);
            }

            return accountDetail;
        }
    }
}

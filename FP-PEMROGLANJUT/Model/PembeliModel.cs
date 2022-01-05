using System;
using System.Collections.Generic;
using System.Text;

namespace FP_PEMROGLANJUT.Model
{
    class PembeliModel
    {
        DBConnector temp;

        public int id_pembeli { get; set; }
        public int nomor_pembeli { get; set; }
        public string userid_pembeli { get; set; }
        public string email { get; set; }

        public PembeliModel()
        {
            temp = new DBConnector();
        }
    }
}

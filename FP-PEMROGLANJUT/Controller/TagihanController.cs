using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FP_PEMROGLANJUT.Controller
{
    class TagihanController
    {
        Model.TagihanModel tagihan;

        View.PascabayarPage kartu;
        View.PascabayarPLNPage pln;

        View.CekTagihanPascabayarPage cekkartu;
        View.CekTagihanPascabayarPLNPage cekpln;

        public TagihanController(View.PascabayarPage kartu)
        {
            tagihan = new Model.TagihanModel();
            this.kartu = kartu;
        }

        public TagihanController(View.PascabayarPLNPage pln)
        {
            tagihan = new Model.TagihanModel();
            this.pln = pln;
        }

        public TagihanController(View.CekTagihanPascabayarPage cekkartu)
        {
            tagihan = new Model.TagihanModel();
            this.cekkartu = cekkartu;
        }

        public TagihanController(View.CekTagihanPascabayarPLNPage cekpln)
        {
            tagihan = new Model.TagihanModel();
            this.cekpln = cekpln;
        }

        public void CekNomor(string nomorpelanggan)
        {
            //tagihan.id_tagihan = nomorpelanggan;
            //tagihan.periode = tagihan.Periode(tagihan.id_tagihan);
            //tagihan.total_tagihan = Int32.Parse(tagihan.TotalTagihan(tagihan.id_tagihan));
        }

    }
}

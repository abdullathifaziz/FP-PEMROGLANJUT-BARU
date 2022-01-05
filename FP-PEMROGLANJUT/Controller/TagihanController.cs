using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FP_PEMROGLANJUT.Controller
{
    class TagihanController
    {
        Model.TagihanModel tagihan;
        View.PascabayarPage pascabayarkartu;
        View.CekTagihanPascabayarPage cekkartu;

        public TagihanController(View.PascabayarPage pascabayarkartu)
        {
            tagihan = new Model.TagihanModel();
            this.pascabayarkartu = pascabayarkartu;
        }

        public TagihanController(View.CekTagihanPascabayarPage cekkartu)
        {
            tagihan = new Model.TagihanModel();
            this.cekkartu = cekkartu;
        }

        public void CekNomor()
        {
            tagihan.id_tagihan = pascabayarkartu.txtNomorKartu.Text;
            tagihan.periode = tagihan.Periode(tagihan.id_tagihan);
            tagihan.total_tagihan = Int32.Parse(tagihan.TotalTagihan(tagihan.id_tagihan));

            cekkartu.lblNomorKartu.Content = Model.TagihanModel.tagihanSelector;
            cekkartu.lblPeriodeKartu.Content = tagihan.periode;
            cekkartu.lblTotalKartu.Content = "Rp" + tagihan.total_tagihan;
        }


    }
}

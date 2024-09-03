using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        app_code.DataSetTableAdapters.TBLEGITIMTableAdapter dt = new app_code.DataSetTableAdapters.TBLEGITIMTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != true)
            {
                int id = Convert.ToInt16(Request.QueryString["id"]);
                TxtID.Text = id.ToString();
                TxtBaslik.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].BASLIK;
                TxtAltBaslik.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].ALTBASLIK;
                TxtAcıklama.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].ACIKLAMA;
                TxtGNot.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].GNOT;
                TxtTarih.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].TARIH;
            }

        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            dt.EgitimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAcıklama.Text, TxtGNot.Text, TxtTarih.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("Adminegitimler.aspx");
            MessageBox.Show("Eğitim Başarıyla Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
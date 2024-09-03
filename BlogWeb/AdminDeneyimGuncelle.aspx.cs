using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        app_code.DataSetTableAdapters.TBLDENEYIMTableAdapter dt = new app_code.DataSetTableAdapters.TBLDENEYIMTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            TxtID.Text = id.ToString();

            if (Page.IsPostBack != true)
            {
                TxtBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].BASLIK;
                TxtAltBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].ALTBASLIK;
                TxtAcıklama.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].ACIKLAMA;
                TxtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].TARIH;
            }

        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            dt.DeneyimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAcıklama.Text, TxtTarih.Text, Convert.ToInt16(id));
            MessageBox.Show(id + ". Deneyim Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}
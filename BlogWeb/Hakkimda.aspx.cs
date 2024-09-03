using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        app_code.DataSetTableAdapters.TBLHAKKIMDATableAdapter dt = new app_code.DataSetTableAdapters.TBLHAKKIMDATableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {

            // int id = Convert.ToInt32(Request.QueryString["ID"]);
            if (Page.IsPostBack != true)
            {
                TxtAd.Text = dt.HakkimdaListele()[0].AD;
                TxtSoyad.Text = dt.HakkimdaListele()[0].SOYAD;
                TxtAdres.Text = dt.HakkimdaListele()[0].ADRES;
                TxtMail.Text = dt.HakkimdaListele()[0].MAIL;
                TxtTelefon.Text = dt.HakkimdaListele()[0].TELEFON;
                TxtKisaNot.Text = dt.HakkimdaListele()[0].KISANOT;
                TxtFotograf.Text = dt.HakkimdaListele()[0].FOTOGRAF;
            }
        

        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            dt.HakkimdaGuncelle(TxtAd.Text, TxtSoyad.Text, TxtAdres.Text, TxtMail.Text, TxtTelefon.Text, TxtKisaNot.Text, TxtFotograf.Text);
            MessageBox.Show("Bilgileriniz Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Response.Redirect("Default.Aspx");
        }
    }
}
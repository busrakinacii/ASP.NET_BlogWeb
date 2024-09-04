using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        app_code.DataSetTableAdapters.TBLYETENEKLERTableAdapter dt = new app_code.DataSetTableAdapters.TBLYETENEKLERTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != true)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                TxtID.Text = id.ToString();

                TxtYetenek.Text = dt.YetenekGetir(Convert.ToInt16(id))[0].YETENEK;
            }


        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            dt.YetenekGuncelle(TxtYetenek.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("YetenekListesi.aspx");
            MessageBox.Show("Kaydınız Başarıyla GÜncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
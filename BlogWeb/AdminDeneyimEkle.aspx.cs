using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb
{
    public partial class AdminDeneyimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      
        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            app_code.DataSetTableAdapters.TBLDENEYIMTableAdapter dt = new app_code.DataSetTableAdapters.TBLDENEYIMTableAdapter();
            dt.DeneyimEkle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAcıklama.Text, TxtTarih.Text);
            Response.Redirect("AdminDeneyimler.aspx");
            MessageBox.Show("Deneyim Başarıyla Eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
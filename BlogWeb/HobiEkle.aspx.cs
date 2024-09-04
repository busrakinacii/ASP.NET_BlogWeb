using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb
{
    public partial class HobiEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            app_code.DataSetTableAdapters.TBLHOBILERTableAdapter dt = new app_code.DataSetTableAdapters.TBLHOBILERTableAdapter();
            dt.HobiEkle(TxtHobi.Text);
            Response.Redirect("HobiListesi.aspx");
            MessageBox.Show("Kayıt Başarıyla Listeye Eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
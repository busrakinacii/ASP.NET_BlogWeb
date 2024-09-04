using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb
{
    public partial class YetenekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            app_code.DataSetTableAdapters.TBLYETENEKLERTableAdapter dt = new app_code.DataSetTableAdapters.TBLYETENEKLERTableAdapter();
            dt.YetenekEkle(TxtYetenek.Text);
            Response.Redirect("YetenekListesi.aspx");
            MessageBox.Show("Yetenek Başarıyla Listeye Eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
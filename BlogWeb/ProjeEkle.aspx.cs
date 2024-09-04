using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class ProjeEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            app_code.DataSetTableAdapters.TBLPROJELERTableAdapter dt = new app_code.DataSetTableAdapters.TBLPROJELERTableAdapter();
            dt.ProjeEkle(TxtProje.Text);
            Response.Redirect("ProjeListesi.aspx");

        }
    }
}
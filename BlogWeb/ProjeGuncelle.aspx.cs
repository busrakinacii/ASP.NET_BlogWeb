using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class ProjeGuncelle : System.Web.UI.Page
    {
        app_code.DataSetTableAdapters.TBLPROJELERTableAdapter dt = new app_code.DataSetTableAdapters.TBLPROJELERTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != true)
            {
                int id = Convert.ToInt16(Request.QueryString["id"]);
                TxtID.Text = id.ToString();
                TxtProje.Text = dt.ProjeGetir(Convert.ToInt16(id))[0].PROJELER;

            }

        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            dt.ProjeGuncelle(TxtProje.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("ProjeListesi.aspx");
        }
    }
}
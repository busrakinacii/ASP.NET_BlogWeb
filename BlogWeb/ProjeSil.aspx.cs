using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class ProjeSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["id"]);
            app_code.DataSetTableAdapters.TBLPROJELERTableAdapter dt = new app_code.DataSetTableAdapters.TBLPROJELERTableAdapter();
            dt.ProjeSil(Convert.ToInt16(id));
            Response.Redirect("ProjeListesi.aspx");
        }
    }
}
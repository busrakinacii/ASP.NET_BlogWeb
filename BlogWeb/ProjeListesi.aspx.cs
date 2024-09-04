using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class ProjeListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            app_code.DataSetTableAdapters.TBLPROJELERTableAdapter dt = new app_code.DataSetTableAdapters.TBLPROJELERTableAdapter();
            Repeater1.DataSource = dt.ProjeListele();
            Repeater1.DataBind();
        }
    }
}
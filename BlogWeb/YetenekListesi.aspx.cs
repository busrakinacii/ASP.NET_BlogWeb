using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class YetenekListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            app_code.DataSetTableAdapters.TBLYETENEKLERTableAdapter dt = new app_code.DataSetTableAdapters.TBLYETENEKLERTableAdapter();
            Repeater1.DataSource = dt.YetenekListele();
            Repeater1.DataBind();
        }
    }
}
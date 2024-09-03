using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            app_code.DataSetTableAdapters.TBLEGITIMTableAdapter dt = new app_code.DataSetTableAdapters.TBLEGITIMTableAdapter();
            Repeater1.DataSource=dt.EgitimListesi();
            Repeater1.DataBind();
      

        }
    }
}
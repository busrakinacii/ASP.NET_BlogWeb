using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            app_code.DataSetTableAdapters.TBLDENEYIMTableAdapter dt = new app_code.DataSetTableAdapters.TBLDENEYIMTableAdapter();
            Repeater1.DataSource = dt.DeneyimListele();
            Repeater1.DataBind();
        }
    }
}
using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb
{
    public partial class AdminDeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            app_code.DataSetTableAdapters.TBLDENEYIMTableAdapter dt = new app_code.DataSetTableAdapters.TBLDENEYIMTableAdapter();
            dt.DeneyimSil(Convert.ToInt16(id));
            MessageBox.Show("Deneyim Başarıyla Silinmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}
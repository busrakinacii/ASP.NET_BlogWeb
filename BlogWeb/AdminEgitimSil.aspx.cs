using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb
{
    public partial class AdminEgitimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            app_code.DataSetTableAdapters.TBLEGITIMTableAdapter dt = new app_code.DataSetTableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimSil(Convert.ToInt16(id));
            Response.Redirect("AdminEgitimler.aspx");
            MessageBox.Show("Eğitim Listeden Silinmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Question);

        }
    }
}
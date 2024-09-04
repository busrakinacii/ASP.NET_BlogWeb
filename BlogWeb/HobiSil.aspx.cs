using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb
{
    public partial class HobiSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            app_code.DataSetTableAdapters.TBLHOBILERTableAdapter dt = new app_code.DataSetTableAdapters.TBLHOBILERTableAdapter();
            int id = Convert.ToInt16(Request.QueryString["id"]);
            dt.HobiSil(Convert.ToInt16(id));
            Response.Redirect("HobiListesi.aspx");
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Silinmiştir.", "Bİlgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
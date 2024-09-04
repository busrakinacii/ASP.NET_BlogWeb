using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            app_code.DataSetTableAdapters.TBLYETENEKLERTableAdapter dt = new app_code.DataSetTableAdapters.TBLYETENEKLERTableAdapter();

            int id = Convert.ToInt16(Request.QueryString["id"]);
            dt.YetenekSil(Convert.ToInt16(id));
            Response.Redirect("YetenekListesi.aspx");
            MessageBox.Show("Mesajınız Başarıyla Sİlinmiştir.", "Bİlgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
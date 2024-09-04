using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb
{
    public partial class HobiGuncelle : System.Web.UI.Page
    {
        app_code.DataSetTableAdapters.TBLHOBILERTableAdapter dt = new app_code.DataSetTableAdapters.TBLHOBILERTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != true)
            {
                int id = Convert.ToInt16(Request.QueryString["id"]);
                TxtID.Text = id.ToString();
                TxtHobi.Text = dt.HobiGetir(Convert.ToInt16(id))[0].HOBI;
            }


        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            dt.HobiGuncelle(TxtHobi.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("HobiListesi.aspx");
            MessageBox.Show("Kayıt Başarıyla Güncellenmiştir.", "Bİlgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
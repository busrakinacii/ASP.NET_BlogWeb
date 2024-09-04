using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            app_code.DataSetTableAdapters.TBLHAKKIMDATableAdapter dt = new app_code.DataSetTableAdapters.TBLHAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkimdaListele();
            Repeater1.DataBind();

            app_code.DataSetTableAdapters.TBLDENEYIMTableAdapter dt2 = new app_code.DataSetTableAdapters.TBLDENEYIMTableAdapter();
            Repeater2.DataSource = dt2.DeneyimListele();
            Repeater2.DataBind();

            app_code.DataSetTableAdapters.TBLEGITIMTableAdapter dt3 = new app_code.DataSetTableAdapters.TBLEGITIMTableAdapter();
            Repeater3.DataSource = dt3.EgitimListesi();
            Repeater3.DataBind();

            app_code.DataSetTableAdapters.TBLYETENEKLERTableAdapter dt4 = new app_code.DataSetTableAdapters.TBLYETENEKLERTableAdapter();
            Repeater4.DataSource = dt4.YetenekListele();
            Repeater4.DataBind();


            app_code.DataSetTableAdapters.TBLHOBILERTableAdapter dt5 = new app_code.DataSetTableAdapters.TBLHOBILERTableAdapter();
            Repeater5.DataSource = dt5.HobiListele();
            Repeater5.DataBind();


            app_code.DataSetTableAdapters.TBLPROJELERTableAdapter dt6 = new app_code.DataSetTableAdapters.TBLPROJELERTableAdapter();
            Repeater6.DataSource = dt6.ProjeListele();
            Repeater6.DataBind();

            app_code.DataSetTableAdapters.TBLHAKKIMDATableAdapter dt7 = new app_code.DataSetTableAdapters.TBLHAKKIMDATableAdapter();
            Repeater7.DataSource = dt7.HakkimdaListele();
            Repeater7.DataBind();
        }
    }
}
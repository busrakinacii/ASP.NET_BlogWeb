using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BlogWeb.Login
{
    public partial class GirisYap : System.Web.UI.Page
    {
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-QUL77PV\SQLEXPRESS;Initial Catalog=BlogWebDB;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLADMIN where KullaniciAdi=@p1 and Sifre=@p2", bgl);
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("~/AdminDeneyimler.aspx");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalıdır.\n Lütfen Kontrol Ediniz.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.Close();
        }
    }
}
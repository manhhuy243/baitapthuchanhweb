using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQuanLyNV
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GHQ5FL8\SQLEXPRESS;Initial Catalog=QuanLyNV;Integrated Security=True");
            string sqlQuery = @"INSERT INTO QuanLyNV.dbo.NhanVien([Họ và Tên], [Ngày sinh], [Số điện thoại cá nhân],[mat khau],[Email cá nhân]) VALUES ('" + txtTen.Text+"','"+txtNgaySinh.Text+"','"+txtSDT.Text+"','"+txtMatKhau.Text+"','"+txtEmail.Text+"')";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("WebForm3.aspx");
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
            txtNgaySinh.Text = "";
            txtSDT.Text = "";
            txtTen.Text = "";
            txtEmail.Text = "";
            Response.Redirect("WebForm3.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQuanLyNV
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        string ten,sdt,ngaysinh,matkhau,email;

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
            txtNgaySinh.Text = "";
            txtSDT.Text = "";
            txtTen.Text = "";
            Response.Redirect("WebForm3.aspx");
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GHQ5FL8\SQLEXPRESS;Initial Catalog=QuanLyNV;Integrated Security=True");
            string sqlQuery = @"update QuanLyNV.dbo.NhanVien set [Họ và Tên]='"+txtTen.Text+"',[Số điện thoại cá nhân]='"+txtSDT.Text+"',[mat khau]='"+txtMatKhau.Text+"',[Ngày sinh]='"+txtNgaySinh.Text+"' where [Email cá nhân] = '" + WebForm3.email + "' and [STT] = '" + WebForm3.stt + "'";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery(); 
            conn.Close();
            Response.Redirect("WebForm3.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_duLieu();
                txtTen.Text = ten;
                txtSDT.Text = sdt;
                txtNgaySinh.Text = ngaysinh;
                txtMatKhau.Text = matkhau;
                lblEmail.Text = email;
            }

        }
        public void load_duLieu()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GHQ5FL8\SQLEXPRESS;Initial Catalog=QuanLyNV;Integrated Security=True");
            string sqlQuery = @"select * from QuanLyNV.dbo.NhanVien where [Email cá nhân] = '" + WebForm3.email + "' and [STT] = '" + WebForm3.stt + "'";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ten = dr[1].ToString();
                sdt = dr[25].ToString();
                ngaysinh = dr[6].ToString();
                matkhau = dr[41].ToString();
                email = dr[29].ToString();
                conn.Close();
            }
            conn.Close();
        }
    }
}
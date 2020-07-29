using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace WebQuanLyNV
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GHQ5FL8\SQLEXPRESS;Initial Catalog=QuanLyNV;Integrated Security=True");

        public int Dem=0;

        public static string TK_Login = string.Empty;
        public static string MK_Login = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Dem > 0)
            {
                TxtEmail.Text = "";
                TextPass.Text = "";
            }
        }

        protected void Buttom_Login_Click(object sender, EventArgs e)
        {
            

            try
            {
                conn.Open();
                string email = TxtEmail.Text;
                string pass = TextPass.Text;
                string sqlQuery = "select * from QuanLyNV.dbo.NhanVien where [Email cá nhân] ='" + email + "'"+" and [mat khau]='"+pass+"'";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    
                    conn.Close();
                    sqlQuery = "select * from QuanLyNV.dbo.NhanVien where [Email cá nhân] ='" + email + "'" + " and [mat khau]='" + pass + "'" + " and [loai Tai Khoan] = 'AdminWeb'";
                    conn.Open();
                    cmd = new SqlCommand(sqlQuery, conn);
                    dta = cmd.ExecuteReader();
                    if (dta.Read()==true)
                    {
                        conn.Close();
                        TK_Login = email;
                        MK_Login = pass;
                        Response.Redirect("WebForm3.aspx");
                        Dem++;
                    }
                    else
                    {
                        TK_Login = email;
                        MK_Login = pass;
                        Response.Redirect("WebForm2.aspx");
                        conn.Close();
                        Dem++;
                    }
                              
                }
                else {
                    lblErrorMessage.Text = "loi tai khoan hoac mat khau";
                    conn.Close();
                }
              
            }
            catch(Exception ex)
            {
                lblErrorMessage.Text = "loi dang nhap";
                conn.Close();
            }
        }
        
    }
}
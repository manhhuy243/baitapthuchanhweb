using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace WebQuanLyNV
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string TenNV;
        string emailNguoiGui;

        protected void Page_Load(object sender, EventArgs e)
        {
            grNV.DataSource= GetNV() ;
            grNV.DataBind();
            //txtTongSoNgayNghi.Text = grNV.SelectedRow.Cells[29].Text;
        }
        
        DataTable GetNV()
        {           
            WebForm1.TK_Login = "ads";
            WebForm1.MK_Login = "1";
            DataTable ta = new DataTable();
            //sqlconnection
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HLP3PO9;Initial Catalog=QuanLyNV;Integrated Security=True");
            string sqlQuery = "select * from QuanLyNV.dbo.NhanVien where [Email cá nhân] ='" + WebForm1.TK_Login + "'" + " and [mat khau]='" + WebForm1.MK_Login + "'";
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);
            adp.Fill(ta);
            if (ta.Rows.Count > 0)
            {
                emailNguoiGui = ta.Rows[0][29].ToString();
                TenNV = ta.Rows[0][1].ToString();
                txtTongSoNgayNghi.Text = ta.Rows[0][0].ToString();
            }
            else
            {
                txtTongSoNgayNghi.Text="0";
            }
            conn.Close();

            WebForm1.TK_Login = "";
            WebForm1.MK_Login = "";

            return ta;
        }

        protected void btnThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient();
            try
            {
                string TieuDe = "DON XIN NGHI PHEP";
                string NoiDung = "Toi ten: "+TenNV+" Guoi yeu cau nay de xin dc nghi phep "+ txtSoNgayNghiDuTinh.Text +" ngay, thoi gian bat dau tu nghi tu ngay: "+txtThoiGian.Text;
                string NguoiNhan = "huy.nguyen@diadiemanuong.com";
                //ĐỊA CHỈ SMTP Server
                smtp.Host = "smtp.gmail.com";
                //Cổng SMTP
                smtp.Port = 587;
                //SMTP yêu cầu mã hóa dữ liệu theo SSL
                smtp.EnableSsl = true;
                //UserName và Password của mail
                smtp.Credentials = new NetworkCredential("huy.chatv111@gmail.com", "huy1900561252");

                //Tham số lần lượt là địa chỉ người gửi, người nhận, tiêu đề và nội dung thư
                smtp.Send(emailNguoiGui, NguoiNhan, TieuDe, NoiDung);
                lblThongBao.Text = "yeu cau da duoc gui.";
            }
            catch (Exception ex)
            {
                lblThongBao.Text = ex.Message;
            }
        }
    }
}
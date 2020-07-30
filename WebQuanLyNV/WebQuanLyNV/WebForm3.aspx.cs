using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace WebQuanLyNV
{
    public partial class WebForm3 : System.Web.UI.Page
    {

        public static string email;
        public static string stt;
        protected void Page_Load(object sender, EventArgs e)
        {
                GridView1.DataSource = GetNV();
                GridView1.DataBind();
            
        }
        

        DataSet GetNV()
        {
            DataSet data = new DataSet();
            //sqlconnection
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GHQ5FL8\SQLEXPRESS;Initial Catalog=QuanLyNV;Integrated Security=True");
            string sqlQuery = "select * from QuanLyNV.dbo.NhanVien";
            
            SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);
            conn.Open();
            adp.Fill(data);
            conn.Close();

            WebForm1.TK_Login = "";
            WebForm1.MK_Login = "";

            return data;
        }

        protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "nha chuot phai de chon hang nay";
            }
        }

        protected void btnDeleted_Click(object sender, EventArgs e)
        {
            email= GridView1.SelectedRow.Cells[29].Text;
            stt = GridView1.SelectedRow.Cells[0].Text;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GHQ5FL8\SQLEXPRESS;Initial Catalog=QuanLyNV;Integrated Security=True");
            string sqlQuery = @"delete from QuanLyNV.dbo.NhanVien where [Email cá nhân] = '" + email + "' and [STT] = '"+ stt +"'";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect(Request.RawUrl);
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.SelectedRow.BackColor= ColorTranslator.FromHtml("#A1DCF2");

            //foreach (GridViewRow row in GridView1.Rows)
            //{
            //    if (row.RowIndex == GridView1.SelectedIndex)
            //    {
            //        row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
            //        row.ToolTip = string.Empty;
            //        break;
            //    }

            //}
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            email = GridView1.SelectedRow.Cells[29].Text;
            stt = GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect("WebForm4.aspx");
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm5.aspx");
        }
    }
}
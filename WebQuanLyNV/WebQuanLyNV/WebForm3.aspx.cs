using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebQuanLyNV
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grNV.DataSource = GetNV();
            grNV.DataBind();
        }
        DataSet GetNV()
        {
            DataSet data = new DataSet();
            //sqlconnection
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HLP3PO9;Initial Catalog=QuanLyNV;Integrated Security=True");
            string sqlQuery = "select * from QuanLyNV.dbo.NhanVien";
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);
            adp.Fill(data);
            conn.Close();

            WebForm1.TK_Login = "";
            WebForm1.MK_Login = "";

            return data;
        }

    }
}
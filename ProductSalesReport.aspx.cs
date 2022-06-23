using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WPL_Project
{
    public partial class ProductSalesReport : System.Web.UI.Page
    {

        public SqlConnection connect;
        public SqlCommand cmd;
        public SqlDataAdapter adp;
        public DataSet ds;

        public string query1;
        public string query2;
        public string conn = @"Data Source=DESKTOP-MOJ25U3\SQLEXPRESS;Initial Catalog=db_ppil;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(conn);
        }

        protected void btnShowTypeReport_Click(object sender, EventArgs e)
        {
            connect.Open();
            string _TypeReport = dpTypeReport.SelectedItem.Text;
            query1 = "SELECT * FROM tbl_Sales WHERE ProductType='" + _TypeReport + "'";
            adp = new SqlDataAdapter(query1, connect);
            ds = new DataSet();
            adp.Fill(ds);
            dgvReport.DataSource = ds;
            dgvReport.DataBind();
            dpTypeReport.SelectedIndex = 0;
            connect.Close();
        }

        protected void btnResetTypeReport_Click(object sender, EventArgs e)
        {
            dpTypeReport.SelectedIndex = 0;
            ds = null;
            dgvReport.DataSource = ds;
            dgvReport.DataBind();
        }

        protected void btnShowSalesReport_Click(object sender, EventArgs e)
        {
            connect.Open();
            query1 = "SELECT * FROM tbl_Sales";
            adp = new SqlDataAdapter(query1, connect);
            ds = new DataSet();
            adp.Fill(ds);
            dgvReport.DataSource = ds;
            dgvReport.DataBind();
            connect.Close();
        }

        protected void btnResetSalesReport_Click(object sender, EventArgs e)
        {
            ds = null;
            dgvReport.DataSource = ds;
            dgvReport.DataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminWorks.aspx");
        }
    }
}
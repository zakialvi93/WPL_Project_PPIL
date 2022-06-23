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

    public partial class LoginPage : System.Web.UI.Page
    {
        public SqlConnection connect;
        public SqlCommand cmd;
        public SqlDataAdapter adp;
        public DataSet ds;

        public string query;
        public string conn = @"Data Source=DESKTOP-MOJ25U3\SQLEXPRESS;Initial Catalog=db_ppil;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(conn);
        }

        protected void btnAdminLogin_Click(object sender, EventArgs e)
        {
            int _AdminID = Convert.ToInt32(txtAdminID.Text);
            string _AdminPassword = txtAdminPassword.Text;
            

            if (_AdminID == 15713 && _AdminPassword=="Zaki")
            {
                Session["AdminName"] = _AdminPassword;
                Session["AdminID"] = _AdminID;
                Response.Redirect("AdminWorks.aspx");
                txtAdminID.Text = "";
                txtAdminPassword.Text = "";
            }

            else 
            {
                
                Response.Write("<script>alert('Invalid Login')</script>");
                txtAdminID.Text = "";
                txtAdminPassword.Text = "";
            }

        }

        protected void btnAdminReset_Click(object sender, EventArgs e)
        {
            txtAdminID.Text = "";
            txtAdminPassword.Text = "";
        }

        protected void btnSellerLogin_Click(object sender, EventArgs e)
        {
            connect.Open();
            int _SellerID = Convert.ToInt32(txtSellerID.Text);
            string _SellerPassword = txtSellerPassword.Text;
            query = "SELECT count(*) FROM tbl_Users WHERE UserID="+_SellerID+" AND Password='"+_SellerPassword+"'";
            cmd = new SqlCommand(query, connect);
            int _count = Convert.ToInt32(cmd.ExecuteScalar());
            if (_count == 1)
            {
                Session["SellerID"] = _SellerID;
                Response.Redirect("SalesPage.aspx");
                txtSellerID.Text = "";
                txtSellerPassword.Text = "";
            }
            else 
            {
                Response.Write("<script>alert('Invalid login')</script>");
                txtSellerID.Text = "";
                txtSellerPassword.Text = "";
            }
            connect.Close();
        }

        protected void btnSellerReset_Click(object sender, EventArgs e)
        {
            txtSellerID.Text = "";
            txtSellerPassword.Text = "";
        }
    }
}
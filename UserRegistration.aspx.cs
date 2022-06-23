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
    public partial class UserRegistration : System.Web.UI.Page
    {
        public SqlConnection connect;
        public SqlCommand cmd1;
        public SqlCommand cmd2;
        public SqlDataAdapter adp;
        public DataSet ds;

        public string query1;
        public string query2;
        public string conn = @"Data Source=DESKTOP-MOJ25U3\SQLEXPRESS;Initial Catalog=db_ppil;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(conn);
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            connect.Open();
            int _RegisteredID = Convert.ToInt32(txtUserID.Text);
            string _RegisteredPassword = txtUserPassword.Text;
            query1 = "SELECT count(*) FROM tbl_Users WHERE UserID=" + _RegisteredID + "";
            cmd1 = new SqlCommand(query1, connect);
            int _count = Convert.ToInt32(cmd1.ExecuteScalar());

            if (_count == 1 || _RegisteredID==15713)
            {
                Response.Write("<script>alert('This ID already exists')</script>");
                txtUserID.Text = "";
                txtUserPassword.Text = "";
            }
            else
            {
                query2 = "INSERT INTO tbl_Users VALUES(" + _RegisteredID + ",'" + _RegisteredPassword + "')";
                cmd2 = new SqlCommand(query2, connect);
                cmd2.ExecuteNonQuery();
                Response.Write("<script>alert('User Registered Successfully')</script>");
                txtUserID.Text = "";
                txtUserPassword.Text = "";
            }
            connect.Close();
        }

        protected void btnRegisterRest_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtUserPassword.Text = "";
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminWorks.aspx");
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            connect.Open();
            int _RegisteredID = Convert.ToInt32(txtUserID.Text);
            query1 = "SELECT count(*) FROM tbl_Users WHERE UserID="+_RegisteredID+"";
            cmd1 = new SqlCommand(query1,connect);
            int _count = Convert.ToInt32(cmd1.ExecuteScalar());
            if (_count == 1)
            {
                query2 = "DELETE FROM tbl_Users WHERE UserID=" + _RegisteredID + "";
                cmd2 = new SqlCommand(query2, connect);
                cmd2.ExecuteNonQuery();
                Response.Write("<script>alert('User Deleted Successfully')</script>");
                txtUserID.Text = "";
                
            }

            else 
            {
                Response.Write("<script>alert('This user does not exist')</script>");
                txtUserID.Text = "";
                
            }

            connect.Close();
        }
    }
}
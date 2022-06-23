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
    public partial class ProductRegistration : System.Web.UI.Page
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

        protected void btnProductReset_Click(object sender, EventArgs e)
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            dpProductType.SelectedIndex = 0;
            txtProductDescription.Text = "";
            txtProductPrice.Text = "";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            connect.Open();
            int _ProductID = Convert.ToInt32(txtProductID.Text);
            string _ProductName = txtProductName.Text;
            string _ProductType = dpProductType.SelectedItem.Text;
            string _ProductDescription = txtProductDescription.Text;
            int _ProductPrice = Convert.ToInt32(txtProductPrice.Text);
            query1 = "SELECT count(*) FROM tbl_Products WHERE ProductID="+_ProductID+"";
            cmd1 = new SqlCommand(query1, connect);
            int _count = Convert.ToInt32(cmd1.ExecuteScalar());
            if (_count == 1)
            {
                Response.Write("<script>alert('This ID already exists')</script>");
                txtProductID.Text = "";
                txtProductName.Text = "";
                dpProductType.SelectedIndex = 0;
                txtProductDescription.Text = "";
                txtProductPrice.Text = "";

            }
            else
            {
                query2 = "INSERT INTO tbl_Products VALUES(" + _ProductID + ",'" + _ProductName + "','" + _ProductType + "','" + _ProductDescription + "'," + _ProductPrice + ")";
                cmd2 = new SqlCommand(query2, connect);
                cmd2.ExecuteNonQuery();
                Response.Write("<script>alert('Product Registered Successfully')</script>");
                txtProductID.Text = "";
                txtProductName.Text = "";
                dpProductType.SelectedIndex = 0;
                txtProductDescription.Text = "";
                txtProductPrice.Text = "";
            }

            connect.Close();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            int _ProductID = Convert.ToInt32(txtProductID.Text);
            string _ProductName = txtProductName.Text;
            string _ProductType = dpProductType.SelectedItem.Text;
            string _ProductDescription = txtProductDescription.Text;
            int _ProductPrice = Convert.ToInt32(txtProductPrice.Text);
            query1 = "SELECT count(*) FROM tbl_Products WHERE ProductID="+_ProductID+"";
            cmd1 = new SqlCommand(query1, connect);
            int _count = Convert.ToInt32(cmd1.ExecuteScalar());
            if (_count == 1)
            {
                query2 = "UPDATE tbl_Products SET ProductName='" + _ProductName + "',ProductType='" + _ProductType + "',ProductDescription='" + _ProductDescription + "',Price=" + _ProductPrice + " WHERE ProductID=" + _ProductID + "";
                cmd2 = new SqlCommand(query2, connect);
                cmd2.ExecuteNonQuery();
                Response.Write("<script>alert('Product Updated Successfully')</script>");
                txtProductID.Text = "";
                txtProductName.Text = "";
                dpProductType.SelectedIndex = 0;
                txtProductDescription.Text = "";
                txtProductPrice.Text = "";
            }
            else 
            {
                Response.Write("<script>alert('This Product does not exist')</script>");
                txtProductID.Text = "";
                txtProductName.Text = "";
                dpProductType.SelectedIndex = 0;
                txtProductDescription.Text = "";
                txtProductPrice.Text = "";
            }



            connect.Close();
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            connect.Open();
            int _ProductID = Convert.ToInt32(txtProductID.Text);
            query1 = "SELECT count(*) FROM tbl_Products WHERE ProductID=" + _ProductID + "";
            cmd1 = new SqlCommand(query1, connect);
            int _count = Convert.ToInt32(cmd1.ExecuteScalar());
            if (_count == 1)
            {
                query2 = "DELETE FROM tbl_Products WHERE ProductID=" + _ProductID + "";
                cmd2 = new SqlCommand(query2, connect);
                cmd2.ExecuteNonQuery();
                Response.Write("<script>alert('Product Deleted Successfully')</script>");
                txtProductID.Text = "";
            }

            else 
            {
                Response.Write("<script>alert('This Product does not exist')</script>");
                txtProductID.Text = "";
            }
            connect.Close();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminWorks.aspx");
        }
    }
}
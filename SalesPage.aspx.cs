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
    public partial class SalesPage : System.Web.UI.Page
    {
        public int _SalesPersonID;
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

            if (Session["Admin"] != null)
            {
                _SalesPersonID = Convert.ToInt32(Session["Admin"].ToString());
                
                btnBack.Visible = true;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                
            }
           else if (Session["SellerID"] != null)
            {
                _SalesPersonID = Convert.ToInt32(Session["SellerID"].ToString());
                
                btnSellerLogout.Visible = true;
            }
            
        }

        

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Session.Remove("Admin");
            Response.Redirect("AdminWorks.aspx");
        }

        protected void btnSellerLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("SellerID");
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnResetID_Click(object sender, EventArgs e)
        {
            txtSearchID.Text = "";
            ds = null;
            dgvSearch.DataSource = ds;
            dgvSearch.DataBind();
        }

        protected void btnResetType_Click(object sender, EventArgs e)
        {
            dpSearchProductType.SelectedIndex = 0;
            ds = null;
            dgvSearch.DataSource = ds;
            dgvSearch.DataBind();
        }

        protected void btnResetName_Click(object sender, EventArgs e)
        {
            txtSearchName.Text = "";
            ds = null;
            dgvSearch.DataSource = ds;
            dgvSearch.DataBind();
        }

        protected void btnSearchID_Click(object sender, EventArgs e)
        {
            connect.Open();

            int _SearchID = Convert.ToInt32(txtSearchID.Text);
            
            
                query2 = "SELECT * FROM tbl_Products WHERE ProductID=" + _SearchID + "";
                adp = new SqlDataAdapter(query2, connect);
                ds = new DataSet();
                adp.Fill(ds);
                dgvSearch.DataSource = ds;
                dgvSearch.DataBind();
                txtSearchID.Text = "";
            

            connect.Close();
            
            
        }

        protected void btnSearchType_Click(object sender, EventArgs e)
        {
            connect.Open();
            string _SearchType = dpSearchProductType.SelectedItem.Text;
            
                query2 = "SELECT * FROM tbl_Products WHERE ProductType='"+_SearchType+"'";
                adp = new SqlDataAdapter(query2, connect);
                ds = new DataSet();
                adp.Fill(ds);
                dgvSearch.DataSource = ds;
                dgvSearch.DataBind();
                dpSearchProductType.SelectedIndex = 0;
            
        }

        protected void btnSearchName_Click(object sender, EventArgs e)
        {
            connect.Open();
            string _SearchName = txtSearchName.Text;
            
                query2 = "SELECT * FROM tbl_Products WHERE ProductName='" + _SearchName + "'";
                adp = new SqlDataAdapter(query2, connect);
                ds = new DataSet();
                adp.Fill(ds);
                dgvSearch.DataSource = ds;
                dgvSearch.DataBind();
                txtSearchName.Text = "";
            
            connect.Close();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            connect.Open();
            int _SellerID = _SalesPersonID;
            int _ProductID = Convert.ToInt32(txtProductID.Text);
            string _ProductName = txtProductName.Text;
            string _ProductType = dpProductType.SelectedItem.Text;
            int _ProductRate = Convert.ToInt32(txtProductRate.Text);
            int _ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
            int _TotalPrice = _ProductRate * _ProductQuantity;
            lblBill.Text = _TotalPrice.ToString();
            query1 = "SELECT count(*) FROM tbl_Sales WHERE ProductID="+_ProductID+"";
            cmd = new SqlCommand(query1, connect);
            int _count = Convert.ToInt32(cmd.ExecuteScalar());
            if (_count == 1)
            {
                Response.Write("<script>alert('Record with this product ID is already present')</script>");
                txtProductID.Text = "";
                txtProductName.Text = "";
                dpProductType.SelectedIndex = 0;
                txtProductRate.Text = "";
                txtProductQuantity.Text = "";
                lblBill.Text = "";
            }
            else 
            {
                query2 = "INSERT INTO tbl_Sales VALUES("+_SellerID+","+_ProductID+",'"+_ProductName+"','"+_ProductType+"',"+_ProductRate+","+_ProductQuantity+","+_TotalPrice+")";
                cmd = new SqlCommand(query2, connect);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Inserted Successfully')</script>");
                

            }
            connect.Close();

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            dpProductType.SelectedIndex = 0;
            txtProductRate.Text = "";
            txtProductQuantity.Text = "";
            lblBill.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            int _SellerID = _SalesPersonID;
            int _ProductID = Convert.ToInt32(txtProductID.Text);
            string _ProductName = txtProductName.Text;
            string _ProductType = dpProductType.SelectedItem.Text;
            int _ProductRate = Convert.ToInt32(txtProductRate.Text);
            int _ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
            int _TotalPrice = _ProductRate * _ProductQuantity;
            lblBill.Text = _TotalPrice.ToString();
            query1 = "SELECT count(*) FROM tbl_Sales WHERE ProductID=" + _ProductID + "";
            cmd = new SqlCommand(query1, connect);
            int _count = Convert.ToInt32(cmd.ExecuteScalar());
            if (_count == 1)
            {
                query2 = "UPDATE tbl_Sales SET SellerID="+_SellerID+", ProductName='" + _ProductName + "', ProductType='" + _ProductType + "', ProductRate=" + _ProductRate + ", ProductQuantity=" + _ProductQuantity + ", TotalPrice=" + _TotalPrice + " WHERE ProductID="+_ProductID+"";
                cmd = new SqlCommand(query2, connect);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Updated Successfully')</script>");
            }
            else
            {
                Response.Write("<script>alert('There is no product with this ID')</script>");
                txtProductID.Text = "";
                txtProductName.Text = "";
                dpProductType.SelectedIndex = 0;
                txtProductRate.Text = "";
                txtProductQuantity.Text = "";
                lblBill.Text = "";

            }
            connect.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            connect.Open();
            int _ProductID = Convert.ToInt32(txtProductID.Text);
            query1 = "SELECT count(*) FROM tbl_Sales WHERE ProductID="+_ProductID+"";
            cmd = new SqlCommand(query1, connect);
            int _count = Convert.ToInt32(cmd.ExecuteScalar());
            if (_count == 1)
            {
                query2 = "DELETE FROM tbl_Sales WHERE ProductID="+_ProductID+"";
                cmd = new SqlCommand(query2, connect);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Deleted Successfully')</script>");
                txtProductID.Text = "";
                
            }
            else 
            {
                Response.Write("<script>alert('There is no product with this ID')</script>");
                txtProductID.Text = "";
                
            }
            connect.Close();
        }

        
    }
}
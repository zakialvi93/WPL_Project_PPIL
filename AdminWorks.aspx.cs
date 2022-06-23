using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WPL_Project
{
    public partial class AdminWorks : System.Web.UI.Page
    {
        public int _ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminName"] != null && Session["AdminID"]!=null)
            {
                string _name = Session["AdminName"].ToString();
                 _ID = Convert.ToInt32( Session["AdminID"].ToString());
                


                lblName.Text = "Welcome " + _name + " :)";
            }

            else 
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void btnUserReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRegistration.aspx");
        }

        protected void btnProductReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductRegistration.aspx");
        }

        protected void btnProductSales_Click(object sender, EventArgs e)
        {
            Session["Admin"] = _ID;
            Response.Redirect("SalesPage.aspx");
        }

        protected void btnAdminLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("AdminName");
            Session.Remove("AdminID");
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnSalesReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductSalesReport.aspx");
        }
    }
}
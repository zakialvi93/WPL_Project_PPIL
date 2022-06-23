<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminWorks.aspx.cs" Inherits="WPL_Project.AdminWorks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PPIL- Adimin Works Page</title>
    <link href="StyleSheetProject.css" rel="stylesheet" />
    <style>
        #btnUserReg:hover, #btnProductReg:hover, #btnProductSales:hover, #btnAdminLogout:hover, #btnSalesReport:hover 
        {
            background-color:black;
            color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <br/>
            <br/>
            <h1><asp:Label ID="lblName" runat="server" /></h1>
            
            <hr/>
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            <asp:Table runat="server" CellSpacing="20">
                <asp:TableRow runat="server" >

                    <asp:TableCell runat="server">
                        For User Registration:
                    </asp:TableCell>

                    <asp:TableCell runat="server" >
                        <asp:Button ID="btnUserReg" runat="server" Text="Click Here" OnClick="btnUserReg_Click"  />
                    </asp:TableCell>

                </asp:TableRow>


                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        For Product Registration:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:Button ID="btnProductReg" runat="server" Text="Click Here" OnClick="btnProductReg_Click" />
                    </asp:TableCell>

                </asp:TableRow>


                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        For Product Sales:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:Button ID="btnProductSales" runat="server" Text="Click Here" OnClick="btnProductSales_Click" />
                    </asp:TableCell>

                </asp:TableRow>

                <asp:TableRow runat="server">

                    <asp:TableCell> 
                        For Product Sales Reports:
                    </asp:TableCell>

                    <asp:TableCell>
                        <asp:button ID="btnSalesReport" text="Click Here" runat="server" OnClick="btnSalesReport_Click"  />
                    </asp:TableCell>

                </asp:TableRow>
            </asp:Table>
            <br/>
            <br/><br/>
            <br/><br/>
            <br/>
            
            
            <asp:Button ID="btnAdminLogout" runat="server" Text="Logout" OnClick="btnAdminLogout_Click" style="margin-left:364px;" />
            
        </div>
    </form>
</body>
</html>

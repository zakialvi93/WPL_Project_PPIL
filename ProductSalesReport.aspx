<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductSalesReport.aspx.cs" Inherits="WPL_Project.ProductSalesReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PPIL- Product Sales Reports</title>
    <link href="StyleSheetProject.css" rel="stylesheet" />
    <style>
        #btnShowTypeReport:hover, #btnResetTypeReport:hover, #btnShowSalesReport:hover, #btnResetSalesReport:hover, #btnBack:hover 
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
            <h1>Product Sales Reports</h1>
            <hr/>
            <br/>
            <br/>
            <asp:Table runat="server" CellSpacing="20">
                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Based On Product Type:
                    </asp:TableCell><asp:TableCell runat="server">
                        <asp:DropDownList ID="dpTypeReport" runat="server"  style="width:160px; height:23px;" >
                                <asp:ListItem Value="0">---Select---</asp:ListItem>
                                <asp:ListItem Value="1">Bag</asp:ListItem>
                                <asp:ListItem Value="2">Box</asp:ListItem>
                                <asp:ListItem Value="3">Tube/Cone</asp:ListItem>
                                <asp:ListItem Value="4">Tag/Label</asp:ListItem>
                        </asp:DropDownList>
            
                        <asp:Button ID="btnShowTypeReport" runat="server" Text="Show"  OnClick="btnShowTypeReport_Click"  style="margin-left:10px;" />
                        <asp:Button ID="btnResetTypeReport" runat="server" Text="Reset"  OnClick="btnResetTypeReport_Click" style="margin-left:10px;" />
                    </asp:TableCell></asp:TableRow><asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                       Based On Product Sold:
                    </asp:TableCell><asp:TableCell runat="server">
                        <asp:Button ID="btnShowSalesReport" runat="server" Text="Show"  OnClick="btnShowSalesReport_Click" />
                        <asp:Button ID="btnResetSalesReport" runat="server" Text="Reset"  OnClick="btnResetSalesReport_Click" style="margin-left:10px;" />
                    </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            <br/>
            <br/>
            <asp:GridView ID="dgvReport" runat="server" />
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            <asp:Button ID="btnBack" runat="server" Text=" <--- Back " OnClick="btnBack_Click" style="margin-left:350px;" />

        </div>
    </form>
</body>
</html>

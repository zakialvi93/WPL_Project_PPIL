<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalesPage.aspx.cs" Inherits="WPL_Project.SalesPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PPIL- Sales Page</title>
    <link href="StyleSheetProject.css" rel="stylesheet" />
    <style>
        #btnSearchID:hover, #btnResetID:hover, #btnSearchType:hover, #btnResetType:hover, #btnSearchName:hover, #btnResetName:hover, #btnInsert:hover, #btnUpdate:hover, #btnDelete:hover, #btnReset:hover, #btnBack:hover, #btnSellerLogout:hover 
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
            <h1>Product Sales</h1>
            <hr />
            <h2>Product Search</h2>
            
            <asp:Table runat="server" CellSpacing="20">
                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Search via ID:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtSearchID" runat="server" />
                        <asp:Button ID="btnSearchID" runat="server" Text="Search" OnClick="btnSearchID_Click" style="margin-left:10px;" />
                        <asp:Button ID="btnResetID" runat="server" Text="Reset" OnClick="btnResetID_Click" style="margin-left:10px;"/>
                    </asp:TableCell>

                </asp:TableRow>

                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Search via Type:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:DropDownList ID="dpSearchProductType" runat="server" style="width:160px; height:23px;">
                                <asp:ListItem Value="0">---Select---</asp:ListItem>
                                <asp:ListItem Value="1">Bag</asp:ListItem>
                                <asp:ListItem Value="2">Box</asp:ListItem>
                                <asp:ListItem Value="3">Tube/Cone</asp:ListItem>
                                <asp:ListItem Value="4">Tag/Label</asp:ListItem>
                                </asp:DropDownList>
                        <asp:Button ID="btnSearchType" runat="server" Text="Search" OnClick="btnSearchType_Click" style="margin-left:10px;"/>
                        <asp:Button ID="btnResetType" runat="server" Text="Reset" OnClick="btnResetType_Click" style="margin-left:10px;"/>

                    </asp:TableCell>

                </asp:TableRow>

                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Search via Name:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtSearchName" runat="server" />
                        <asp:Button ID="btnSearchName" runat="server" Text="Search" OnClick="btnSearchName_Click" style="margin-left:10px;"/>
                        <asp:Button ID="btnResetName" runat="server" Text="Reset" OnClick="btnResetName_Click" style="margin-left:10px;"/>
                    </asp:TableCell>

                </asp:TableRow>
            </asp:Table>
             
            <asp:GridView ID="dgvSearch" runat="server" />
            <br/>
            <hr/>
            <h2>Product Selling & Recording</h2>
            
            <asp:Table runat="server" CellSpacing="20">

                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Enter Product ID:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtProductID" runat="server" />
                    </asp:TableCell>

                </asp:TableRow>

                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Enter Product Name:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtProductName" runat="server" />
                    </asp:TableCell>

                </asp:TableRow>

                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Select Product Type:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                                <asp:DropDownList ID="dpProductType" runat="server" style="width:160px; height:23px;">
                                <asp:ListItem Value="0">---Select---</asp:ListItem>
                                <asp:ListItem Value="1">Bag</asp:ListItem>
                                <asp:ListItem Value="2">Box</asp:ListItem>
                                <asp:ListItem Value="3">Tube/Cone</asp:ListItem>
                                <asp:ListItem Value="4">Tag/Label</asp:ListItem>
                                </asp:DropDownList>
                    </asp:TableCell>

                </asp:TableRow>

                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Enter Product Rate:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        $<asp:TextBox ID="txtProductRate" runat="server" style="margin-left:5px; width:143px;"/>
                    </asp:TableCell>

                </asp:TableRow>

                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Enter Product Quantity:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtProductQuantity" runat="server" />
                    </asp:TableCell>

                </asp:TableRow>

                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Total Bill Is:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        $<asp:Label ID="lblBill" runat="server" />
                    </asp:TableCell>

                </asp:TableRow>

            </asp:Table>
            
             
            
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" style="margin-left:280px;"/>
            <asp:Button ID="btnUpdate" runat="server" Text="Update" Visible="False" OnClick="btnUpdate_Click" style="margin-left:10px;"/>
            <asp:Button ID="btnDelete" runat="server" Text="Delete" Visible="False" OnClick="btnDelete_Click" style="margin-left:10px;"/>
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" style="margin-left:10px;"/>
            <br />
            <br/>
            <br/>
            
            
             <asp:Button ID="btnBack" runat="server" Text=" <---Back " OnClick="btnBack_Click" Visible="False" style="margin-left:350px;"/>
            <br/>
            <asp:Button ID="btnSellerLogout" runat="server" Text="Logout" OnClick="btnSellerLogout_Click" Visible="False" style="margin-left:350px;" />
        <br />
            <br/>
            <br/>
        </div>
    </form>
</body>
</html>

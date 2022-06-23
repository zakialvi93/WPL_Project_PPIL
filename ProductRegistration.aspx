<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductRegistration.aspx.cs" Inherits="WPL_Project.ProductRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PPIL- Product Registration Page</title>
    <link href="StyleSheetProject.css" rel="stylesheet" />
    <style>
        #btnAdd:hover, #btnUpdate:hover, #btnDel:hover, #btnProductReset:hover, #btnBack:hover 
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
            <br />
            <h1>Product Registration</h1>
            
            <hr />
            <br/>
            <asp:Table runat="server" CellSpacing="20">
                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Enter Unique Product ID:
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
                       Enter Product Description:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtProductDescription"  runat="server" />
                    </asp:TableCell>

                </asp:TableRow>

                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                       Enter Product Price:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        $<asp:TextBox ID="txtProductPrice" runat="server" style="margin-left:5px; width:143px;"/>
                    </asp:TableCell>

                </asp:TableRow>
            </asp:Table>
            
            
             
            <br/>
             
            <br/>
            <asp:Button ID="btnAdd" runat="server" Text="Register" OnClick="btnAdd_Click" style="margin-left:280px;" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" style="margin-left:10px;"/>
            <asp:Button ID="btnDel" runat="server" Text="Delete" OnClick="btnDel_Click" style="margin-left:10px;"/>
            <asp:Button ID="btnProductReset" runat="server" Text="Reset" OnClick="btnProductReset_Click" style="margin-left:10px;"/>
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            <asp:Button ID="btnBack" runat="server" Text=" <---Back " OnClick="btnBack_Click" style="margin-left:350px;"/>
        </div>
    </form>
</body>
</html>

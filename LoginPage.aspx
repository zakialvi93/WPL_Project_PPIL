<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WPL_Project.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PPIL- Login Page</title>
    <link href="StyleSheetProject.css" rel="stylesheet" />
    <style>
        #btnAdminLogin:hover,#btnAdminReset:hover,#btnSellerLogin:hover,#btnSellerReset:hover
        {
            background-color:black;
            color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            
            
            <br/>
            <h1 >Welcome To Paper Product Innovations Limited</h1>
            
            <hr />
            
            <h2>Admin Login</h2>
            <br />
            <asp:Table  runat="server" CellSpacing="20">
                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Enter ID:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtAdminID" runat="server" />
                    </asp:TableCell>

                </asp:TableRow>

                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Enter Password:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtAdminPassword" runat="server" TextMode="Password" />
                    </asp:TableCell>

                </asp:TableRow>
            </asp:Table>
             
            
             
            <br/>
            <asp:Button ID="btnAdminLogin" runat="server"  Text="Login" OnClick="btnAdminLogin_Click" style="margin-left:357px;" />
            <asp:Button ID="btnAdminReset" runat="server" Text="Reset" OnClick="btnAdminReset_Click" style="margin-left:10px;"/>
            
            <hr />
            
            <h2>Seller Login</h2>
            
            <asp:Table runat="server" CellSpacing="20">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        Enter ID:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtSellerID" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        Enter Password:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtSellerPassword" runat="server" TextMode="Password" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
             
            
             
            <br/>
            <asp:Button ID="btnSellerLogin" runat="server" Text="Login" OnClick="btnSellerLogin_Click" style="margin-left:357px; "/>
            <asp:Button ID="btnSellerReset" runat="server" Text="Reset" OnClick="btnSellerReset_Click" style="margin-left:10px;"/>
            <br/>
            <br/>
        </div>
    </form>
</body>
</html>

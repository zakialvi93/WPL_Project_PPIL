<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="WPL_Project.UserRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PPIL- User Registration Page</title>
    <link href="StyleSheetProject.css" rel="stylesheet" />
    <style>
        #btnRegister:hover, #btnDel:hover, #btnRegisterRest:hover, #btnBack:hover 
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
            <h1>User Registration</h1>
            
            <hr />
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            <asp:Table runat="server" CellSpacing="20">

                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Enter Unique ID:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtUserID" runat="server" />
                    </asp:TableCell>

                </asp:TableRow>


                <asp:TableRow runat="server">

                    <asp:TableCell runat="server">
                        Enter Password:
                    </asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtUserPassword" runat="server" TextMode="Password" />
                    </asp:TableCell>

                </asp:TableRow>

            </asp:Table>
             
            <br/>
             <br/>
            <br/>
            <br/>
            
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" style="margin-left:280px;"/>
            <asp:Button ID="btnDel" runat="server" Text="Delete" OnClick="btnDel_Click" style="margin-left:10px;"/>
            <asp:Button ID="btnRegisterRest" runat="server" Text="Reset" OnClick="btnRegisterRest_Click" style="margin-left:10px;"/>
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            
            <asp:Button ID="btnBack" runat="server" Text=" <---Back " OnClick="btnBack_Click"  style="margin-left:350px;"/>
            <br/>
            <br/>
        </div>
    </form>
</body>
</html>

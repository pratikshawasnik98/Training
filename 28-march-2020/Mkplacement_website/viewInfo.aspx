<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewInfo.aspx.cs" Inherits="Mkplacement_website.viewInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
        <div class="auto-style1">
            MKplacement
            <br />
        </div>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/home.aspx">home</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/register.aspx">Register</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/viewInfo.aspx">View Info</asp:HyperLink>
            <br />
            <br />
            <br />
            View Registration Info<br />
            <br />
            <br />
            User Name :&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Email :&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            User Count :&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
        </div>
    </form>
</body>
</html>

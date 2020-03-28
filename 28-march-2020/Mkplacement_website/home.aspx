<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Mkplacement_website.home" %>

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
    <form id="form1" runat="server">
        <div class="auto-style1">
            MKplacement
            <br />
        </div>
        <div class="auto-style1">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/home.aspx">home</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/register.aspx">Register</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/viewInfo.aspx">View Info</asp:HyperLink>
            <br />
            <br />
            Welcome to Mkplacement</div>
    </form>
</body>
</html>

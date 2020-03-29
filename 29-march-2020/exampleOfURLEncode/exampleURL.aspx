<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exampleURL.aspx.cs" Inherits="example_Of_URLEncode.exampleURL" %>

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
        <div>
        </div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Call Next Page" />
        </div>
        <p>
            &nbsp;</p>
        <p class="auto-style1">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>

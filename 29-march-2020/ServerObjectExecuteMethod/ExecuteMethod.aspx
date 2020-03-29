<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExecuteMethod.aspx.cs" Inherits="ServerObjectExecuteMethod.ExecuteMethod" %>

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
            WELCOME<br />
            <br />
            <br />
            This is Home Page<br />
            <br />
            <br />
        </div>
        <p class="auto-style1">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />
        </p>
    </form>
</body>
</html>

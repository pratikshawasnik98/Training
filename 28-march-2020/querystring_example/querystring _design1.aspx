<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="querystring _design1.aspx.cs" Inherits="querystring__example.querystring__design1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span lang="EN-US" style="font-size:9.5pt;line-height:
115%;font-family:Consolas;mso-fareast-font-family:Calibri;mso-fareast-theme-font:
minor-latin;mso-bidi-font-family:Consolas;color:black;mso-ansi-language:EN-US;
mso-fareast-language:EN-US;mso-bidi-language:AR-SA">querystring </span><span style="font-size:9.5pt;line-height:
115%;font-family:Consolas;mso-fareast-font-family:Calibri;mso-fareast-theme-font:
minor-latin;mso-bidi-font-family:Consolas;color:black;mso-ansi-language:EN-US;
mso-fareast-language:EN-US;mso-bidi-language:AR-SA">example</span></div>
        <p>
            we want to pass entered in textbox to another page using <span lang="EN-US" style="font-size:9.5pt;line-height:
115%;font-family:Consolas;mso-fareast-font-family:Calibri;mso-fareast-theme-font:
minor-latin;mso-bidi-font-family:Consolas;color:black;mso-ansi-language:EN-US;
mso-fareast-language:EN-US;mso-bidi-language:AR-SA">query</span><span style="font-size:9.5pt;line-height:
115%;font-family:Consolas;mso-fareast-font-family:Calibri;mso-fareast-theme-font:
minor-latin;mso-bidi-font-family:Consolas;color:black;mso-ansi-language:EN-US;
mso-fareast-language:EN-US;mso-bidi-language:AR-SA"> </span><span lang="EN-US" style="font-size:9.5pt;line-height:
115%;font-family:Consolas;mso-fareast-font-family:Calibri;mso-fareast-theme-font:
minor-latin;mso-bidi-font-family:Consolas;color:black;mso-ansi-language:EN-US;
mso-fareast-language:EN-US;mso-bidi-language:AR-SA">string </span>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Call another page and pass value of textbox to another page" />
    </form>
</body>
</html>

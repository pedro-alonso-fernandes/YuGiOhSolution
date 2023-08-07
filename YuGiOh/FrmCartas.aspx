<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCartas.aspx.cs" Inherits="YuGiOh.FrmCartas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LoginName FormatString="{0} - " runat="server" />
            <asp:LoginStatus runat="server" ID="LoginStatus1" CssClass="logon" LoginText="Entrar" LogoutText="Sair" />
        </div>
    </form>
</body>
</html>

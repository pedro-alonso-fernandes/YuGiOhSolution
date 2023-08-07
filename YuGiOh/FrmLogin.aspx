<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="YuGiOh.FrmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>LOGIN</h1>
            <fieldset>
                <legend>LOGIN</legend>

                <label>Login:</label>
                <input type="text" id="txtLogin" runat="server"/>
                <br />
                <br />

                <label>Senha:</label>
                <input type="password" id="txtSenha" runat="server"/>
                <br />
                <br />

                <asp:Button Text="Confirmar" runat="server" id="btnConfirmar" OnClick="btnConfirmar_Click"/>
                <br />
                <br />


                <a href="FrmCadastrar.aspx">Ainda não tem um login? Clique aqui para se cadastrar</a>
            </fieldset>
            <label id="lblMensagem" runat="server"></label>

        </div>
    </form>
</body>
</html>

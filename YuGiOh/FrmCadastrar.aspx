<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCadastrar.aspx.cs" Inherits="YuGiOh.FrmCadastrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cadastrar</h1>
            <fieldset>
                <legend>CADASTRO</legend>
                
                <label>Nome:</label>
                <input type="text" id="txtNome" runat="server"/>
                <br />
                <br />

                <label>Data de Nascimento:</label>
                <asp:TextBox runat="server" TextMode="Date" ID="txtData"/>
                <br />
                <br />

                <label>Crie uma login:</label>
                <input type="text" id="txtLogin" runat="server"/>
                <br />
                <br />

                <label>Crie uma senha:</label>
                <input type="password" id="txtSenha" runat="server" />
                <br />
                <br />

                <label>Confirmar senha:</label>
                <input type="password" id="txtConfirmarSenha" runat="server"/>
                <br />
                <br />

                

                <asp:Button Text="Cadastrar" runat="server" id="btnCadastrar" OnClick="btnCadastrar_Click"/>
                <br />
                <br />

                <a href="FrmLogin.aspx">Já tem um login? Clique aqui para logar</a>

            </fieldset>

            <label id="lblMensagem" runat="server"></label>
        </div>
    </form>
</body>
</html>

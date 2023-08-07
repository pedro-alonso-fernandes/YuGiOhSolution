<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCartas.aspx.cs" Inherits="YuGiOh.FrmCartas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cartas</title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:LoginName FormatString="{0} - " runat="server" />
        <asp:LoginStatus runat="server" ID="LoginStatus1" CssClass="logon" LoginText="Entrar" LogoutText="Sair" />
        <div>
            <h1>Cadastrar Carta</h1>
            <fieldset>
                <legend>CADASTRO</legend>

                <label>Nome:</label>
                <input type="text" id="txtNome" runat="server"/>
                <br />
                <br />

                <label>Nível:</label>
                <input type="number" id="nmrNivel" runat="server"/>
                <br />
                <br />

                <label>Atributo:</label>
                <input type="text" id="txtAtributo" runat="server"/>
                <br />
                <br />

                <label>Ícone:</label>
                <input type="text" id="txtIcone" runat="server"/>
                <br />
                <br />

                <label>Tipo:</label>
                <asp:DropDownList runat="server" ID="ddlTipo" AutoPostBack="true" OnSelectedIndexChanged="ddlTipo_SelectedIndexChanged">
                    <asp:ListItem Text="Monstro" />
                    <asp:ListItem Text="Armadilha" />
                    <asp:ListItem Text="Magia" />
                </asp:DropDownList>

                <div id="DivMonstro" runat="server">

                    <br />
                    <label>Tipo de Monstro:</label>
                    <asp:DropDownList runat="server">
                        <asp:ListItem Text="Monstro Normal" />
                        <asp:ListItem Text="Monstro de Efeito" />
                    </asp:DropDownList>

                </div>

                <div id="DivArmadilha" runat="server">
                    
                    <br />
                    <label>Tipo de Armadilha:</label>
                    <asp:DropDownList runat="server">
                        <asp:ListItem Text="Armadilha Normal" />
                        <asp:ListItem Text="Armadilha Contínua" />
                        <asp:ListItem Text="Armadilha de Resposta" />
                    </asp:DropDownList>

                </div>

                <div id="DivMagia" runat="server">

                    <br />
                    <label>Tipo de Magia:</label>
                    <asp:DropDownList runat="server">
                        <asp:ListItem Text="Magia Normal" />
                        <asp:ListItem Text="Magia de Ritual" />
                        <asp:ListItem Text="Magia Contínua" />
                        <asp:ListItem Text="Magia de Equipamento" />
                        <asp:ListItem Text="Magia de Campo" />
                        <asp:ListItem Text="Magia Rápida" />
                    </asp:DropDownList>

                </div>

                <br />
                <br />

                <label>Número:</label>
                <input type="number" id="nmrNumero" runat="server"/>
                <br />
                <br />

                <label>Pontos de Ataque:</label>
                <input type="number" id="nmrPtnAtaque" runat="server"/>
                <br />
                <br />

                <label>Pontos de Defesa:</label>
                <input type="number" id="nmrPtnDefesa" runat="server"/>
                <br />
                <br />

                <label>Descrição:</label>
                <br />
                <textarea id="TextArea" cols="80" rows="10"></textarea>
                <br />
                <br />

            </fieldset>
        </div>
    </form>
</body>
</html>

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
                <input type="number" id="nmrNivel" runat="server" min="1" max="12"/>
                <br />
                <br />

                <label>Atributo:</label>
                <asp:DropDownList runat="server" ID="ddlAtributo">
                    <asp:ListItem Text="Terra" />
                    <asp:ListItem Text="Fogo" />
                    <asp:ListItem Text="Água" />
                    <asp:ListItem Text="Vento" />
                    <asp:ListItem Text="Luz" />
                    <asp:ListItem Text="Trevas" />
                </asp:DropDownList>
                <br />
                <br />

                <label>Ícone:</label>
                <asp:DropDownList runat="server" ID="ddlIcone">
                    <asp:ListItem Text="Equipamento" />
                    <asp:ListItem Text="Campos" />
                    <asp:ListItem Text="Ritual" />
                    <asp:ListItem Text="Contínuo" />
                    <asp:ListItem Text="Rápida" />
                    <asp:ListItem Text="Resposta" />
                </asp:DropDownList>
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
                    <asp:DropDownList runat="server" ID="ddlMonstros" AutoPostBack="true" OnSelectedIndexChanged="ddlMonstros_SelectedIndexChanged">
                        <asp:ListItem Text="Monstro Normal" />
                        <asp:ListItem Text="Monstro de Efeito" />
                    </asp:DropDownList>

                    <br />
                    

                    <div id="DivEfeitos" runat="server">

                        <label>Efeito do Monstro:</label>
                        <asp:DropDownList runat="server" ID="ddlEfeitos" AutoPostBack="true" OnSelectedIndexChanged="ddlEfeitos_SelectedIndexChanged">
                            <asp:ListItem Text="Efeito Contínuo" />
                            <asp:ListItem Text="Efeito de Ignição" />
                            <asp:ListItem Text="Efeito Rápido" />
                            <asp:ListItem Text="Efeito de Gatilho" />
                            <asp:ListItem Text="Monstro Pêndulo" />
                        </asp:DropDownList>

                        <div id="DivPendulos" runat="server">

                            <label>Pêndulo do Monstro:</label>
                            <asp:DropDownList runat="server" ID="ddlPendulos">
                                <asp:ListItem Text="Efeito do Pêndulo" />
                                <asp:ListItem Text="Efeito do Monstro" />
                                <asp:ListItem Text="Monstro XYZ" />
                                <asp:ListItem Text="Monstro Sincro" />
                                <asp:ListItem Text="Monstro Reguladores" />
                                <asp:ListItem Text="Monstro de Fusão" />
                                <asp:ListItem Text="Monstro de Ritual" />
                            </asp:DropDownList>

                        </div>

                    </div>

                </div>

                <div id="DivArmadilha" runat="server">
                    
                    <br />
                    <label>Tipo de Armadilha:</label>
                    <asp:DropDownList runat="server" ID="ddlArmadilhas">
                        <asp:ListItem Text="Armadilha Normal" />
                        <asp:ListItem Text="Armadilha Contínua" />
                        <asp:ListItem Text="Armadilha de Resposta" />
                    </asp:DropDownList>

                </div>

                <div id="DivMagia" runat="server">

                    <br />
                    <label>Tipo de Magia:</label>
                    <asp:DropDownList runat="server" ID="ddlMagias">
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
  

                <label>Número da Carta:</label>
                <input type="text" id="txtNumero" runat="server"/>
                <br />
                <br />

                <label>Pontos de Ataque:</label>
                <input type="number" id="nmrPtnAtaque" runat="server" min="1" max="10000"/>
                <br />
                <br />

                <label>Pontos de Defesa:</label>
                <input type="number" id="nmrPtnDefesa" runat="server" min="1" max="10000"/>
                <br />
                <br />

                <label>Descrição:</label>
                <br />
                <textarea id="TextArea" cols="80" rows="10"></textarea>
                <br />
                <br />

                <asp:Button Text="Cadastrar" runat="server" />
                <br />
                <br />

            </fieldset>
            <label id="lblMensagem" runat="server"></label>
        </div>
    </form>
</body>
</html>

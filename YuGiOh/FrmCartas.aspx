<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCartas.aspx.cs" Inherits="YuGiOh.FrmCartas" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="icon" type="image/png" href="data:image/jpeg;base64,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" sizes="32x32" />

    <link href="css/Style.css" rel="stylesheet" />

    <title>Cartas</title>
</head>
<body>


    <form id="form1" runat="server">
        <fieldset>
            <nav class="navbar">


                <ul class="nav-list">
                   
                    <li><a href="#">Cadastrar Cartas</a></li>
                    <li><a href="Default.aspx">Inicio</a></li>
                    <li>
                        <asp:LoginName FormatString="{0} - " runat="server" />
                        <asp:LoginStatus runat="server" ID="LoginStatus2" CssClass="logon" LoginText="Entrar" LogoutText="Sair" />

                    </li>



                    <div class="botao">
                        <div class="bola"></div>
                    </div>


                </ul>


            </nav>
        </fieldset>
        <div>
            <h1 id="h1" runat="server">Cadastrar Carta</h1>
            <label id="lblMensagem" runat="server"></label>
            <fieldset>
                <legend id="lgFieldset" runat="server">CADASTRO</legend>

                <label>Nome:</label>
                <input type="text" id="txtNome" runat="server" />
                <br />
                <br />

                <label>Nível:</label>
                <input type="number" id="nmrNivel" runat="server" min="1" max="12" />
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
                <input type="text" id="txtNumero" runat="server" />
                <br />
                <br />

                <label>Pontos de Ataque:</label>
                <input type="number" id="nmrPtnAtaque" runat="server" min="1" max="10000" />
                <br />
                <br />

                <label>Pontos de Defesa:</label>
                <input type="number" id="nmrPtnDefesa" runat="server" min="1" max="10000" />
                <br />
                <br />

                <label>Descrição:</label>
                <br />
                <textarea id="txtDescricao" cols="120" rows="15" runat="server"></textarea>
                <br />
                <br />

                <label>Imagem:</label>
                <br />
                <asp:FileUpload ID="imgSelecionada" runat="server" />
                <br />
                <br />

                <fieldset id="fieldImg" runat="server" class="fieldImg">
                    <img src="#" alt="Imagem" id="ImgSite" runat="server" class="imagem" />
                </fieldset>
                <br />
                <br />

                <asp:Button Text="Vizualizar Imagem" runat="server" ID="btnConfirmar" OnClick="btnConfirmar_Click" />
                <br />
                <br />

                <asp:Button Text="Cadastrar" runat="server" ID="btnCadastrar" OnClick="btnCadastrar_Click" />
                <br />
                <br />

            </fieldset>
            

            <br />
            <br />

            <fieldset>
                <legend>Cartas Cadastradas</legend>
                <table border="2">
                    <tr>
                        <th>Imagem</th>
                        <th>Nome</th>
                        <th>Nível</th>
                        <th>Atributo</th>
                        <th>Ícone</th>
                        <th>Tipo</th>
                        <th>Número</th>
                        <th>Pontos de Ataque</th>
                        <th>Pontos de Defesa</th>
                        <th colspan="2">Ação</th>
                    </tr>

                    <asp:ListView runat="server" ID="lvCartas" OnItemCommand="lvCartas_ItemCommand">
                        <ItemTemplate>

                            <tr>
                                <td>
                                    <img src="upload/<%# Eval("Nome") %>.png" alt="<%# Eval("Nome") %>" class="imagem" />
                                </td>

                                <td><%# Eval("Nome") %> </td>
                                <td><%# Eval("Nivel") %></td>
                                <td><%# Eval("AtributoId") %></td>
                                <td><%# Eval("IconeId") %></td>
                                <td><%# Eval("TipoId") %></td>
                                <td><%# Eval("Numero") %></td>
                                <td><%# Eval("PtnAtaque") %></td>
                                <td><%# Eval("PtnDefesa") %></td>
                                <td>
                                    <asp:ImageButton ID="ibDelete" runat="server" ImageUrl="~/img/delete1.png" CssClass="botaoTable" CommandName="deletar" CommandArgument='<%# Eval("IdCarta") %>' OnCommand="ibDelete_Command" />
                                </td>
                                <td>
                                    <asp:ImageButton ID="ibAlterar" runat="server" ImageUrl="~/img/alterar.png" CssClass="botaoTable" CommandName="alterar" CommandArgument='<%# Eval("IdCarta") %>' OnCommand="ibAlterar_Command" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>

                </table>
            </fieldset>
            <asp:HiddenField ID="hfid" runat="server" />

        </div>
    </form>


    <script>
        document.querySelector('.bola').addEventListener('click', (e) => {
            e.target.classList.toggle('bola-movendo');
            document.body.classList.toggle('escuro');





        });
    </script>






</body>



<script>
    function animateTitle() {
        i >= message.length - 1 ? (i = 0) : i++,
            (document.title = message[i]),
            setTimeout('animateTitle()', 600)
    }
    var message = [
        '|',
        'ㅤ',
        'C|',
        'C',
        'Ca|',
        'Ca',
        'Car|',
        'Car',
        'Cart|',
        'Cart',
        'Carta|',
        'Carta'
    ],
        i = 0
    animateTitle()
</script>
</body>
</html>

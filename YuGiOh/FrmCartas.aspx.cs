using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YuGiOh
{
    public partial class FrmCartas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                ddlTipo.Items.Insert(0, " ");
                ddlAtributo.Items.Insert(0, " ");
                ddlIcone.Items.Insert(0, " ");
                ddlMonstros.Items.Insert(0, " ");
                ddlEfeitos.Items.Insert(0, " ");
                ddlPendulos.Items.Insert(0, " ");
                ddlArmadilhas.Items.Insert(0, " ");
                ddlMagias.Items.Insert(0, " ");


            }

            DivMonstro.Visible = false;
            DivArmadilha.Visible = false;
            DivMagia.Visible = false;
            DivEfeitos.Visible = false;
            DivPendulos.Visible = false;


        }

        protected void ddlTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valorSelecionado = ((DropDownList)sender).SelectedValue;

            if (valorSelecionado.Contains("Monstro"))
            {
                DivMonstro.Visible = true;
                DivArmadilha.Visible = false;
                DivMagia.Visible = false;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;

            }

            else if (valorSelecionado.Contains("Armadilha"))
            {
                DivMonstro.Visible = false;
                DivArmadilha.Visible = true;
                DivMagia.Visible = false;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;

            }

            else if (valorSelecionado.Contains("Magia"))
            {
                DivMonstro.Visible = false;
                DivArmadilha.Visible = false;
                DivMagia.Visible = true;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;

            }

            else
            {
                DivMonstro.Visible = false;
                DivArmadilha.Visible = false;
                DivMagia.Visible = false;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;

            }
        }

        protected void ddlMonstros_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valorSelecionado = ((DropDownList)sender).SelectedValue;

            if (valorSelecionado.Contains("Efeito"))
            {
                DivEfeitos.Visible = true;
                DivMonstro.Visible = true;

            }
            else
            {
                DivEfeitos.Visible = false;
                DivMonstro.Visible = true;

            }
        }

        protected void ddlEfeitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valorSelecionado = ((DropDownList)sender).SelectedValue;

            if (valorSelecionado.Contains("Pêndulo"))
            {

                DivPendulos.Visible = true;
                DivMonstro.Visible = true;
                DivEfeitos.Visible = true;

            }
            else
            {
                DivPendulos.Visible = false;
                DivMonstro.Visible = true;
                DivEfeitos.Visible = true;
            }

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Value;

            string atributo = ddlAtributo.SelectedValue;
            string icone = ddlIcone.SelectedValue;
            string tipo = ddlTipo.SelectedValue;
            string numero = txtNumero.Value;

            string descricao = txtDescricao.Value;

            string tipoMonstro = ddlMonstros.SelectedValue;
            string mnstEfeito = ddlEfeitos.SelectedValue;
            string efPendulo = ddlPendulos.SelectedValue;

            string tipoArmadilha = ddlArmadilhas.SelectedValue;

            string tipoMagia = ddlMagias.SelectedValue;

            /*if (nome != "" && nmrNivel.Value != "0" && atributo != " " && icone != " " && tipo != " " && numero != "" && nmrPtnAtaque.Value != "0" && nmrPtnDefesa.Value != "0" && descricao != "" && nome != " " && numero != " " && descricao != " " && (tipoMonstro != " " || tipoArmadilha != " " || tipoMagia != " "))
            {

                int nivel = Convert.ToInt32(nmrNivel.Value);
                int ptnAtaque = Convert.ToInt32(nmrPtnAtaque.Value);
                int ptnDefesa = Convert.ToInt32(nmrPtnDefesa.Value);


                Carta c = new Carta();
                Atributo at = new Atributo();
                Icone i = new Icone();
                Tipo ti = new Tipo();
                CrtMonstro mo = new CrtMonstro();
                CrtArmadilha ar = new CrtArmadilha();
                CrtMagia ma = new CrtMagia();
                MnstEfeito ef = new MnstEfeito();
                EfPendulo pe = new EfPendulo();

                string mensagem = null;

                c.Nome = nome;
                c.Nivel = nivel;
                at.Descricao = atributo;
                i.Descricao = icone;
                ti.Descricao = tipo;
                c.Numero = numero;
                c.PtnAtaque = ptnAtaque;
                c.PtnDefesa = ptnDefesa;
                c.Descricao = descricao;

                mo.Descricao = tipoMonstro;
                ef.Descricao = mnstEfeito;
                pe.Descricao = efPendulo;

                ar.Descricao = tipoArmadilha;

                ma.Descricao = tipoMagia;

                if (mo.Descricao != " " && mo.Descricao != null)
                {

                    if (ef.Descricao != " " && ef.Descricao != null)
                    {

                        if (pe.Descricao != " " && pe.Descricao != null)
                        {
                            mensagem = Cartas.CadastrarMonstroPendulo(c, at, i, ti, mo, ef, pe);
                            lblMensagem.InnerText = mensagem;
                        }
                        else
                        {
                            mensagem = Cartas.CadastrarMonstroEfeito(c, at, i, ti, mo, ef);
                            lblMensagem.InnerText = mensagem;
                        }

                    }
                    else
                    {
                        mensagem = Cartas.CadastrarMonstro(c, at, i, ti, mo);
                        lblMensagem.InnerText = mensagem;
                    }

                }
                //Fazer os ifs dos outros tipos



                


                }
                else
                {
                    lblMensagem.InnerText = "Você deixou campos em branco, preencha todos os campos!";
                }*/

            if (imgSelecionada.HasFile)
            {
                var arquivo = imgSelecionada.PostedFile;
                string tipoImg = arquivo.ContentType;

                if (tipoImg.Contains("image/"))
                {

                    string extensao = tipoImg.Replace("image/", "");

                    //{[("'ID INVENTADO!!!!!!!'")]};
                    int id = 333;

                    string nomeArquivo = id + "." + extensao;
                    var caminho = MapPath("~/upload") + "\\" + nomeArquivo;
                    arquivo.SaveAs(caminho;

                    //imgSelecionada.Src = "~/upload/" + nomeArquivo;
                    lblMensagem.InnerText = "parece que deu certo";

                }
                else
                {

                    lblMensagem.InnerText = "O arquivo selecionado não é uma imagem. Tente selicionar um arquivo tipo JPEG, JPG ou PNG";

                }
            }
        }
    }
}
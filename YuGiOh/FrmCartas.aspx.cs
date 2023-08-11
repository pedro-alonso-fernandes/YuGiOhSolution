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

                DivMonstro.Visible = false;
                DivArmadilha.Visible = false;
                DivMagia.Visible = false;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;
                fieldImg.Visible = false;




            }

            AtualizarListViewCartas();

        }

       

        private void AtualizarListViewCartas()
        {
            List<Carta> lvcartas = CartasDAO.ListarCartas();
            AtualizarListaCartas(lvcartas);
        }

        private void AtualizarListaCartas(List<Carta> lvcartas)
        {
            lvCartas.DataSource = lvcartas;
            lvCartas.DataBind();
            
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

                ddlArmadilhas.SelectedIndex = 0;
                ddlMagias.SelectedIndex = 0;

                ddlEfeitos.SelectedIndex = 0;
                ddlPendulos.SelectedIndex = 0;

            }

            else if (valorSelecionado.Contains("Armadilha"))
            {
                DivMonstro.Visible = false;
                DivArmadilha.Visible = true;
                DivMagia.Visible = false;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;

                ddlMonstros.SelectedIndex = 0;
                ddlMagias.SelectedIndex = 0;

                ddlEfeitos.SelectedIndex = 0;
                ddlPendulos.SelectedIndex = 0;

            }

            else if (valorSelecionado.Contains("Magia"))
            {
                DivMonstro.Visible = false;
                DivArmadilha.Visible = false;
                DivMagia.Visible = true;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;

                ddlArmadilhas.SelectedIndex = 0;
                ddlMonstros.SelectedIndex = 0;

                ddlEfeitos.SelectedIndex = 0;
                ddlPendulos.SelectedIndex = 0;

            }

            else
            {
                DivMonstro.Visible = false;
                DivArmadilha.Visible = false;
                DivMagia.Visible = false;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;

                ddlMonstros.SelectedIndex = 0;
                ddlArmadilhas.SelectedIndex = 0;
                ddlMagias.SelectedIndex = 0;

                ddlEfeitos.SelectedIndex = 0;
                ddlPendulos.SelectedIndex = 0;

            }
        }

        protected void ddlMonstros_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valorSelecionado = ((DropDownList)sender).SelectedValue;

            if (valorSelecionado.Contains("Efeito"))
            {
                DivEfeitos.Visible = true;
                DivMonstro.Visible = true;
                DivPendulos.Visible = false;

                ddlPendulos.SelectedIndex = 0;

            }
            else
            {
                DivEfeitos.Visible = false;
                DivMonstro.Visible = true;
                DivPendulos.Visible = false;

                ddlEfeitos.SelectedIndex = 0;
                ddlPendulos.SelectedIndex = 0;

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
                
                ddlPendulos.SelectedIndex = 0;
            }

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
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

                if (nome != "" && nmrNivel.Value != "0" && atributo != " " && icone != " " && tipo != " " && numero != "" && nmrPtnAtaque.Value != "0" && nmrPtnDefesa.Value != "0" && descricao != "" && nome != " " && numero != " " && descricao != " " && (tipoMonstro != " " || tipoArmadilha != " " || tipoMagia != " "))
                {



                    int nivel = Convert.ToInt32(nmrNivel.Value);
                    int ptnAtaque = Convert.ToInt32(nmrPtnAtaque.Value);
                    int ptnDefesa = Convert.ToInt32(nmrPtnDefesa.Value);


                    Carta c = new Carta();
                    Atributo at = new Atributo();
                    Icone i = new Icone();
                    Tipo ti = new Tipo();
                    CrtImagem img = new CrtImagem();
                    CrtMonstro mo = new CrtMonstro();
                    CrtArmadilha ar = new CrtArmadilha();
                    CrtMagia ma = new CrtMagia();
                    MnstEfeito ef = new MnstEfeito();
                    EfPendulo pe = new EfPendulo();

                    string mensagem = null;

                    c.Nome = nome;
                    c.Nivel = nivel;
                    c.Numero = numero;
                    c.PtnAtaque = ptnAtaque;
                    c.PtnDefesa = ptnDefesa;
                    c.Descricao = descricao;

                    at.Descricao = atributo;
                    at.Index = ddlAtributo.SelectedIndex;

                    i.Descricao = icone;
                    i.Index = ddlIcone.SelectedIndex;

                    ti.Descricao = tipo;
                    ti.Index = ddlTipo.SelectedIndex;

                    mo.Descricao = tipoMonstro;
                    mo.Index = ddlMonstros.SelectedIndex;

                    ef.Descricao = mnstEfeito;
                    ef.Index = ddlEfeitos.SelectedIndex;

                    pe.Descricao = efPendulo;
                    pe.Index = ddlPendulos.SelectedIndex;

                    ar.Descricao = tipoArmadilha;
                    ar.Index = ddlArmadilhas.SelectedIndex;

                    ma.Descricao = tipoMagia;
                    ma.Index = ddlMagias.SelectedIndex;

                    if (imgSelecionada.HasFile)
                    {


                        var arquivo = imgSelecionada.PostedFile;
                        string tipoImg = arquivo.ContentType;

                        if (tipoImg.Contains("image/"))
                        {

                            string extensao = "";

                            if (tipoImg.Contains("image/jpg"))
                            {

                                extensao = tipoImg.Replace("image/jpg", "png");

                            }
                            else if (tipoImg.Contains("image/jpeg"))
                            {

                                extensao = tipoImg.Replace("image/jpeg", "png");

                            }
                            else if (tipoImg.Contains("image/gif"))
                            {

                                extensao = tipoImg.Replace("image/gif", "png");

                            }
                            else if (tipoImg.Contains("image/webp"))
                            {

                                extensao = tipoImg.Replace("image/webp", "png");

                            }

                            string nomeArquivo = c.Nome + "." + extensao;
                            string caminho = MapPath("~/upload") + "\\" + nomeArquivo;
                            arquivo.SaveAs(caminho);

                            img.Nome = nomeArquivo;
                            img.Src = "~/upload/" + nomeArquivo;



                            if (mo.Descricao != " " && mo.Descricao != null)
                            {

                                if (ef.Descricao != " " && ef.Descricao != null)
                                {

                                    if (pe.Descricao != " " && pe.Descricao != null)
                                    {
                                        mensagem = CartasDAO.CadastrarMonstroPendulo(c, at, i, ti, mo, ef, pe, img);
                                        lblMensagem.InnerText = mensagem;

                                        LimparFormulario();
                                        AtualizarListViewCartas();

                                    }
                                    else
                                    {
                                        mensagem = CartasDAO.CadastrarMonstroEfeito(c, at, i, ti, mo, ef, img);
                                        lblMensagem.InnerText = mensagem;
                                        LimparFormulario();
                                        AtualizarListViewCartas();
                                    }

                                }
                                else
                                {
                                    mensagem = CartasDAO.CadastrarMonstro(c, at, i, ti, mo, img);
                                    lblMensagem.InnerText = mensagem;
                                    LimparFormulario();
                                    AtualizarListViewCartas();
                                }

                            }

                            else if (ar.Descricao != " " && ar.Descricao != null)
                            {
                                mensagem = CartasDAO.CadastrarArmadilha(c, at, i, ti, ar, img);
                                lblMensagem.InnerText = mensagem;
                                LimparFormulario();
                                AtualizarListViewCartas();
                            }

                            else if (ma.Descricao != " " && ma.Descricao != null)
                            {

                                mensagem = CartasDAO.CadastrarMagia(c, at, i, ti, ma, img);
                                lblMensagem.InnerText = mensagem;
                                LimparFormulario();
                                AtualizarListViewCartas();

                            }


                        }
                        else
                        {

                            lblMensagem.InnerText = "O arquivo selecionado não é uma imagem. Tente selicionar um arquivo tipo JPEG, JPG ou PNG";

                        }

                    }
                    else if (fieldImg.Visible == true)
                    {

                        string nomeArquivo = c.Nome + ".png";

                        img.Nome = nomeArquivo;
                        img.Src = "~/upload/" + nomeArquivo;


                        if (mo.Descricao != " " && mo.Descricao != null)
                        {

                            if (ef.Descricao != " " && ef.Descricao != null)
                            {

                                if (pe.Descricao != " " && pe.Descricao != null)
                                {
                                    mensagem = CartasDAO.CadastrarMonstroPendulo(c, at, i, ti, mo, ef, pe, img);
                                    lblMensagem.InnerText = mensagem;
                                    LimparFormulario();
                                    AtualizarListViewCartas();
                                }
                                else
                                {
                                    mensagem = CartasDAO.CadastrarMonstroEfeito(c, at, i, ti, mo, ef, img);
                                    lblMensagem.InnerText = mensagem;
                                    LimparFormulario();
                                    AtualizarListViewCartas();
                                }

                            }
                            else
                            {
                                mensagem = CartasDAO.CadastrarMonstro(c, at, i, ti, mo, img);
                                lblMensagem.InnerText = mensagem;
                                LimparFormulario();
                                AtualizarListViewCartas();
                            }

                        }

                        else if (ar.Descricao != " " && ar.Descricao != null)
                        {
                            mensagem = CartasDAO.CadastrarArmadilha(c, at, i, ti, ar, img);
                            lblMensagem.InnerText = mensagem;
                            LimparFormulario();
                            AtualizarListViewCartas();
                        }

                        else if (ma.Descricao != " " && ma.Descricao != null)
                        {

                            mensagem = CartasDAO.CadastrarMagia(c, at, i, ti, ma, img);
                            lblMensagem.InnerText = mensagem;
                            LimparFormulario();
                            AtualizarListViewCartas();

                        }


                        else
                        {
                            lblMensagem.InnerText = "Você não selecionou uma imagem, ou o arquivo selecionado não é uma imagem";
                        }

                    }

                    else
                    {
                        lblMensagem.InnerText = "Você deixou campos em branco, preencha todos os campos!";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensagem.InnerText = "Algo deu errado. Possivelmente você inseriu um arquivo muito grande ou um arquivo que não é imagem";
            }
        }

        private void LimparFormulario()
        {
            txtNome.Value = "";
            nmrNivel.Value = "";
            ddlAtributo.SelectedIndex = 0;
            ddlIcone.SelectedIndex = 0;
            ddlTipo.SelectedIndex = 0;
            txtNumero.Value = "";
            txtDescricao.Value = "";
            nmrPtnAtaque.Value = "";
            nmrPtnDefesa.Value = "";

            ddlMonstros.SelectedIndex = 0;
            ddlArmadilhas.SelectedIndex = 0;
            ddlMagias.SelectedIndex = 0;

            ddlEfeitos.SelectedIndex = 0;
            ddlPendulos.SelectedIndex = 0;

            fieldImg.Visible = false;
            DivMonstro.Visible = false;
            DivArmadilha.Visible = false;
            DivMagia.Visible = false;
            DivEfeitos.Visible = false;
            DivPendulos.Visible = false;
            fieldImg.Visible = false;
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgSelecionada.HasFile)
                {
                    var arquivo = imgSelecionada.PostedFile;
                    string tipoImg = arquivo.ContentType;

                    if (tipoImg.Contains("image/"))
                    {
                        string extensao = "";
                        
                        if (tipoImg.Contains("image/jpg")){

                            extensao = tipoImg.Replace("image/jpg", "png");

                        }
                        else if (tipoImg.Contains("image/jpeg")){

                            extensao = tipoImg.Replace("image/jpeg", "png");

                        }
                        else if (tipoImg.Contains("image/gif")){

                            extensao = tipoImg.Replace("image/gif", "png");

                        }
                        else if (tipoImg.Contains("image/webp")){

                            extensao = tipoImg.Replace("image/webp", "png");

                        }



                        if (txtNome.Value != "" && txtNome.Value != " " && txtNome.Value != "  ")
                        {

                            var nomeArquivo = txtNome.Value + "." + extensao;
                            var caminho = MapPath("~/upload") + "\\" + nomeArquivo;
                            arquivo.SaveAs(caminho);

                            fieldImg.Visible = true;
                            ImgSite.Src = "~/upload/" + nomeArquivo;
                        }
                        else
                        {
                            lblMensagem.InnerText = "Preencha o campo \"Nome\" antes de selecionar uma imagem";
                        }
                    }
                    else
                    {
                        lblMensagem.InnerText = "O arquivo selecionado não é uma imagem. Tente selicionar um arquivo tipo JPEG, JPG ou PNG";
                    }
                }

            }
            catch (Exception ex)
            {
                lblMensagem.InnerText = "Algo deu errado. Possivelmente você inseriu um arquivo muito grande ou um arquivo que não é imagem";
            }

        }

        protected void lvCartas_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            /*int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "deletar")
            {
                Carta c = CartasDAO.Excluir(id);
                if (c != null)
                {
                    lblMensagem.InnerText = "A carta \"" + c.Nome + "\" foi excluída com sucesso";
                }
                else
                {
                    lblMensagem.InnerText = "Não foi possível excluir a carta desejada";
                }

                AtualizarListViewCartas();
            }

            else if (e.CommandName == "alterar")
            {
                Carta c = CartasDAO.Selecionar(id);
                txtNome.Value = c.Nome;
                nmrNivel.Value = Convert.ToString(c.Nivel);
                txtNumero.Value = c.Numero;
                nmrPtnAtaque.Value = Convert.ToString(c.PtnAtaque);
                nmrPtnDefesa.Value = Convert.ToString(c.PtnDefesa);

                btnCadastrar.Text = "Alterar";
                lgFieldset.InnerText = "ALTERAR";
                hfid.Value = c.IdCarta.ToString();
                lblMensagem.InnerText = "Vá para cima para alterar a carta desejada";
            }*/
        }

        
        protected void ibDelete_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Carta c = CartasDAO.Excluir(id);
            if (c != null)
            {
                lblMensagem.InnerText = "A carta \"" + c.Nome + "\" foi excluída com sucesso";
            }
            else
            {
                lblMensagem.InnerText = "Não foi possível excluir a carta desejada";
            }

            AtualizarListViewCartas();
        }

        protected void ibAlterar_Command(object sender, CommandEventArgs e)
        {
            
            
            int id = Convert.ToInt32(e.CommandArgument);
            Carta c = CartasDAO.SelecionarCarta(id);
            Atributo at = CartasDAO.SelecionarAtributo(c);
            Icone i = CartasDAO.SelecionarIcone(c);
            Tipo ti = CartasDAO.SelecionarTipo(c);

            if (ti.Descricao.Contains("Monstro"))
            {
                CrtMonstro mo = CartasDAO.SelecionarMonstro(ti);
                DivMonstro.Visible = true;
                DivArmadilha.Visible = false;
                DivMagia.Visible = false;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;

                

                ddlMonstros.SelectedIndex = Convert.ToInt32(mo.Index);
                
                if(mo.EfeitoId != null)
                {
                    MnstEfeito ef = CartasDAO.SelecionarMonstroEfeito(mo);
                    DivEfeitos.Visible = true;
                    ddlEfeitos.SelectedIndex = Convert.ToInt32(ef.Index);

                    if(ef.PenduloId != null)
                    {
                        EfPendulo pe = CartasDAO.SelecionarMonstroPendulo(ef);
                        DivPendulos.Visible = true;
                        ddlPendulos.SelectedIndex = Convert.ToInt32(pe.Index);

                    }
                }
                
            }
            else if (ti.Descricao.Contains("Armadilha"))
            {

                CrtArmadilha ar = CartasDAO.SelecionarArmadilha(ti);
                DivMonstro.Visible = false;
                DivArmadilha.Visible = true;
                DivMagia.Visible = false;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;

                ddlArmadilhas.SelectedIndex = Convert.ToInt32(ti.Index);

            }
            else if (ti.Descricao.Contains("Magia"))
            {
                CrtMagia ma = CartasDAO.SelecionarMagia(ti);
                DivMonstro.Visible = false;
                DivArmadilha.Visible = false;
                DivMagia.Visible = true;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;

                ddlMagias.SelectedIndex = Convert.ToInt32(ti.Index);
            }

            txtNome.Value = c.Nome;
            nmrNivel.Value = Convert.ToString(c.Nivel);
            ddlTipo.SelectedIndex = Convert.ToInt32(ti.Index);
            ddlAtributo.SelectedIndex = Convert.ToInt32(at.Index);
            ddlIcone.SelectedIndex = Convert.ToInt32(i.Index);
            txtNumero.Value = c.Numero;
            nmrPtnAtaque.Value = Convert.ToString(c.PtnAtaque);
            nmrPtnDefesa.Value = Convert.ToString(c.PtnDefesa);
            txtDescricao.Value = c.Descricao;

            btnCadastrar.Text = "Alterar";
            lgFieldset.InnerText = "ALTERAR";
            hfid.Value = c.IdCarta.ToString();
            lblMensagem.InnerText = "Vá para cima para alterar a carta desejada";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YuGiOh
{
    public partial class FrmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtLogin.Value != "" && txtSenha.Value != "" && txtLogin.Value != " " && txtSenha.Value != " ")
            {
                string login = txtLogin.Value;
                string senhaNormal = txtSenha.Value;

                Usuario user = UsuarioDAO.VerificarLogin(login);

                if(user != null)
                {
                    string senhaCriptografada = FormsAuthentication.HashPasswordForStoringInConfigFile(senhaNormal, "SHA1");

                    if(user.Senha == senhaCriptografada)
                    {

                        LogAcesso log = new LogAcesso();

                        log.UsuarioId = user.IdUsuario;
                        log.UltimoAcesso = DateTime.Now;

                        user.UltimoAcesso = DateTime.Now;

                        Usuario user_atualizado = UsuarioDAO.UltimoAcesso(user);
                        LogDAO.Registrar(log);

                        Session["user"] = user_atualizado;
                        FormsAuthentication.SetAuthCookie(user.Nome, true);

                        Page.Response.Redirect("~/FrmCartas.aspx");

                        //Falta colocar o Log de acesso do usuário
                    }
                    else
                    {
                        lblMensagem.InnerText = "Senha incorreta";
                    }
                }
                else
                {
                    lblMensagem.InnerText = "O login informado não existe. Tente Cadastrá-lo no link acima";
                }
            }
            else
            {
                lblMensagem.InnerText = "Você não preencheu todos os campos";
            }
        }
    }
}
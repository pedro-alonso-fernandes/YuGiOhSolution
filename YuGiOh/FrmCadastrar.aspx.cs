using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YuGiOh
{
    public partial class FrmCadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }


        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtNome.Value != "" && txtData.Text != "" && txtLogin.Value != "" && txtSenha.Value != "" && txtConfirmarSenha.Value != ""      &&        txtNome.Value != " " && txtLogin.Value != " " && txtSenha.Value != " " && txtConfirmarSenha.Value != " ")
            {
                Usuario user = UsuarioDAO.VerificarLogin(txtLogin.Value);

                if (user == null)
                {
                    if(txtSenha.Value == txtConfirmarSenha.Value)
                    {
                        
                        string senha = txtSenha.Value;
                        string senhaCriptografada = FormsAuthentication.HashPasswordForStoringInConfigFile(senha, "SHA1");

                        Usuario u = new Usuario();

                        u.Nome = txtNome.Value;
                        u.Nascimento = Convert.ToDateTime(txtData.Text);
                        u.Login = txtLogin.Value;
                        u.Senha = senhaCriptografada;

                        string mensagem = UsuarioDAO.Cadastrar(u);

                        txtNome.Value = "";
                        txtData.Text = "";
                        txtLogin.Value = "";
                        txtSenha.Value = "";
                        txtConfirmarSenha.Value = "";

                        lblMensagem.InnerText = mensagem;

                    }
                    else
                    {
                        lblMensagem.InnerText = "Você digitou senhas diferentes nos campos \"Crie uma senha\" e \"Confirmar Senha\"";
                    }
                }
                else
                {
                    lblMensagem.InnerText = "Já existe um usuário com esse login";
                }
            }
            else
            {
                lblMensagem.InnerText = "Você não preencheu todos os campos";
            }
        }
    }
}
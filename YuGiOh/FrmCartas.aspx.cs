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
            if (!Page.IsPostBack) { 

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

            if(valorSelecionado.Contains("Monstro"))
            {
                DivMonstro.Visible = true;
                DivArmadilha.Visible = false;
                DivMagia.Visible = false;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;

            }
            
            else if(valorSelecionado.Contains("Armadilha"))
            {
                DivMonstro.Visible = false;
                DivArmadilha.Visible = true;
                DivMagia.Visible = false;
                DivEfeitos.Visible = false;
                DivPendulos.Visible = false;

            }

            else if(valorSelecionado.Contains("Magia"))
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
    }
}
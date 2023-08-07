using System;
using System.Linq;

namespace YuGiOh
{
    internal class UsuarioDAO
    {
        internal static Usuario VerificarLogin(string value)
        {
            Usuario user = null;

            try
            {
                
                using (var ctx = new YuGiOhDBEntities())
                {
                    user = ctx.Usuarios.FirstOrDefault(x => x.Login == value);

                }
            }catch(Exception ex)
            {

            }
            return user;
        }

        internal static string Cadastrar(Usuario u)
        {
            string mg = "";

            try{

                using(var ctx = new YuGiOhDBEntities())
                {
                    ctx.Usuarios.Add(u);
                    ctx.SaveChanges();
    
                }

                mg = "Usuario Cadastrado com Sucesso!";

            }
            catch(Exception ex)
            {
                mg = "Erro: " + ex.Message;
            }

            return mg;
        }

        internal static Usuario UltimoAcesso(Usuario user)
        {
            Usuario user_antigo = null;

            try
            {
                

                using(var ctx = new YuGiOhDBEntities())
                {
                    user_antigo = ctx.Usuarios.FirstOrDefault(x => x.IdUsuario == user.IdUsuario);
                    user_antigo.UltimoAcesso = user.UltimoAcesso;
                    ctx.SaveChanges();
                }


            }catch(Exception ex)
            {

            }

            return user_antigo;
        }
    }
}
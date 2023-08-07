using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuGiOh
{
    public class LogDAO
    {
        internal static void Registrar(LogAcesso log)
        {
            try
            {

                using(var ctx = new YuGiOhDBEntities())
                {
                    ctx.LogAcessoes.Add(log);
                    ctx.SaveChanges();
                }

            }catch(Exception ex)
            {

            }
        }
    }
}
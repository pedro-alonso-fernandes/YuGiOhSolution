using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuGiOh
{
    public class Cartas
    {
        internal static string CadastrarMonstro(Carta c, Atributo at, Icone i, Tipo ti, CrtMonstro mo)
        {
            string msn = null;
            try
            {
                using(var ctx = new YuGiOhDBEntities())
                {
                    ctx.CrtMonstroes.Add(mo);
                    ctx.Atributoes.Add(at);
                    ctx.Icones.Add(i);
                    ctx.SaveChanges();

                    CrtMonstro monstro = ctx.CrtMonstroes.FirstOrDefault(x => x.Descricao == mo.Descricao);
                    Atributo atributo = ctx.Atributoes.FirstOrDefault(x => x.Descricao == at.Descricao);
                    Icone icone = ctx.Icones.FirstOrDefault(x => x.Descricao == i.Descricao);

                    ti.MonstroId = monstro.IdMonstro;

                    ctx.Tipoes.Add(ti);
                    ctx.SaveChanges();

                    Tipo tipo = ctx.Tipoes.FirstOrDefault(x => x.Descricao == ti.Descricao);

                    c.AtributoId = atributo.IdAtributo;
                    c.IconeId = icone.IdIcone;
                    c.TipoId = tipo.IdTipo;

                    ctx.Cartas.Add(c);
                    ctx.SaveChanges();

                    msn = "Carta cadastrada com sucesso";
                }
            }
            catch(Exception ex)
            {
                msn = "Algo deu errado!";
            }
            return msn;
        }

        internal static string CadastrarMonstroEfeito(Carta c, Atributo at, Icone i, Tipo ti, CrtMonstro mo, MnstEfeito ef)
        {
            string msn = null;

            try
            {

                using(var ctx = new YuGiOhDBEntities())
                {
                    ctx.MnstEfeitoes.Add(ef);
                    ctx.Atributoes.Add(at);
                    ctx.Icones.Add(i);
                    ctx.SaveChanges();

                    MnstEfeito efeito = ctx.MnstEfeitoes.FirstOrDefault(x => x.Descricao == ef.Descricao);
                    Atributo atributo = ctx.Atributoes.FirstOrDefault(x => x.Descricao == at.Descricao);
                    Icone icone = ctx.Icones.FirstOrDefault(x => x.Descricao == i.Descricao);

                    mo.EfeitoId = efeito.IdEfeito;

                    ctx.CrtMonstroes.Add(mo);
                    ctx.SaveChanges();

                    CrtMonstro monstro = ctx.CrtMonstroes.FirstOrDefault(x => x.Descricao == mo.Descricao);

                    ti.MonstroId = monstro.IdMonstro;

                    ctx.Tipoes.Add(ti);
                    ctx.SaveChanges();

                    Tipo tipo = ctx.Tipoes.FirstOrDefault(x => x.Descricao == ti.Descricao);

                    c.AtributoId = atributo.IdAtributo;
                    c.IconeId = icone.IdIcone;
                    c.TipoId = tipo.IdTipo;

                    ctx.Cartas.Add(c);
                    ctx.SaveChanges();

                    msn = "Carta cadastrada com sucesso";
                }

            }catch(Exception ex)
            {
                msn = "Algo deu errado!";
            }

            return msn;
        }

        internal static string CadastrarMonstroPendulo(Carta c, Atributo at, Icone i, Tipo ti, CrtMonstro mo, MnstEfeito ef, EfPendulo pe)
        {
            string msn = null;

            try
            {

                using(var ctx = new YuGiOhDBEntities())
                {
                    ctx.EfPenduloes.Add(pe);
                    ctx.Atributoes.Add(at);
                    ctx.Icones.Add(i);
                    ctx.SaveChanges();

                    EfPendulo pendulo = ctx.EfPenduloes.FirstOrDefault(x => x.Descricao == pe.Descricao);
                    Atributo atributo = ctx.Atributoes.FirstOrDefault(x => x.Descricao == at.Descricao);
                    Icone icone = ctx.Icones.FirstOrDefault(x => x.Descricao == i.Descricao);

                    ef.PenduloId = pe.IdPendulo;

                    ctx.MnstEfeitoes.Add(ef);
                    ctx.SaveChanges();

                    MnstEfeito efeito = ctx.MnstEfeitoes.FirstOrDefault(x => x.Descricao == ef.Descricao);   
                    
                    mo.EfeitoId = efeito.IdEfeito;

                    ctx.CrtMonstroes.Add(mo);
                    ctx.SaveChanges();

                    CrtMonstro monstro = ctx.CrtMonstroes.FirstOrDefault(x => x.Descricao == mo.Descricao);

                    ti.MonstroId = monstro.IdMonstro;

                    ctx.Tipoes.Add(ti);
                    ctx.SaveChanges();

                    Tipo tipo = ctx.Tipoes.FirstOrDefault(x => x.Descricao == ti.Descricao);

                    c.AtributoId = atributo.IdAtributo;
                    c.IconeId = icone.IdIcone;
                    c.TipoId = tipo.IdTipo;

                    ctx.Cartas.Add(c);
                    ctx.SaveChanges();

                    msn = "Carta cadastrada com sucesso";
                }

            }catch(Exception ex)
            {
                msn = "Algo deu errado!";
            }
            return msn;
        }
    }
}
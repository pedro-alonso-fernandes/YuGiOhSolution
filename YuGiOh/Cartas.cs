using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuGiOh
{
    public class Cartas
    {
        internal static string CadastrarMonstroPendulo(Carta c, Atributo at, Icone i, Tipo ti, CrtMonstro mo, MnstEfeito ef, EfPendulo pe, CrtImagem img)
        {
            string msn = null;

            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {
                    ctx.EfPenduloes.Add(pe);
                    ctx.Atributoes.Add(at);
                    ctx.Icones.Add(i);
                    ctx.CrtImagems.Add(img);
                    ctx.SaveChanges();

                    EfPendulo pendulo = ctx.EfPenduloes.OrderByDescending(x => x.IdPendulo).FirstOrDefault(x => x.Descricao == pe.Descricao);
                    Atributo atributo = ctx.Atributoes.OrderByDescending(x => x.IdAtributo).FirstOrDefault(x => x.Descricao == at.Descricao);
                    Icone icone = ctx.Icones.OrderByDescending(x => x.IdIcone).FirstOrDefault(x => x.Descricao == i.Descricao);
                    CrtImagem imagem = ctx.CrtImagems.OrderByDescending(x => x.IdImagem).FirstOrDefault(x => x.Nome == img.Nome);

                    ef.PenduloId = pe.IdPendulo;

                    ctx.MnstEfeitoes.Add(ef);
                    ctx.SaveChanges();

                    MnstEfeito efeito = ctx.MnstEfeitoes.OrderByDescending(x => x.IdEfeito).FirstOrDefault(x => x.Descricao == ef.Descricao);

                    mo.EfeitoId = efeito.IdEfeito;

                    ctx.CrtMonstroes.Add(mo);
                    ctx.SaveChanges();

                    CrtMonstro monstro = ctx.CrtMonstroes.OrderByDescending(x => x.IdMonstro).FirstOrDefault(x => x.Descricao == mo.Descricao);

                    ti.MonstroId = monstro.IdMonstro;

                    ctx.Tipoes.Add(ti);
                    ctx.SaveChanges();

                    Tipo tipo = ctx.Tipoes.OrderByDescending(x => x.IdTipo).FirstOrDefault(x => x.Descricao == ti.Descricao);

                    c.AtributoId = atributo.IdAtributo;
                    c.IconeId = icone.IdIcone;
                    c.TipoId = tipo.IdTipo;
                    c.ImagemId = imagem.IdImagem;

                    ctx.Cartas.Add(c);
                    ctx.SaveChanges();

                    msn = "Carta cadastrada com sucesso";
                }

            }
            catch (Exception ex)
            {
                msn = "Algo deu errado!";
            }
            return msn;
        }

        internal static string CadastrarMonstroEfeito(Carta c, Atributo at, Icone i, Tipo ti, CrtMonstro mo, MnstEfeito ef, CrtImagem img)
        {
            string msn = null;

            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {
                    ctx.MnstEfeitoes.Add(ef);
                    ctx.Atributoes.Add(at);
                    ctx.Icones.Add(i);
                    ctx.CrtImagems.Add(img);
                    ctx.SaveChanges();

                    MnstEfeito efeito = ctx.MnstEfeitoes.OrderByDescending(x => x.IdEfeito).FirstOrDefault(x => x.Descricao == ef.Descricao);
                    Atributo atributo = ctx.Atributoes.OrderByDescending(x => x.IdAtributo).FirstOrDefault(x => x.Descricao == at.Descricao);
                    Icone icone = ctx.Icones.OrderByDescending(x => x.IdIcone).FirstOrDefault(x => x.Descricao == i.Descricao);
                    CrtImagem imagem = ctx.CrtImagems.OrderByDescending(x => x.IdImagem).FirstOrDefault(x => x.Nome == img.Nome);

                    mo.EfeitoId = efeito.IdEfeito;

                    ctx.CrtMonstroes.Add(mo);
                    ctx.SaveChanges();

                    CrtMonstro monstro = ctx.CrtMonstroes.OrderByDescending(x => x.IdMonstro).FirstOrDefault(x => x.Descricao == mo.Descricao);

                    ti.MonstroId = monstro.IdMonstro;

                    ctx.Tipoes.Add(ti);
                    ctx.SaveChanges();

                    Tipo tipo = ctx.Tipoes.OrderByDescending(x => x.IdTipo).FirstOrDefault(x => x.Descricao == ti.Descricao);

                    c.AtributoId = atributo.IdAtributo;
                    c.IconeId = icone.IdIcone;
                    c.TipoId = tipo.IdTipo;
                    c.ImagemId = imagem.IdImagem;

                    ctx.Cartas.Add(c);
                    ctx.SaveChanges();

                    msn = "Carta cadastrada com sucesso";
                }

            }
            catch (Exception ex)
            {
                msn = "Algo deu errado!";
            }

            return msn;
        }

        internal static string CadastrarMonstro(Carta c, Atributo at, Icone i, Tipo ti, CrtMonstro mo, CrtImagem img)
        {
            string msn = null;
            try
            {
                using (var ctx = new YuGiOhDBEntities())
                {
                    ctx.CrtMonstroes.Add(mo);
                    ctx.Atributoes.Add(at);
                    ctx.Icones.Add(i);
                    ctx.CrtImagems.Add(img);
                    ctx.SaveChanges();

                    CrtMonstro monstro = ctx.CrtMonstroes.OrderByDescending(x => x.IdMonstro).FirstOrDefault(x => x.Descricao == mo.Descricao);
                    Atributo atributo = ctx.Atributoes.OrderByDescending(x => x.IdAtributo).FirstOrDefault(x => x.Descricao == at.Descricao);
                    Icone icone = ctx.Icones.OrderByDescending(x => x.IdIcone).FirstOrDefault(x => x.Descricao == i.Descricao);
                    CrtImagem imagem = ctx.CrtImagems.OrderByDescending(x => x.IdImagem).FirstOrDefault(x => x.Nome == img.Nome);

                    ti.MonstroId = monstro.IdMonstro;

                    ctx.Tipoes.Add(ti);
                    ctx.SaveChanges();

                    Tipo tipo = ctx.Tipoes.OrderByDescending(x => x.IdTipo).FirstOrDefault(x => x.Descricao == ti.Descricao);

                    c.AtributoId = atributo.IdAtributo;
                    c.IconeId = icone.IdIcone;
                    c.TipoId = tipo.IdTipo;
                    c.ImagemId = imagem.IdImagem;

                    ctx.Cartas.Add(c);
                    ctx.SaveChanges();

                    msn = "Carta cadastrada com sucesso";
                }
            }
            catch (Exception ex)
            {
                msn = "Algo deu errado!";
            }
            return msn;
        }

        internal static string CadastrarArmadilha(Carta c, Atributo at, Icone i, Tipo ti, CrtArmadilha ar, CrtImagem img)
        {
            string msn = null;
            try
            {
                using (var ctx = new YuGiOhDBEntities())
                {
                    ctx.CrtArmadilhas.Add(ar);
                    ctx.Atributoes.Add(at);
                    ctx.Icones.Add(i);
                    ctx.CrtImagems.Add(img);
                    ctx.SaveChanges();

                    CrtArmadilha armadilha = ctx.CrtArmadilhas.OrderByDescending(x => x.IdArmadilha).FirstOrDefault(x => x.Descricao == ar.Descricao);
                    Atributo atributo = ctx.Atributoes.OrderByDescending(x => x.IdAtributo).FirstOrDefault(x => x.Descricao == at.Descricao);
                    Icone icone = ctx.Icones.OrderByDescending(x => x.IdIcone).FirstOrDefault(x => x.Descricao == i.Descricao);
                    CrtImagem imagem = ctx.CrtImagems.OrderByDescending(x => x.IdImagem).FirstOrDefault(x => x.Nome == img.Nome);

                    ti.ArmadilhaId = ar.IdArmadilha;

                    ctx.Tipoes.Add(ti);
                    ctx.SaveChanges();

                    Tipo tipo = ctx.Tipoes.OrderByDescending(x => x.IdTipo).FirstOrDefault(x => x.Descricao == ti.Descricao);

                    c.AtributoId = atributo.IdAtributo;
                    c.IconeId = icone.IdIcone;
                    c.TipoId = tipo.IdTipo;
                    c.ImagemId = imagem.IdImagem;

                    ctx.Cartas.Add(c);
                    ctx.SaveChanges();

                    msn = "Carta cadastrada com sucesso";
                }
            }
            catch (Exception ex)
            {
                msn = "Algo deu errado!";
            }
            return msn;
        }

        internal static string CadastrarMagia(Carta c, Atributo at, Icone i, Tipo ti, CrtMagia ma, CrtImagem img)
        {
            string msn = null;
            try
            {
                using (var ctx = new YuGiOhDBEntities())
                {
                    ctx.CrtMagias.Add(ma);
                    ctx.Atributoes.Add(at);
                    ctx.Icones.Add(i);
                    ctx.CrtImagems.Add(img);
                    ctx.SaveChanges();

                    CrtMagia magia = ctx.CrtMagias.OrderByDescending(x => x.IdMagia).FirstOrDefault(x => x.Descricao == ma.Descricao);
                    Atributo atributo = ctx.Atributoes.OrderByDescending(x => x.IdAtributo).FirstOrDefault(x => x.Descricao == at.Descricao);
                    Icone icone = ctx.Icones.OrderByDescending(x => x.IdIcone).FirstOrDefault(x => x.Descricao == i.Descricao);
                    CrtImagem imagem = ctx.CrtImagems.OrderByDescending(x => x.IdImagem).FirstOrDefault(x => x.Nome == img.Nome);

                    ti.MagiaId = ma.IdMagia;

                    ctx.Tipoes.Add(ti);
                    ctx.SaveChanges();

                    Tipo tipo = ctx.Tipoes.OrderByDescending(x => x.IdTipo).FirstOrDefault(x => x.Descricao == ti.Descricao);

                    c.AtributoId = atributo.IdAtributo;
                    c.IconeId = icone.IdIcone;
                    c.TipoId = tipo.IdTipo;
                    c.ImagemId = imagem.IdImagem;

                    ctx.Cartas.Add(c);
                    ctx.SaveChanges();

                    msn = "Carta cadastrada com sucesso";
                }
            }
            catch (Exception ex)
            {
                msn = "Algo deu errado!";
            }
            return msn;
        }
    }
}
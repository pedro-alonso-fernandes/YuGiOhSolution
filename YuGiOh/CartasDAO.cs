using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuGiOh
{
    public class CartasDAO
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

       

        internal static List<Carta> ListarCartas()
        {
            List<Carta> lista = null;

            try
            {
                using(var ctx = new YuGiOhDBEntities())
                {
                    lista = ctx.Cartas.OrderBy(ordenar => ordenar.Nome).ToList();
                }


            }catch(Exception ex)
            {

            }

            return lista;
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

        internal static Carta Excluir(int id)
        {
            Carta carta = null;
            
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {
                    carta = ctx.Cartas.FirstOrDefault(x => x.IdCarta == id);

                    ctx.Cartas.Remove(carta);
                    ctx.SaveChanges();
                }

            }catch(Exception ex)
            {

            }

            return carta;
        }

        internal static Carta SelecionarCarta(int id)
        {
            Carta carta = null;
            try
            {

                using(var ctx = new YuGiOhDBEntities())
                {
                    carta = ctx.Cartas.FirstOrDefault(x => x.IdCarta == id);
                }

            }catch(Exception ex)
            {

            }

            return carta;
        }

        internal static Tipo SelecionarTipo(Carta c)
        {
            Tipo tipo = null;
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    tipo = ctx.Tipoes.FirstOrDefault(x => x.IdTipo == c.TipoId);

                }

            }
            catch (Exception ex)
            {

            }

            return tipo;
        }

        internal static Atributo SelecionarAtributo(Carta c)
        {
            Atributo atributo = null;
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    atributo = ctx.Atributoes.FirstOrDefault(x => x.IdAtributo == c.AtributoId);

                }

            }
            catch (Exception ex)
            {

            }

            return atributo;
        }

       

        internal static CrtMonstro SelecionarMonstro(Tipo ti)
        {
            CrtMonstro monstro = null;
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    monstro = ctx.CrtMonstroes.FirstOrDefault(x => x.IdMonstro == ti.MonstroId);

                }

            }
            catch (Exception ex)
            {

            }

            return monstro;
        }

        internal static CrtArmadilha SelecionarArmadilha(Tipo ti)
        {
            CrtArmadilha armadilha = null;
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    armadilha = ctx.CrtArmadilhas.FirstOrDefault(x => x.IdArmadilha == ti.ArmadilhaId);

                }

            }
            catch (Exception ex)
            {

            }

            return armadilha;
        }

        internal static CrtMagia SelecionarMagia(Tipo ti)
        {
            CrtMagia magia = null;
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    magia = ctx.CrtMagias.FirstOrDefault(x => x.IdMagia == ti.MagiaId);

                }

            }
            catch (Exception ex)
            {

            }

            return magia;
        }

        internal static Icone SelecionarIcone(Carta c)
        {
            Icone icone = null;
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    icone = ctx.Icones.FirstOrDefault(x => x.IdIcone == c.IconeId);

                }

            }
            catch (Exception ex)
            {

            }

            return icone;
        }

        internal static MnstEfeito SelecionarMonstroEfeito(CrtMonstro mo)
        {
            MnstEfeito efeito = null;
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    efeito = ctx.MnstEfeitoes.FirstOrDefault(x => x.IdEfeito == mo.EfeitoId);

                }

            }
            catch (Exception ex)
            {

            }

            return efeito;
        }

        internal static EfPendulo SelecionarMonstroPendulo(MnstEfeito ef)
        {
            EfPendulo pendulo = null;
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    pendulo = ctx.EfPenduloes.FirstOrDefault(x => x.IdPendulo == ef.PenduloId);

                }

            }
            catch (Exception ex)
            {

            }

            return pendulo;
        }
    }
}
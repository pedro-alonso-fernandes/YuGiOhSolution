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
                using (var ctx = new YuGiOhDBEntities())
                {
                    lista = ctx.Cartas.OrderBy(ordenar => ordenar.Nome).ToList();
                }


            }
            catch (Exception ex)
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

            Tipo tipo = null;
            Atributo atributo = null;
            Icone icone = null;
            CrtImagem imagem = null;

            CrtMonstro monstro = null;
            CrtArmadilha armadilha = null;
            CrtMagia magia = null;

            MnstEfeito efeito = null;
            EfPendulo pendulo = null;

            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {
                    carta = ctx.Cartas.FirstOrDefault(x => x.IdCarta == id);

                    tipo = ctx.Tipoes.FirstOrDefault(x => x.IdTipo == carta.TipoId);
                    atributo = ctx.Atributoes.FirstOrDefault(x => x.IdAtributo == carta.AtributoId);
                    icone = ctx.Icones.FirstOrDefault(x => x.IdIcone == carta.IconeId);
                    imagem = ctx.CrtImagems.FirstOrDefault(x => x.IdImagem == carta.ImagemId);

                    if (tipo.Descricao.Contains("Monstro"))
                    {
                        monstro = ctx.CrtMonstroes.FirstOrDefault(x => x.IdMonstro == tipo.MonstroId);

                        if (monstro.EfeitoId != null)
                        {
                            efeito = ctx.MnstEfeitoes.FirstOrDefault(x => x.IdEfeito == monstro.EfeitoId);

                            if (efeito.PenduloId != null)
                            {
                                pendulo = ctx.EfPenduloes.FirstOrDefault(x => x.IdPendulo == efeito.PenduloId);
                            }
                        }
                    }
                    else if (tipo.Descricao.Contains("Armadilha"))
                    {
                        armadilha = ctx.CrtArmadilhas.FirstOrDefault(x => x.IdArmadilha == tipo.ArmadilhaId);
                    }
                    else if (tipo.Descricao.Contains("Armadilha"))
                    {
                        magia = ctx.CrtMagias.FirstOrDefault(x => x.IdMagia == tipo.MagiaId);
                    }


                    ctx.Cartas.Remove(carta);
                    ctx.SaveChanges();

                    ctx.Tipoes.Remove(tipo);
                    ctx.SaveChanges();
                    ctx.Atributoes.Remove(atributo);
                    ctx.SaveChanges();
                    ctx.Icones.Remove(icone);
                    ctx.SaveChanges();
                    ctx.CrtImagems.Remove(imagem);
                    ctx.SaveChanges();

                    if (tipo.Descricao.Contains("Monstro"))
                    {
                        if (monstro.EfeitoId != null)
                        {

                            if (efeito.PenduloId != null)
                            {
                                ctx.CrtMonstroes.Remove(monstro);
                                ctx.SaveChanges();
                                ctx.MnstEfeitoes.Remove(efeito);
                                ctx.SaveChanges();
                                ctx.EfPenduloes.Remove(pendulo);
                                ctx.SaveChanges();
                            }
                            else
                            {
                                ctx.CrtMonstroes.Remove(monstro);
                                ctx.SaveChanges();
                                ctx.MnstEfeitoes.Remove(efeito);
                                ctx.SaveChanges();
                            }

                        }
                        else
                        {
                            ctx.CrtMonstroes.Remove(monstro);
                            ctx.SaveChanges();
                        }

                    }
                    else if (tipo.Descricao.Contains("Armadilha"))
                    {
                        ctx.CrtArmadilhas.Remove(armadilha);
                    }
                    else if (tipo.Descricao.Contains("Armadilha"))
                    {
                        ctx.CrtMagias.Remove(magia);
                    }


                    //ctx.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }

            return carta;
        }

        internal static Carta SelecionarCarta(int id)
        {
            Carta carta = null;
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {
                    carta = ctx.Cartas.FirstOrDefault(x => x.IdCarta == id);
                }

            }
            catch (Exception ex)
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

        internal static CrtImagem SelecionarImagem(Carta c)
        {
            CrtImagem imagem = null;
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    imagem = ctx.CrtImagems.FirstOrDefault(x => x.IdImagem == c.ImagemId);

                }

            }
            catch (Exception ex)
            {

            }

            return imagem;
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



        internal static string AlterarMonstroNovo(Carta c, Carta carta, Atributo at, Icone ic, Tipo tipo, CrtMonstro monstro, CrtImagem img)
        {
            string msn = "";
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    Atributo atributoAntigo = SelecionarAtributo(c);
                    Icone iconeAntigo = SelecionarIcone(c);
                    Tipo tipoAntigo = SelecionarTipo(c);
                    CrtImagem imagemAntigo = SelecionarImagem(c);

                    ctx.CrtMonstroes.Add(monstro);
                    ctx.SaveChanges();

                    CrtMonstro mo = ctx.CrtMonstroes.OrderByDescending(x => x.IdMonstro).FirstOrDefault(x => x.Descricao == monstro.Descricao);
                    tipo.MonstroId = mo.IdMonstro;

                    ctx.Tipoes.Add(tipo);
                    ctx.SaveChanges();

                    Tipo t = ctx.Tipoes.OrderByDescending(x => x.IdTipo).FirstOrDefault(x => x.Descricao == tipo.Descricao);

                    carta.AtributoId = atributoAntigo.IdAtributo;
                    carta.IconeId = iconeAntigo.IdIcone;
                    carta.ImagemId = imagemAntigo.IdImagem;
                    carta.TipoId = t.IdTipo;

                    ctx.Cartas.Add(carta);
                    ctx.SaveChanges();

                    atributoAntigo.Descricao = at.Descricao;
                    atributoAntigo.Index = at.Index;

                    iconeAntigo.Descricao = ic.Descricao;
                    iconeAntigo.Index = ic.Index;

                    imagemAntigo.Nome = img.Nome;
                    imagemAntigo.Src = img.Src;



                    if (tipoAntigo.Descricao.Contains("Armadilha"))
                    {

                        CrtArmadilha armadilha = SelecionarArmadilha(tipoAntigo);

                        ctx.CrtArmadilhas.Attach(armadilha);
                        ctx.Cartas.Attach(c);
                        ctx.Tipoes.Attach(tipoAntigo);

                        ctx.Cartas.Remove(c);
                        ctx.Tipoes.Remove(tipoAntigo);
                        ctx.CrtArmadilhas.Remove(armadilha);
                    }
                    else if (tipoAntigo.Descricao.Contains("Magia"))
                    {
                        CrtMagia magia = SelecionarMagia(tipoAntigo);

                        ctx.CrtMagias.Attach(magia);
                        ctx.Cartas.Attach(c);
                        ctx.Tipoes.Attach(tipoAntigo);

                        ctx.Cartas.Remove(c);
                        ctx.Tipoes.Remove(tipoAntigo);
                        ctx.CrtMagias.Remove(magia);
                    }

                    ctx.SaveChanges();

                    msn = "Alteração feita com sucesso";
                }

            }
            catch (Exception ex)
            {
                msn = "Algo deu Errado!";
            }

            return msn;
        }

        internal static string AlterarMonstroPenduloNovo(Carta c, Carta carta, Atributo at, Icone ic, Tipo tipo, CrtMonstro monstro, MnstEfeito efeito, EfPendulo pendulo, CrtImagem img)
        {
            string msn = "";
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    Atributo atributoAntigo = SelecionarAtributo(c);
                    Icone iconeAntigo = SelecionarIcone(c);
                    Tipo tipoAntigo = SelecionarTipo(c);
                    CrtImagem imagemAntigo = SelecionarImagem(c);

                    ctx.EfPenduloes.Add(pendulo);
                    ctx.SaveChanges();

                    EfPendulo pe = ctx.EfPenduloes.OrderByDescending(x => x.IdPendulo).FirstOrDefault(x => x.Descricao == pendulo.Descricao);
                    efeito.PenduloId = pe.IdPendulo;

                    ctx.MnstEfeitoes.Add(efeito);
                    ctx.SaveChanges();

                    MnstEfeito ef = ctx.MnstEfeitoes.OrderByDescending(x => x.IdEfeito).FirstOrDefault(x => x.Descricao == efeito.Descricao);
                    monstro.EfeitoId = ef.IdEfeito;


                    ctx.CrtMonstroes.Add(monstro);
                    ctx.SaveChanges();

                    CrtMonstro mo = ctx.CrtMonstroes.OrderByDescending(x => x.IdMonstro).FirstOrDefault(x => x.Descricao == monstro.Descricao);
                    tipo.MonstroId = mo.IdMonstro;

                    ctx.Tipoes.Add(tipo);
                    ctx.SaveChanges();

                    Tipo t = ctx.Tipoes.OrderByDescending(x => x.IdTipo).FirstOrDefault(x => x.Descricao == tipo.Descricao);

                    carta.AtributoId = atributoAntigo.IdAtributo;
                    carta.IconeId = iconeAntigo.IdIcone;
                    carta.ImagemId = imagemAntigo.IdImagem;
                    carta.TipoId = t.IdTipo;

                    ctx.Cartas.Add(carta);
                    ctx.SaveChanges();

                    atributoAntigo.Descricao = at.Descricao;
                    atributoAntigo.Index = at.Index;

                    iconeAntigo.Descricao = ic.Descricao;
                    iconeAntigo.Index = ic.Index;

                    imagemAntigo.Nome = img.Nome;
                    imagemAntigo.Src = img.Src;



                    if (tipoAntigo.Descricao.Contains("Armadilha"))
                    {

                        CrtArmadilha armadilha = SelecionarArmadilha(tipoAntigo);

                        ctx.CrtArmadilhas.Attach(armadilha);
                        ctx.Cartas.Attach(c);
                        ctx.Tipoes.Attach(tipoAntigo);

                        ctx.Cartas.Remove(c);
                        ctx.Tipoes.Remove(tipoAntigo);
                        ctx.CrtArmadilhas.Remove(armadilha);
                    }
                    else if (tipoAntigo.Descricao.Contains("Magia"))
                    {
                        CrtMagia magia = SelecionarMagia(tipoAntigo);

                        ctx.CrtMagias.Attach(magia);
                        ctx.Cartas.Attach(c);
                        ctx.Tipoes.Attach(tipoAntigo);

                        ctx.Cartas.Remove(c);
                        ctx.Tipoes.Remove(tipoAntigo);
                        ctx.CrtMagias.Remove(magia);
                    }

                    ctx.SaveChanges();

                    msn = "Alteração feita com sucesso";
                }

            }
            catch (Exception ex)
            {
                msn = "Algo deu Errado!";
            }

            return msn;
        }

        internal static string AlterarMonstro(Carta c, Atributo at, Icone ic, Tipo ti, CrtMonstro mo, CrtImagem img)
        {
            string msn = "";
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {
                    Carta cartaAntigo = SelecionarCarta(c.IdCarta);
                    
                    Atributo atributoAntigo = SelecionarAtributo(c);
                    Icone iconeAntigo = SelecionarIcone(c);
                    Tipo tipoAntigo = SelecionarTipo(c);
                    CrtImagem imagemAntigo = SelecionarImagem(c);

                    CrtMonstro monstroAntigo = SelecionarMonstro(ti);

                    cartaAntigo.Nome = c.Nome;
                    cartaAntigo.Nivel = c.Nivel;
                    cartaAntigo.Numero = c.Numero;
                    cartaAntigo.PtnAtaque = c.PtnAtaque;
                    cartaAntigo.PtnDefesa = c.PtnDefesa;
                    cartaAntigo.Descricao = c.Descricao;

                    atributoAntigo.Descricao = at.Descricao;
                    atributoAntigo.Index = at.Index;

                    iconeAntigo.Descricao = ic.Descricao;
                    iconeAntigo.Index = ic.Index;

                    tipoAntigo.Descricao = ti.Descricao;
                    tipoAntigo.Index = ti.Index;

                    imagemAntigo.Nome = img.Nome;
                    imagemAntigo.Src = img.Src;

                    monstroAntigo.Descricao = mo.Descricao;
                    monstroAntigo.Index = mo.Index;

                    ctx.SaveChanges();

                    msn = "Alteração feita com sucesso";
                }

            }
            catch (Exception ex)
            {
                msn = "Algo deu Errado!";
            }

            return msn;
        }

        internal static string AlterarMonstroPendulo(Carta c, Atributo at, Icone ic, Tipo ti, CrtMonstro mo, MnstEfeito efeito, EfPendulo pendulo, CrtImagem img)
        {
            string msn = "";
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {
                    Carta cartaAntigo = SelecionarCarta(c.IdCarta);

                    Atributo atributoAntigo = SelecionarAtributo(c);
                    Icone iconeAntigo = SelecionarIcone(c);
                    Tipo tipoAntigo = SelecionarTipo(c);
                    CrtImagem imagemAntigo = SelecionarImagem(c);

                    CrtMonstro monstroAntigo = SelecionarMonstro(ti);

                    ctx.EfPenduloes.Add(pendulo);
                    ctx.SaveChanges();

                    EfPendulo pe = ctx.EfPenduloes.OrderByDescending(x => x.IdPendulo).FirstOrDefault(x => x.Descricao == pendulo.Descricao);
                    efeito.PenduloId = pe.IdPendulo;

                    ctx.MnstEfeitoes.Add(efeito);
                    ctx.SaveChanges();

                    MnstEfeito ef = ctx.MnstEfeitoes.OrderByDescending(x => x.IdEfeito).FirstOrDefault(x => x.Descricao == efeito.Descricao);

                    cartaAntigo.Nome = c.Nome;
                    cartaAntigo.Nivel = c.Nivel;
                    cartaAntigo.Numero = c.Numero;
                    cartaAntigo.PtnAtaque = c.PtnAtaque;
                    cartaAntigo.PtnDefesa = c.PtnDefesa;
                    cartaAntigo.Descricao = c.Descricao;

                    atributoAntigo.Descricao = at.Descricao;
                    atributoAntigo.Index = at.Index;

                    iconeAntigo.Descricao = ic.Descricao;
                    iconeAntigo.Index = ic.Index;

                    tipoAntigo.Descricao = ti.Descricao;
                    tipoAntigo.Index = ti.Index;

                    imagemAntigo.Nome = img.Nome;
                    imagemAntigo.Src = img.Src;

                    monstroAntigo.Descricao = mo.Descricao;
                    monstroAntigo.Index = mo.Index;
                    monstroAntigo.EfeitoId = ef.IdEfeito;

                    ctx.SaveChanges();

                    msn = "Alteração feita com sucesso";
                }

            }
            catch (Exception ex)
            {
                msn = "Algo deu Errado!";
            }

            return msn;
        }

        internal static string AlterarMonstroEfeito(Carta c, Atributo at, Icone ic, Tipo ti, CrtMonstro mo, MnstEfeito efeito, CrtImagem img)
        {
            string msn = "";
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {
                    Carta cartaAntigo = SelecionarCarta(c.IdCarta);

                    Atributo atributoAntigo = SelecionarAtributo(c);
                    Icone iconeAntigo = SelecionarIcone(c);
                    Tipo tipoAntigo = SelecionarTipo(c);
                    CrtImagem imagemAntigo = SelecionarImagem(c);

                    CrtMonstro monstroAntigo = SelecionarMonstro(ti);

                    ctx.MnstEfeitoes.Add(efeito);
                    ctx.SaveChanges();

                    MnstEfeito ef = ctx.MnstEfeitoes.OrderByDescending(x => x.IdEfeito).FirstOrDefault(x => x.Descricao == efeito.Descricao);

                    cartaAntigo.Nome = c.Nome;
                    cartaAntigo.Nivel = c.Nivel;
                    cartaAntigo.Numero = c.Numero;
                    cartaAntigo.PtnAtaque = c.PtnAtaque;
                    cartaAntigo.PtnDefesa = c.PtnDefesa;
                    cartaAntigo.Descricao = c.Descricao;

                    atributoAntigo.Descricao = at.Descricao;
                    atributoAntigo.Index = at.Index;

                    iconeAntigo.Descricao = ic.Descricao;
                    iconeAntigo.Index = ic.Index;

                    tipoAntigo.Descricao = ti.Descricao;
                    tipoAntigo.Index = ti.Index;

                    imagemAntigo.Nome = img.Nome;
                    imagemAntigo.Src = img.Src;

                    monstroAntigo.Descricao = mo.Descricao;
                    monstroAntigo.Index = mo.Index;
                    monstroAntigo.EfeitoId = ef.IdEfeito;

                    ctx.SaveChanges();

                    msn = "Alteração feita com sucesso";
                }

            }
            catch (Exception ex)
            {
                msn = "Algo deu Errado!";
            }

            return msn;
        }

        internal static string AlterarMagiaNovo(Carta c, Carta carta, Atributo at, Icone ic, Tipo tipo, CrtMagia magia, CrtImagem img)
        {
            string msn = "";
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    Atributo atributoAntigo = SelecionarAtributo(c);
                    Icone iconeAntigo = SelecionarIcone(c);
                    Tipo tipoAntigo = SelecionarTipo(c);
                    CrtImagem imagemAntigo = SelecionarImagem(c);

                    ctx.CrtMagias.Add(magia);
                    ctx.SaveChanges();

                    CrtMagia ma = ctx.CrtMagias.OrderByDescending(x => x.IdMagia).FirstOrDefault(x => x.Descricao == magia.Descricao);
                    tipo.MagiaId = ma.IdMagia;

                    ctx.Tipoes.Add(tipo);
                    ctx.SaveChanges();

                    Tipo t = ctx.Tipoes.OrderByDescending(x => x.IdTipo).FirstOrDefault(x => x.Descricao == tipo.Descricao);

                    carta.AtributoId = atributoAntigo.IdAtributo;
                    carta.IconeId = iconeAntigo.IdIcone;
                    carta.ImagemId = imagemAntigo.IdImagem;
                    carta.TipoId = t.IdTipo;

                    ctx.Cartas.Add(carta);
                    ctx.SaveChanges();

                    atributoAntigo.Descricao = at.Descricao;
                    atributoAntigo.Index = at.Index;

                    iconeAntigo.Descricao = ic.Descricao;
                    iconeAntigo.Index = ic.Index;

                    imagemAntigo.Nome = img.Nome;
                    imagemAntigo.Src = img.Src;



                    if (tipoAntigo.Descricao.Contains("Monstro"))
                    {

                        CrtMonstro monstro = SelecionarMonstro(tipoAntigo);

                        ctx.CrtMonstroes.Attach(monstro);
                        ctx.Cartas.Attach(c);
                        ctx.Tipoes.Attach(tipoAntigo);

                        ctx.Cartas.Remove(c);
                        ctx.Tipoes.Remove(tipoAntigo);
                        ctx.CrtMonstroes.Remove(monstro);

                        if (monstro.EfeitoId != null)
                        {
                            MnstEfeito ef = SelecionarMonstroEfeito(monstro);

                            ctx.MnstEfeitoes.Attach(ef);
                            ctx.MnstEfeitoes.Remove(ef);

                            if (ef.PenduloId != null)
                            {
                                EfPendulo pe = SelecionarMonstroPendulo(ef);
                                ctx.EfPenduloes.Attach(pe);
                                ctx.EfPenduloes.Remove(pe);
                            }
                        }



                    }
                    else if (tipoAntigo.Descricao.Contains("Armadilha"))
                    {

                        CrtArmadilha armadilha = SelecionarArmadilha(tipoAntigo);

                        ctx.CrtArmadilhas.Attach(armadilha);
                        ctx.Cartas.Attach(c);
                        ctx.Tipoes.Attach(tipoAntigo);

                        ctx.Cartas.Remove(c);
                        ctx.Tipoes.Remove(tipoAntigo);
                        ctx.CrtArmadilhas.Remove(armadilha);
                    }

                    ctx.SaveChanges();

                    msn = "Alteração feita com sucesso";
                }

            }
            catch (Exception ex)
            {
                msn = "Algo deu Errado!";
            }

            return msn;
        }

        internal static string AlterarArmadilhaNovo(Carta c, Carta carta, Atributo at, Icone ic, Tipo tipo, CrtArmadilha armadilha, CrtImagem img)
        {
            string msn = "";
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    Atributo atributoAntigo = SelecionarAtributo(c);
                    Icone iconeAntigo = SelecionarIcone(c);
                    Tipo tipoAntigo = SelecionarTipo(c);
                    CrtImagem imagemAntigo = SelecionarImagem(c);

                    ctx.CrtArmadilhas.Add(armadilha);
                    ctx.SaveChanges();

                    CrtArmadilha ar = ctx.CrtArmadilhas.OrderByDescending(x => x.IdArmadilha).FirstOrDefault(x => x.Descricao == armadilha.Descricao);
                    tipo.ArmadilhaId = ar.IdArmadilha;

                    ctx.Tipoes.Add(tipo);
                    ctx.SaveChanges();

                    Tipo t = ctx.Tipoes.OrderByDescending(x => x.IdTipo).FirstOrDefault(x => x.Descricao == tipo.Descricao);

                    carta.AtributoId = atributoAntigo.IdAtributo;
                    carta.IconeId = iconeAntigo.IdIcone;
                    carta.ImagemId = imagemAntigo.IdImagem;
                    carta.TipoId = t.IdTipo;

                    ctx.Cartas.Add(carta);
                    ctx.SaveChanges();

                    atributoAntigo.Descricao = at.Descricao;
                    atributoAntigo.Index = at.Index;

                    iconeAntigo.Descricao = ic.Descricao;
                    iconeAntigo.Index = ic.Index;

                    imagemAntigo.Nome = img.Nome;
                    imagemAntigo.Src = img.Src;



                    if (tipoAntigo.Descricao.Contains("Monstro"))
                    {

                        CrtMonstro monstro = SelecionarMonstro(tipoAntigo);

                        ctx.CrtMonstroes.Attach(monstro);
                        ctx.Cartas.Attach(c);
                        ctx.Tipoes.Attach(tipoAntigo);

                        ctx.Cartas.Remove(c);
                        ctx.Tipoes.Remove(tipoAntigo);
                        ctx.CrtMonstroes.Remove(monstro);

                        if (monstro.EfeitoId != null)
                        {
                            MnstEfeito ef = SelecionarMonstroEfeito(monstro);

                            ctx.MnstEfeitoes.Attach(ef);
                            ctx.MnstEfeitoes.Remove(ef);

                            if(ef.PenduloId != null)
                            {
                                EfPendulo pe = SelecionarMonstroPendulo(ef);
                                ctx.EfPenduloes.Attach(pe);
                                ctx.EfPenduloes.Remove(pe);
                            }
                        }



                    }
                    else if (tipoAntigo.Descricao.Contains("Magia"))
                    {
                        CrtMagia magia = SelecionarMagia(tipoAntigo);

                        ctx.CrtMagias.Attach(magia);
                        ctx.Cartas.Attach(c);
                        ctx.Tipoes.Attach(tipoAntigo);

                        ctx.Cartas.Remove(c);
                        ctx.Tipoes.Remove(tipoAntigo);
                        ctx.CrtMagias.Remove(magia);
                    }

                    ctx.SaveChanges();

                    msn = "Alteração feita com sucesso";
                }

            }
            catch (Exception ex)
            {
                msn = "Algo deu Errado!";
            }

            return msn;
        }

        internal static string AlterarMonstroEfeitoNovo(Carta c, Carta carta, Atributo at, Icone ic, Tipo tipo, CrtMonstro monstro, MnstEfeito efeito, CrtImagem img)
        {
            string msn = "";
            try
            {

                using (var ctx = new YuGiOhDBEntities())
                {

                    Atributo atributoAntigo = SelecionarAtributo(c);
                    Icone iconeAntigo = SelecionarIcone(c);
                    Tipo tipoAntigo = SelecionarTipo(c);
                    CrtImagem imagemAntigo = SelecionarImagem(c);

                    ctx.MnstEfeitoes.Add(efeito);
                    ctx.SaveChanges();

                    MnstEfeito ef = ctx.MnstEfeitoes.OrderByDescending(x => x.IdEfeito).FirstOrDefault(x => x.Descricao == efeito.Descricao);
                    monstro.EfeitoId = ef.IdEfeito;


                    ctx.CrtMonstroes.Add(monstro);
                    ctx.SaveChanges();

                    CrtMonstro mo = ctx.CrtMonstroes.OrderByDescending(x => x.IdMonstro).FirstOrDefault(x => x.Descricao == monstro.Descricao);
                    tipo.MonstroId = mo.IdMonstro;

                    ctx.Tipoes.Add(tipo);
                    ctx.SaveChanges();

                    Tipo t = ctx.Tipoes.OrderByDescending(x => x.IdTipo).FirstOrDefault(x => x.Descricao == tipo.Descricao);

                    carta.AtributoId = atributoAntigo.IdAtributo;
                    carta.IconeId = iconeAntigo.IdIcone;
                    carta.ImagemId = imagemAntigo.IdImagem;
                    carta.TipoId = t.IdTipo;

                    ctx.Cartas.Add(carta);
                    ctx.SaveChanges();

                    atributoAntigo.Descricao = at.Descricao;
                    atributoAntigo.Index = at.Index;

                    iconeAntigo.Descricao = ic.Descricao;
                    iconeAntigo.Index = ic.Index;

                    imagemAntigo.Nome = img.Nome;
                    imagemAntigo.Src = img.Src;



                    if (tipoAntigo.Descricao.Contains("Armadilha"))
                    {

                        CrtArmadilha armadilha = SelecionarArmadilha(tipoAntigo);

                        ctx.CrtArmadilhas.Attach(armadilha);
                        ctx.Cartas.Attach(c);
                        ctx.Tipoes.Attach(tipoAntigo);

                        ctx.Cartas.Remove(c);
                        ctx.Tipoes.Remove(tipoAntigo);
                        ctx.CrtArmadilhas.Remove(armadilha);
                    }
                    else if (tipoAntigo.Descricao.Contains("Magia"))
                    {
                        CrtMagia magia = SelecionarMagia(tipoAntigo);

                        ctx.CrtMagias.Attach(magia);
                        ctx.Cartas.Attach(c);
                        ctx.Tipoes.Attach(tipoAntigo);

                        ctx.Cartas.Remove(c);
                        ctx.Tipoes.Remove(tipoAntigo);
                        ctx.CrtMagias.Remove(magia);
                    }

                    ctx.SaveChanges();

                    msn = "Alteração feita com sucesso";
                }

            }
            catch (Exception ex)
            {
                msn = "Algo deu Errado!";
            }

            return msn;
        }
    }
}
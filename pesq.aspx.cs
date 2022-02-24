using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;

namespace prj_series
{
    public partial class pesq : System.Web.UI.Page
    {
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["tex"] != null && Request["tex"].ToString() != "")
            {
                string pew = Request["tex"];

                banco = new cls_dado_banco_31682.cls_dado_banco_31682();
                banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();
                MySqlDataReader dados = null;

#region Nome
                if (!banco.Consult("Select s.nm_serie, s.cd_serie from serie s where nm_serie like '%" + pew + "%' or nm_original_serie like '%" + pew + "%';", ref dados))
                {
                    lblMsg3.Text = "Nenhum resultado encontrado!";
                    banco.Closing();
                    return;
                }


                if (dados.HasRows)
                {
                    while (dados.Read())
                    {
                        Panel pnlNome = new Panel();
                        Label lblNome = new Label();
                        lblNome.Text = "Nome: " + dados["nm_serie"].ToString();
                        pnlNome.Controls.Add(lblNome);

                        Panel pnlImagem = new Panel();
                        Image imagem = new Image();
                        imagem.CssClass = "cru";

                        if (File.Exists(Request.PhysicalApplicationPath + @"\imagens\series\" + dados["cd_serie"].ToString() + ".jpg"))
                        {
                            imagem.ImageUrl = "~/imagens/series/" + dados["cd_serie"].ToString() + ".jpg";
                        }
                        pnlImagem.Controls.Add(imagem);

                        Panel Item = new Panel();
                        Item.CssClass = "go";
                        Item.Controls.Add(pnlImagem);
                        Item.Controls.Add(pnlNome);

                        Panel pnlItem = new Panel();
                        pnlItem.CssClass = "go";
                        pnlItem.Controls.Add(Item);

                        HyperLink vai = new HyperLink();
                        vai.NavigateUrl = "pagserie.aspx?i=" + dados["cd_serie"];
                        vai.Controls.Add(pnlItem);
                        vai.CssClass = "go";

                        Panel3.Controls.Add(vai);
                        Panel3.CssClass = "flex1";
                    }
                }
#endregion
#region original
                //if (!banco.Consult("Select s.nm_serie, s.cd_serie, s.nm_original_serie from serie s where nm_original_serie like '%" + pew + "%';", ref dados))
                //{
                //    lblMsg3.Text = "Nenhum resultado encontrado!";
                //    banco.Closing();
                //    return;
                //}


                //if (dados.HasRows)
                //{
                //    while (dados.Read())
                //    {

                //        Panel pnlori = new Panel();
                //        Label lblori = new Label();
                //        lblori.Text = "Nome original: " + dados["nm_original_serie"].ToString();
                //        pnlori.Controls.Add(lblori);

                //        Panel pnlNome = new Panel();
                //        Label lblNome = new Label();
                //        lblNome.Text = "Nome: " + dados["nm_serie"].ToString();
                //        pnlNome.Controls.Add(lblNome);

                //        Panel pnlImagem = new Panel();
                //        Image imagem = new Image();
                //        imagem.CssClass = "cru";

                //        if (File.Exists(Request.PhysicalApplicationPath + @"\imagens\series\" + dados["cd_serie"].ToString() + ".jpg"))
                //        {
                //            imagem.ImageUrl = "~/imagens/series/" + dados["cd_serie"].ToString() + ".jpg";
                //        }
                //        pnlImagem.Controls.Add(imagem);

                //        Panel Item = new Panel();
                //        Item.CssClass = "go";
                //        Item.Controls.Add(pnlImagem);
                //        Item.Controls.Add(pnlNome);
                //        Item.Controls.Add(pnlori);


                //        Panel pnlItem = new Panel();
                //        pnlItem.CssClass = "go";
                //        pnlItem.Controls.Add(Item);



                //        HyperLink vai = new HyperLink();
                //        vai.NavigateUrl = "pagserie.aspx?i=" + dados["cd_serie"];
                //        vai.Controls.Add(pnlItem);
                //        vai.CssClass = "go";

                //        Panel3.Controls.Add(vai);
                //        Panel3.CssClass = "flex1";
                //    }
                //}

#endregion
#region Episódio
                if (!banco.Consult("Select s.nm_serie, s.nm_original_serie, s.cd_serie, e.nm_episodio from serie s join episodio e on (s.cd_serie = e.cd_serie) where nm_episodio like '%" + pew + "%';", ref dados))
                {
                    lblMsg3.Text = "Nenhum resultado encontrado!";
                    banco.Closing();
                    return;
                }


                if (dados.HasRows)
                {
                    while (dados.Read())
                    {

                        Panel pnlori = new Panel();
                        Label lblori = new Label();
                        lblori.Text = "Nome original: " + dados["nm_original_serie"].ToString();
                        pnlori.Controls.Add(lblori);

                        Panel pnlNome = new Panel();
                        Label lblNome = new Label();
                        lblNome.Text = "Nome: " + dados["nm_serie"].ToString();
                        pnlNome.Controls.Add(lblNome);

                        Panel pnlEp = new Panel();
                        Label lblEp = new Label();
                        lblEp.Text = "Episódio: " + dados["nm_episodio"].ToString();
                        pnlEp.Controls.Add(lblEp);

                        Panel pnlImagem = new Panel();
                        Image imagem = new Image();
                        imagem.CssClass = "cru";

                        if (File.Exists(Request.PhysicalApplicationPath + @"\imagens\series\" + dados["cd_serie"].ToString() + ".jpg"))
                        {
                            imagem.ImageUrl = "~/imagens/series/" + dados["cd_serie"].ToString() + ".jpg";
                        }
                        pnlImagem.Controls.Add(imagem);

                        Panel Item = new Panel();
                        Item.CssClass = "go";
                        Item.Controls.Add(pnlImagem);
                        Item.Controls.Add(pnlNome);
                        Item.Controls.Add(pnlori);
                        Item.Controls.Add(pnlEp);


                        Panel pnlItem = new Panel();
                        pnlItem.CssClass = "go";
                        pnlItem.Controls.Add(Item);



                        HyperLink vai = new HyperLink();
                        vai.NavigateUrl = "pagserie.aspx?i=" + dados["cd_serie"];
                        vai.Controls.Add(pnlItem);
                        vai.CssClass = "go";

                        Panel3.Controls.Add(vai);
                        Panel3.CssClass = "flex1";
                    }
                }
            
#endregion
#region Ator e Personagem
                if (!banco.Consult("select a.nm_ator, p.nm_personagem, s.nm_serie, s.nm_original_serie, s.cd_serie from personagem_ator pa join personagem p on(p.cd_personagem = pa.cd_personagem) join ator a on(a.cd_ator = pa.cd_ator) join serie s on (s.cd_serie = p.cd_serie) where nm_ator like '%" + pew + "%' or nm_personagem like '%" + pew + "%';", ref dados))
                {
                    lblMsg3.Text = "Nenhum resultado encontrado!";
                    banco.Closing();
                    return;
                }


                if (dados.HasRows)
                {
                    while (dados.Read())
                    {

                        Panel pnlori = new Panel();
                        Label lblori = new Label();
                        lblori.Text = "Nome original: " + dados["nm_original_serie"].ToString();
                        pnlori.Controls.Add(lblori);

                        Panel pnlNome = new Panel();
                        Label lblNome = new Label();
                        lblNome.Text = "Nome: " + dados["nm_serie"].ToString();
                        pnlNome.Controls.Add(lblNome);

                        Panel pnlAtor = new Panel();
                        Label lblAtor = new Label();
                        lblAtor.Text = "Ator:" + dados["nm_ator"].ToString();
                        pnlAtor.Controls.Add(lblAtor);

                        Panel pnlPer = new Panel();
                        Label lblPer = new Label();
                        lblPer.Text = "Personagem:" + dados["nm_personagem"].ToString();
                        pnlPer.Controls.Add(lblPer);

                        Panel pnlImagem = new Panel();
                        Image imagem = new Image();
                        imagem.CssClass = "cru";

                        if (File.Exists(Request.PhysicalApplicationPath + @"\imagens\series\" + dados["cd_serie"].ToString() + ".jpg"))
                        {
                            imagem.ImageUrl = "~/imagens/series/" + dados["cd_serie"].ToString() + ".jpg";
                        }
                        pnlImagem.Controls.Add(imagem);

                        Panel Item = new Panel();
                        Item.CssClass = "go";
                        Item.Controls.Add(pnlImagem);
                        Item.Controls.Add(pnlNome);
                        Item.Controls.Add(pnlori);
                        Item.Controls.Add(pnlAtor);
                        Item.Controls.Add(pnlPer);


                        Panel pnlItem = new Panel();
                        pnlItem.CssClass = "go";
                        pnlItem.Controls.Add(Item);



                        HyperLink vai = new HyperLink();
                        vai.NavigateUrl = "pagserie.aspx?i=" + dados["cd_serie"];
                        vai.Controls.Add(pnlItem);
                        vai.CssClass = "go";

                        Panel3.Controls.Add(vai);
                        Panel3.CssClass = "flex1";
                    }
                }
            }
#endregion
        }
        }
    }

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
    public partial class inscricao : System.Web.UI.Page
    {
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["i"] != null && Request["i"].ToString() != "")
            {
                int bo = int.Parse(Request["i"].ToString());
            
                banco = new cls_dado_banco_31682.cls_dado_banco_31682();
                banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();
                MySqlDataReader dados = null;

                if (!banco.Consult("select s.nm_serie, s.cd_serie, s.nm_original_serie, s.aa_lancamento, s.aa_encerramento, se.nm_situacao_serie from serie s join situacao_serie se on(s.cd_situacao_serie = se.cd_situacao_serie) where s.cd_serie = " + bo + ";", ref dados))
                {
                    lblMsg.Text = "Problemas na consulta ao servidor";
                    banco.Closing();
                    return;
                }

                if (dados.HasRows)
                {
                    while (dados.Read())
                    {
                        Panel pnlori = new Panel();
                        Label lblori = new Label();
                        lblori.Text = "Nome Original: " + dados["nm_original_serie"].ToString();
                        pnlori.Controls.Add(lblori);

                        Panel pnlNome = new Panel();
                        Label lblNome = new Label();
                        lblNome.Text = "Nome: " + dados["nm_serie"].ToString();
                        pnlNome.Controls.Add(lblNome);

                        Panel pnlLan = new Panel();
                        Label lblLan = new Label();
                        lblLan.Text = "Ano de Lançamento: " + dados["aa_lancamento"].ToString();
                        pnlLan.Controls.Add(lblLan);

                        Panel pnlEn = new Panel();
                        Label lblEn = new Label();
                        lblEn.Text = "Ano de Encerramento: " + dados["aa_encerramento"].ToString();
                        pnlEn.Controls.Add(lblEn);

                        Panel pnlSit = new Panel();
                        Label lblSit = new Label();
                        lblSit.Text = "Situação: " + dados["nm_situacao_serie"].ToString();
                        pnlSit.Controls.Add(lblSit);

                        //Panel pnlCri = new Panel();
                        //Label lblCri = new Label();
                        //lblCri.Text = "Criador: " + dados["nm_criador"].ToString();
                        //pnlCri.Controls.Add(lblCri);

                        Panel pnlImagem = new Panel();
                        Image imagem = new Image();
                        imagem.CssClass = "cru2";

                        if (File.Exists(Request.PhysicalApplicationPath + @"\imagens\series\" + dados["cd_serie"].ToString() + ".jpg"))
                        {
                            imagem.ImageUrl = "~/imagens/series/" + dados["cd_serie"].ToString() + ".jpg";
                        }
                        pnlImagem.Controls.Add(imagem);

                        Panel Item = new Panel();
                        Item.CssClass = "go";
                        Item.Controls.Add(pnlImagem);
                        Item.Controls.Add(pnlori);
                        Item.Controls.Add(pnlNome);
                        Item.Controls.Add(pnlLan);
                        Item.Controls.Add(pnlEn);
                        Item.Controls.Add(pnlSit);
                        //Item.Controls.Add(pnlCri);

                        Panel pnlItem = new Panel();
                        pnlItem.CssClass = "flex3";
                        pnlItem.Controls.Add(Item);

                        Panel1.Controls.Add(pnlItem);
                    }
                }

                if (!banco.Consult("select a.nm_ator, p.nm_personagem, a.cd_ator from personagem_ator pa join personagem p on(p.cd_personagem = pa.cd_personagem) join ator a on(a.cd_ator = pa.cd_ator)  where cd_serie = " + bo + ";", ref dados))
                {
                    lblMsg.Text = "Problemas na consulta ao servidor";
                    banco.Closing();
                    return;
                }

                if (dados.HasRows)
                {
                    while (dados.Read())
                    {
                        Panel pnlori2 = new Panel();
                        Label lblat = new Label();
                        lblat.Text = "Nome do ator: " + dados["nm_ator"].ToString();
                        pnlori2.Controls.Add(lblat);

                        Panel pnlNome2 = new Panel();
                        Label lblper = new Label();
                        lblper.Text = "Nome do Personagem: " + dados["nm_personagem"].ToString();
                        pnlNome2.Controls.Add(lblper);

                        Panel pnlImagem = new Panel();
                        Image imagem = new Image();
                        imagem.CssClass = "cru2";

                        if (File.Exists(Request.PhysicalApplicationPath + @"\imagens\atores\" + dados["cd_ator"].ToString() + ".jpg"))
                        {
                            imagem.ImageUrl = "~/imagens/atores/" + dados["cd_ator"].ToString() + ".jpg";
                        }
                        pnlImagem.Controls.Add(imagem);

                        Panel Item = new Panel();
                        Item.CssClass = "go";
                        Item.Controls.Add(pnlImagem);
                        Item.Controls.Add(pnlori2);
                        Item.Controls.Add(pnlNome2);

                        Panel pnlItem = new Panel();
                        pnlItem.CssClass = "flex3";
                        pnlItem.Controls.Add(Item);

                        Panel1.Controls.Add(pnlItem);
                    }
                }

                if (!banco.Consult("Select e.nm_episodio, e.nm_original_episodio, e.dt_exibicao, e.ds_sinopse, e.ds_observacoes, e.qt_tempo_episodio, s.cd_serie from episodio e join serie s on (e.cd_serie = s.cd_serie) where s.cd_serie = " + bo + ";", ref dados))
                {
                    lblMsg2.Text = "Problemas na consulta ao servidor";
                    banco.Closing();
                    return;
                }

                if (dados.HasRows)
                {
                    while (dados.Read())
                    {
                        Panel pnlori = new Panel();
                        Label lblnm = new Label();
                        Label lblori = new Label();
                        Label lbldt = new Label();
                        Label lbldssi = new Label();
                        Label lbldsobs = new Label();
                        Label lblqt = new Label();
                        lblnm.Text = "Nome: " + dados["nm_episodio"].ToString() + "<br>";
                        lblori.Text = "Nome Original: " + dados["nm_original_episodio"].ToString() + "<br>";
                        lbldt.Text = "Data de exibição: " + dados["dt_exibicao"].ToString() + "<br>";
                        lbldssi.Text = "Sinopse do episódio: " + dados["ds_sinopse"].ToString() + "<br>";
                        lbldsobs.Text = "Obs do episódio: " + dados["ds_observacoes"].ToString() + "<br>";
                        lblqt.Text = "Tempo do episódio: " + dados["qt_tempo_episodio"].ToString();
                        pnlori.Controls.Add(lblnm);
                        pnlori.Controls.Add(lblori);
                        pnlori.Controls.Add(lbldt);
                        pnlori.Controls.Add(lbldssi);
                        pnlori.Controls.Add(lbldsobs);
                        pnlori.Controls.Add(lblqt);

                        Panel pnlEp = new Panel();
                        Label lblEp = new Label();
                        pnlEp.CssClass = "go2";
                        lblEp.Text = "Episódios:";
                        pnlEp.Controls.Add(lblEp);

                        Panel Item2 = new Panel();
                        Item2.CssClass = "go1";
                        Item2.Controls.Add(pnlEp);
                        Item2.Controls.Add(pnlori);

                        Panel pnlItem2 = new Panel();
                        pnlItem2.CssClass = "flex4";
                        pnlItem2.Controls.Add(Item2);

                        Panel2.Controls.Add(pnlItem2);
                    }
                }
            }

            else
            {
                Response.Redirect("~/serie.aspx");
            }

        }
    }
}
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
    public partial class serie : System.Web.UI.Page
    {
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            int c = -1;

                banco = new cls_dado_banco_31682.cls_dado_banco_31682();
                banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();
                MySqlDataReader dados = null;

                if (!banco.Consult("Select s.nm_serie, s.cd_serie, s.nm_original_serie from serie s;", ref dados))
                {
                    lblMsg.Text = "Problemas na consulta ao servidor";
                    banco.Closing();
                    return;
                }

                
                if (dados.HasRows)
                {
                    while (dados.Read())
                    {
                        c++;

                        Panel pnlori = new Panel();
                        Label lblori = new Label();
                        lblori.Text = dados["nm_original_serie"].ToString();
                        pnlori.Controls.Add(lblori);

                        Panel pnlNome = new Panel();
                        Label lblNome = new Label();
                        lblNome.Text = dados["nm_serie"].ToString();
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
                        Item.Controls.Add(pnlori);


                        Panel pnlItem = new Panel();
                        pnlItem.CssClass = "go";
                        pnlItem.Controls.Add(Item);

                       

                        HyperLink vai = new HyperLink();
                        vai.NavigateUrl = "pagserie.aspx?i=" + c;
                        vai.Controls.Add(pnlItem);
                        vai.CssClass = "go";

                        Panelse.Controls.Add(vai);
                    }
                }
            }
         }
     }


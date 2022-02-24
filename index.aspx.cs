using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace prj_series
{
    public partial class index : System.Web.UI.Page
    {
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //banco = new cls_dado_banco_31682.cls_dado_banco_31682();
            //banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();
            //MySqlDataReader dados = null;

            //if (!banco.Consult("Select nm_serie, img_serie from serie", ref dados))
            //{
            //    lblMsg.Text = "Problemas na consula ao servidor";
            //    banco.Closing();
            //    return;
            //}

            //if (dados.HasRows)
            //{
            //    while (dados.Read())
            //    {

            //        for (int i = 0; i < i.count(); i++)
            //        {
            //            HyperLink teste = new HyperLink();
            //            teste.ID = "Teste";
            //            teste.NavigateUrl = "serie.aspx?/n=" + i;
            //            teste.CssClass = "a fl";
            //            ltr1.Controls.Add(teste);





            //        }
            //    }
            //}
                
        }
    }
}
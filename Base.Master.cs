using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj_series
{
    public partial class Base : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnpes_Click(object sender, EventArgs e)
        {
            string pew = txtPes.Text;

            if (pew != "")
            {
                Response.Redirect("~/pesq.aspx?tex=" + pew);
            }
            else
            {
                return;
            }

        }
    }
}
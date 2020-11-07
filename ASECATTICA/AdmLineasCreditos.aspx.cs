using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASECATTICA
{
    public partial class AdmLineasCreditos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GvLineasCredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvLineasCredito.SelectedRow;
            Response.Redirect("AdmLineasCreditoAct.aspx");
        }
    }
}
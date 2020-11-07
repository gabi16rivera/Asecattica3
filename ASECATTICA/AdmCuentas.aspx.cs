using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASECATTICA
{
    public partial class AdmCuentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GvCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvCuentas.SelectedRow;
            Response.Redirect("AdmCuentasAct.aspx");
        }
    }
}
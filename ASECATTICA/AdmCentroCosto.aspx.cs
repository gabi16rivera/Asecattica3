using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASECATTICA
{
    public partial class AdmCentroCosto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GvCentroCosto_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvCentroCosto.SelectedRow;
            Response.Redirect("AdmCentroCostoAct.aspx");
        }
    }
}
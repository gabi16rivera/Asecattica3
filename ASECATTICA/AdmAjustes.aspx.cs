using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASECATTICA
{
    public partial class AdmAjustes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void GvAjustes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GridViewRow row = GvAjustes.SelectedRow;
            Response.Redirect("AdmAjustesAct.aspx");
        }

        
    }
}
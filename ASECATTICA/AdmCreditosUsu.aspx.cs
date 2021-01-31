using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASECATTICA
{
    public partial class AdmCreditosUsu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GvCreditosUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvCreditosUsu.SelectedRow;
            Session["Codigo"] = row.Cells[1].Text;
            Session["Titulo"] = "Actualizar / Eliminar Crédito de Usuario";
            Response.Redirect("AdmCreditosUsuAct.aspx");
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Session["Titulo"] = "Agregar Crédito de Usuario";
            Response.Redirect("AdmCreditosUsuAct.aspx");
        }
    }
}
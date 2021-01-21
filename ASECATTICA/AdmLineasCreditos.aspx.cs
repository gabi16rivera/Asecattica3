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
            Session["CodigoLineaCredito"] = row.Cells[1].Text;
            Session["Titulo"] = "Actualizar / Eliminar Línea Crédito";
            Response.Redirect("AdmLineasCreditosAct.aspx");

        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Session["Titulo"] = "Agregar Línea Crédito";
            Response.Redirect("AdmLineasCreditosAct.aspx");
        }
    }
}
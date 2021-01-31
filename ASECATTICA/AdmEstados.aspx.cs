using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASECATTICA
{
    public partial class AdmEstados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GvEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvEstados.SelectedRow;
            Session["Codigo"] = row.Cells[1].Text;
            Session["Titulo"] = "Actualizar / Eliminar Estados";
            Response.Redirect("AdmEstadosAct.aspx");
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Session["Titulo"] = "Agregar Estados";
            Response.Redirect("AdmEstadosAct.aspx");

        }
    }
}
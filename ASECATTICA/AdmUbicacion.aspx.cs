using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASECATTICA
{
    public partial class AdmUbicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GvUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvUbicacion.SelectedRow;
            Session["Codigo"] = row.Cells[1].Text;
            Session["Titulo"] = "Actualizar / Eliminar Ubicación";
            Response.Redirect("AdmUbicacionAct.aspx");
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Session["Titulo"] = "Agregar Ubicación";
            Response.Redirect("AdmUbicacionAct.aspx");

        }
    }
}
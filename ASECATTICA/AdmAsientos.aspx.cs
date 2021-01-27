using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASECATTICA
{
    public partial class AdmAsientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GvAsientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvAsientos.SelectedRow;
            Session["CodigoTipoAsiento"] = row.Cells[1].Text;
            Session["Titulo"] = "Actualizar / Eliminar Asiento";
            Response.Redirect("AdmAsientosAct.aspx");
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Session["Titulo"] = "Agregar Asiento";
            Response.Redirect("AdmAsientosAct.aspx");
        }
    }
}
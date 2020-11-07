using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASECATTICA
{
    public partial class AdmUsu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            GridViewRow row = GvUsuarios.SelectedRow;
            Session["ID_Asecattica"] = row.Cells[1].Text;
            Session["Titulo"] = "Actualizar / Eliminar Usuario";
            Response.Redirect("AdmUsuAct.aspx");
            

        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {

            Session["Titulo"] = "Agregar Usuario";
            Response.Redirect("AdmUsuAct.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;
namespace ASECATTICA
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataTable tablaRol = new DataTable();
        DTO_Usuarios objeto = new DTO_Usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {


            tablaRol = objeto.MostrarRol();


            //revisa todos los código de roles de TBRoles
            if (!IsPostBack)
            {
                //ListBox1.Items.Insert(0, new ListItem("Seleccione el rol:", String.Empty));
                ListItem i;
                foreach (DataRow r in tablaRol.Rows)
                {
                    i = new ListItem(r["Nombre"].ToString(), r["Nombre"].ToString());
                    // ListBox1.SelectedIndex = 0;
                    ListBox1.Items.Add(i);
                }

            }

        }
    }
}
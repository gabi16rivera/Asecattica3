using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace ASECATTICA
{
    public partial class RecuperarContrasenia : System.Web.UI.Page
    {
        DTO_Login objetoDTO = new DTO_Login();
        protected void Page_Load(object sender, EventArgs e)
        {
            //toma la cédula que viene de enlace de correo electrónico de recuperación de contraseña
            Session["Cedula"] = Request.QueryString["cedula"];


            

        }//fin Page_Load

        protected void BtnRestablecerContrasenia_Click(object sender, EventArgs e)
        {
            if (TxtNuevaContrasenia.Text.Equals(TxtConfirmarContra.Text))
            {
                objetoDTO.ActualizarClaveUsu(System.Convert.ToString(Session["Cedula"]), TxtConfirmarContra.Text);

            }
            else
            {

            }
        }
    }
}
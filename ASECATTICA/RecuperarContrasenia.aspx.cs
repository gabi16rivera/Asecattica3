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
using System.Security.Cryptography;

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
            bool contraseniaCorrecta = false;

            do
            {
                if (TxtNuevaContrasenia.Text.Equals(TxtConfirmarContra.Text))
                {
                    if (TxtConfirmarContra.Text.Length >= 8)
                    {
                        contraseniaCorrecta = true;
                    }
                    else
                    {
                        Mensaje("Advertencia", "La contraseña debe tener al menos 8 caracteres");
                    }

                }
                else
                {
                    Mensaje("Advertencia", "Las contraseñas no son iguales");
                }
            } while (contraseniaCorrecta!=true);

            if (contraseniaCorrecta==true)
            {
                
                string claveEncriptada = EncriptarContraseña(TxtConfirmarContra.Text);
                objetoDTO.ActualizarClaveUsu(System.Convert.ToString(Session["Cedula"]), claveEncriptada);
                Mensaje("Contraseña modificada", "Se modificó correctamente la contraseña");

                //Response.Redirect("Login.aspx");

            }
            else
            {
                Mensaje("Error", "La contraseña no se modificó verifique nuevamente");
            }
        }//fin BtnRestablecerContrasenia_Click

        public string EncriptarContraseña(string claveOriginal)
        {

            SHA1 sha1 = new SHA1CryptoServiceProvider();

            byte[] inputBytes = (new System.Text.UnicodeEncoding()).GetBytes(claveOriginal);
            byte[] hash = sha1.ComputeHash(inputBytes);

            return Convert.ToBase64String(hash);
        }//fin EncriptarContraseña

        public void Mensaje(string titulo, string contenido)
        {
            try
            {
                lblModalTitle.Text = titulo;
                lblModalBody.Text = contenido;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                UpModal.Update();
            }

            catch (Exception ex)
            {
                lblModalTitle.Text = "Error: ";
                lblModalBody.Text = ex.Message;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                UpModal.Update();
            }

        }//fin mensaje
    }
}
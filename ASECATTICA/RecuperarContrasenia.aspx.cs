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
            
            if (ValidarContraseniaVacia() == true && ValidarContraseniaCaract() == true)
            {
                string claveEncriptada = EncriptarContraseña(TxtConfirmarContra.Text);
                objetoDTO.ActualizarClaveUsu(System.Convert.ToString(Session["Cedula"]), claveEncriptada);
                Mensaje("Contraseña modificada", "Se modificó correctamente la contraseña");
                Response.Redirect("Login.aspx");
            }
            else {
                limpiarForm();
            }
            
        }//fin BtnRestablecerContrasenia_Click

        public bool ValidarContraseniaCaract()
        {
            String Contenido, Titulo = "";
            bool bandera = true;
            Contenido = "";
            try
            {

                if (!TxtNuevaContrasenia.Text.Equals(TxtConfirmarContra.Text))
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Las contraseñas no son iguales.</li>");
                }

                if (TxtConfirmarContra.Text.Length < 8)
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>La contraseña debe tener al menos 8 caracteres.</li>");
                }
                                    
                if (bandera == true)
                {
                    return true;

                }
                else
                {
                    Titulo = "<i class=" + "fa fa-times" + "></i>Revise la siguiente información:";
                    lblModalTitle.Text = Titulo;
                    lblModalBody.Text = System.Convert.ToString("<ol>") + Contenido + System.Convert.ToString("</ol>");
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                    UpModal.Update();
                    return false;
                }

            }//fin try
            catch (Exception ex)
            {
                lblModalTitle.Text = "Error";
                lblModalBody.Text = "Se ha producido un error, por favor reportelo con el siguiente detalle: " + ex.Message;
                return false;
            }
        }//ValidarVacios

        public bool ValidarContraseniaVacia()
        {
            String Contenido, Titulo = "";
            bool bandera = true;
            Contenido = "";
            try
            {

                if (TxtNuevaContrasenia.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe ingresar la <b>nueva contraseña</b></li>");
                }

                if (TxtConfirmarContra.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe ingresar la <b>confirmación de contraseña</b></li>");
                }


            if (bandera == true)
                {
                    return true;

                }
            else
            {
                Titulo = "<i class=" + "fa fa-times" + "></i>Revise la siguiente información:";
                lblModalTitle.Text = Titulo;
                lblModalBody.Text = System.Convert.ToString("<ol>") + Contenido + System.Convert.ToString("</ol>");
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                UpModal.Update();
                return false;
            }

        }//fin try
            catch (Exception ex)
            {
                lblModalTitle.Text = "Error";
                lblModalBody.Text = "Se ha producido un error, por favor reportelo con el siguiente detalle: " + ex.Message;
                return false;
            }
        }//ValidarVacios

        private void limpiarForm()
        {
            TxtConfirmarContra.Text = "";
            TxtNuevaContrasenia.Text = "";

        }   //fin limpiarForm

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
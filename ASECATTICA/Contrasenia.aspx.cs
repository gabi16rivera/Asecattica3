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
    public partial class Contrasenia : System.Web.UI.Page
    {
        private DTO_Login objetoDTO = new DTO_Login();
        DataTable tabla = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

        }//fin Page_Load

        protected void BtnRestablecerContrasenia_Click(object sender, EventArgs e)
        {

            //valida si encontró la cédula en BD
            int retornoID = objetoDTO.ValidarCedulaUsu(TxtCedula.Text);

            if (retornoID == 1)
            {
                tabla = objetoDTO.ValidarCorreoUsu(TxtCedula.Text);
                string correoUsuario = tabla.Rows[0]["Correo"].ToString();
                string cedulaUsuario = tabla.Rows[0]["Cedula"].ToString();
                EnviarCorreo(System.Convert.ToString(correoUsuario), "Correo electrónico enviado", "Recuperación de contraseña",
                "Se le ha enviado un correo a " + correoUsuario + ". En el comunicado encontrará las instrucciones para hacer" +
                " efectivo el cambio de contraseña. Si el problema persiste, por favor comuníquese con el Administrador", cedulaUsuario);
            }
            else
            {
                Mensaje("Advertencia","La cédula ingresada no se encuentra en base de datos. Por favor, comuníquese con el administrador");

            }
            //Response.Redirect("Contrasenia.aspx");

        }//fin BtnRestablecerContrasenia_Click

        public void EnviarCorreo(string CorreoUsuario, string Encabezado, string Asunto, string Mensaje, string cedulaUsuario)
        {
            MailMessage correo = new MailMessage();
            correo.To.Add(new MailAddress(CorreoUsuario));
            correo.From = new MailAddress("gabi16rivera@gmail.com");
            correo.Subject = "Recuperación de contraseña Asecattica";

            string stCuerpoHTML = "<!DOCTYPE html>";
            stCuerpoHTML += "<html lang='es'>";
            stCuerpoHTML += "<head>";
            stCuerpoHTML += "<meta charset='utf - 8'>";
            stCuerpoHTML += "</head>";
            stCuerpoHTML += "<body>";
            stCuerpoHTML += "<div>";
            stCuerpoHTML += "<p>";
            stCuerpoHTML += "Hemos recibido una solicitud para restablecer la contraseña de su cuenta asociada con esta dirección de correo electrónico, " +
                "para hacerlo solo debe hacer clic en el siguiente enlace:";
            stCuerpoHTML += "<br/>";
            stCuerpoHTML += "</p>";
            stCuerpoHTML += "<a href= https://localhost:44392/RecuperarContrasenia.aspx?cedula=" + cedulaUsuario +">";
            stCuerpoHTML += "Restaurar Contraseña</a>";
            stCuerpoHTML += "</div>";
            stCuerpoHTML += "</body>";
            stCuerpoHTML += "</html>";

            correo.Body = stCuerpoHTML;
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials =false;
            smtp.Credentials = new NetworkCredential("gabi16rivera@gmail.com", "qwrt.160491");

            try
            {
                smtp.Send(correo);
                correo.Dispose();
                lblModalTitle.Text = Encabezado;
                lblModalBody.Text = Mensaje;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                UpModal.Update();
            }
            catch (Exception ex)
            {
                lblModalTitle.Text = "Error de envio de correo";
                lblModalBody.Text = "Hubo un error al intentar conectar con el servidor de correo, por favor verifique su bandeja de correo o correo no deseado (Spam).";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                UpModal.Update();
            }
        }//fin EnviarCorreo

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
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

            tabla = objetoDTO.ValidarCorreoUsu(TxtCedula.Text);
            string correoUsuario = tabla.Rows[0]["Correo"].ToString();
            
            Correo(System.Convert.ToString(correoUsuario), "Encabezado ", "Asunto ", 
                "Mensaje");

        }//fin BtnRestablecerContrasenia_Click

        public void Correo(string CorreoUsuario, string Encabezado, string Asunto, string Mensaje)
        {
            MailMessage correo = new MailMessage();
            correo.To.Add(new MailAddress("gabi16rivera@gmail.com"));
            correo.From = new MailAddress("gabi16rivera@gmail.com");
            correo.Subject = "Asunto ( " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " ) ";
            correo.Body = "Cualquier contenido en <b>HTML</b> para enviarlo por correo electrónico.";
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials =false;
            smtp.Credentials = new NetworkCredential("gabi16rivera@gmail.com", "Gaby.160491");

            try
            {
                smtp.Send(correo);
                correo.Dispose();
                lblModalTitleFinalizar.Text = Encabezado;
                lblModalBodyFinalizar.Text = Mensaje;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModalFinalizar", "$('#myModalFinalizar').modal();", true);
                UpModal2.Update();
            }
            catch (Exception ex)
            {
                lblModalTitleFinalizar.Text = "Error de envio de correo";
                lblModalBodyFinalizar.Text = "Hubo un error al intentar conectar con el servidor de correo, por favor verifique su bandeja de correo o correo no deseado (Spam).";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                UpModal2.Update();
            }
        }//fin Correo
    }
}
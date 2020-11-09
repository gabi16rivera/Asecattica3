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
            System.Net.Mail.MailMessage correo = new System.Net.Mail.MailMessage();
            correo.From = new System.Net.Mail.MailAddress("contrasenia@asecattica.com");
            correo.To.Add(CorreoUsuario);
            correo.Subject = Asunto;
            correo.Body = Mensaje;
            correo.IsBodyHtml = true;
            correo.Priority = System.Net.Mail.MailPriority.Normal;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            smtp.Credentials = new NetworkCredential("gabi16rivera@gmail.com","Gaby.160491");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;

           // smtp.Host = "correo.asecattica.com";
            //smtp.Credentials = new System.Net.NetworkCredential("Asecattica", "Asecattica.2020");
            
            
            try
            {
                smtp.Send(correo);
                lblModalTitleFinalizar.Text = Encabezado;
                lblModalBodyFinalizar.Text = Mensaje;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModalFinalizar", "$('#myModalFinalizar').modal();", true);
                UpModal2.Update();
                TextBox1.Text = "Mensaje enviado";
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Security.Cryptography;
using System.Data;

namespace ASECATTICA
{
    public partial class Login : System.Web.UI.Page
    {
        DTO_Login objetoDTO = new DTO_Login();
        DataTable verificaRol = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            



        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {

            string claveEncriptada = EncriptarContraseña(TxtClave.Text);

            //valida si encontró el idAsecattica y contraseña en BD
            int retornoID = objetoDTO.ValidarLoginUsu(TxtCedula.Text, claveEncriptada);

            verificaRol = objetoDTO.ValidarRolUsu(TxtCedula.Text);

            string rol = "";

            
            rol = verificaRol.Rows[0]["Rol"].ToString();
            Session["rol"] = rol;

            if (retornoID == 1)
            {
                //Response.Redirect("Administrador.aspx?Rol=" + rol);
                Response.Redirect("Administrador.aspx");
            }
            else {
                //mensaje de usuario o contraseña incorrecta
                Mensaje("Advertencia","Usuario y contraseña incorrecta");
            }



        }//fin BtnIngresar_Click

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
                upModal.Update();
            }

            catch (Exception ex)
            {
                lblModalTitle.Text = "Error: ";
                lblModalBody.Text = ex.Message;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                upModal.Update();
            }

        }//fin mensaje

    }
}
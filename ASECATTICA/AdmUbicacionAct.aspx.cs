using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;


namespace ASECATTICA
{
    public partial class AdmUbicacionAct : System.Web.UI.Page
    {
        private DTO_Ubicacion objetoDTO = new DTO_Ubicacion();
        DataTable tablaUbicacion = new DataTable(); //tabla de ajustes

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false) //La página no se actualiza por segunda vez
            {
                lblTitulo.Text = Convert.ToString(Session["Titulo"]);

                //Actualizar
                if (Session["Titulo"].Equals("Actualizar / Eliminar Ubicación"))
                {
                    BtnActualizar.Visible = true;
                    BtnEliminar.Visible = true;
                    BtnAgregar.Visible = false;
                    BtnAtrás.Visible = true;
                    TxtCodigoUbicacion.Attributes["disabled"] = "disabled";
                    MostrarUbicaciones();
                }

                else
                {
                    //Nuevo    
                    BtnActualizar.Visible = false;
                    BtnEliminar.Visible = false;
                    BtnAgregar.Visible = true;
                    BtnAtrás.Visible = true;
                }

            }
        }//fin load

        private void MostrarUbicaciones()
        {
            tablaUbicacion = objetoDTO.MostrarCodCentroCost(Session["Codigo"].ToString());
            if (tablaUbicacion.Rows.Count > 0)
            {

                TxtCodigoUbicacion.Text = tablaUbicacion.Rows[0]["Codigo"].ToString();
                TxtDescripcion.Text = tablaUbicacion.Rows[0]["Descripcion"].ToString();
                TxtNombre.Text = tablaUbicacion.Rows[0]["Nombre"].ToString();

            }
        }//fin MostrarLineasCreditos

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdmUbicacion.aspx");
        }

        protected void BtnSi_Click(object sender, EventArgs e)
        {
            if (Session["Seleccion"].Equals("Eliminar"))
            {

                try
                {
                    objetoDTO.EliminarCod(TxtCodigoUbicacion.Text);
                    if (objetoDTO.ValidarCodEliminado(TxtCodigoUbicacion.Text) == 0)
                    {
                        MensajeRegresar("Ubicación eliminada", "Se eliminó en base de datos sin problemas.");
                    }
                }

                catch (Exception ex)
                {
                    lblModalTitle.Text = "Error";
                    lblModalBody.Text = "Se ha producido un error, por favor reportelo con el siguiente detalle: " + ex.Message;

                }

            }//fin session eliminar
            else
            {
                //Session["Seleccion"] es igual a ("Actualizar")
                try
                {
                    if (ValidarVacios() == true)
                    {

                        objetoDTO.ActualizarCod(TxtCodigoUbicacion.Text, TxtNombre.Text, TxtDescripcion.Text);

                        MensajeRegresar("Ubicación actualizada", "Se actualizó en base de datos sin problemas");
                    }

                }

                catch (Exception ex)
                {
                    lblModalTitle.Text = "Error";
                    lblModalBody.Text = "Se ha producido un error, por favor reportelo con el siguiente detalle: " + ex.Message;

                }

            }//fin session actualizar
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Session["Seleccion"] = "Eliminar";
            MensajeValidarAccion("Advertencia", "¿Está seguro que desea eliminar?");
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            int retornoCodigo = objetoDTO.ValidarCod(TxtCodigoUbicacion.Text);
            bool banderaID = false;

            if (retornoCodigo == 1)//valida si encontró un código duplicado
            {
                banderaID = true;
            }


            if (banderaID == true)
            {
                Mensaje("Código duplicado", "La información ya se encuentra en la base de datos, por favor ingresar otro código");

            }
            else
            {
                if (ValidarVacios() == true)
                {
                    objetoDTO.AgregarCod(TxtCodigoUbicacion.Text, TxtDescripcion.Text, TxtNombre.Text);

                    //mostrar mensaje de usuario agregado 
                    Mensaje("Ubicación agregada", "La información se agregó en base de datos sin problemas");
                    limpiarForm();
                }//fin else validar vacios
            }//fin else duplicado
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            Session["Seleccion"] = "Actualizar";
            MensajeValidarAccion("Advertencia", "¿Esta seguro que desea actualizar?");
        }

        protected void BtnAtrás_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdmUbicacion.aspx");
        }

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

        public void MensajeValidarAccion(string titulo2, string contenido2)
        {
            try
            {
                lblModalTitleValida.Text = titulo2;
                lblModalBodyValida.Text = contenido2;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModalValida", "$('#myModalValida').modal();", true);
                upModalValida.Update();
            }

            catch (Exception ex)
            {
                lblModalTitleValida.Text = "Error: ";
                lblModalBodyValida.Text = ex.Message;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                upModalValida.Update();
            }

        }//fin mensaje

        public void MensajeRegresar(string titulo, string contenido)
        {
            try
            {
                lblModalTitleRegresar.Text = titulo;
                lblModalBodyRegresar.Text = contenido;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModalRegresar", "$('#myModalRegresar').modal();", true);
                upModalRegresar.Update();
            }

            catch (Exception ex)
            {
                lblModalTitleValida.Text = "Error: ";
                lblModalBodyValida.Text = ex.Message;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModalRegresar", "$('#myModalRegresar').modal();", true);
                upModalRegresar.Update();
            }

        }//fin mensaje

        public bool ValidarVacios()
        {
            String Contenido, Titulo = "";
            bool bandera = true;
            Contenido = "";
            try
            {
                // Validación de código
                if (TxtCodigoUbicacion.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Código</b></li>");
                }

                // Validación de descripción
                if (TxtDescripcion.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Descripción</b></li>");
                }


                // Validación de Nombre
                if (TxtNombre.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Nombre</b></li>");
                }

                if (bandera == true)
                {
                    return true;
                }
                else
                {
                    Titulo = "<i class=" + "fa fa-times" + "></i>Debe completar los siguientes campos:";
                    lblModalTitle.Text = Titulo;
                    lblModalBody.Text = System.Convert.ToString("<ol>") + Contenido + System.Convert.ToString("</ol>");
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                    upModal.Update();
                    return false;
                }

            }//fin try
            catch (Exception ex)
            {
                lblModalTitle.Text = "Error";
                lblModalBody.Text = "Se ha producido un error, por favor reportelo con el siguiente detalle: " + ex.Message;
                return false;
            }

        }//fin validar textbox

        private void limpiarForm()
        {
            TxtCodigoUbicacion.Text = "";
            TxtDescripcion.Text = "";
            TxtNombre.Text = "";

        }//fin limpiarForm

    }


}
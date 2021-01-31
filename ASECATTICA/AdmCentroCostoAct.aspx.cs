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
    public partial class AdmCentroCostoAct : System.Web.UI.Page
    {

        private DTO_CentroCostos objetoDTO = new DTO_CentroCostos();
        DataTable tablaCentroCosto = new DataTable(); //tabla de ajustes

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false) //La página no se actualiza por segunda vez
            {
                lblTitulo.Text = Convert.ToString(Session["Titulo"]);

                //Actualizar
                if (Session["Titulo"].Equals("Actualizar / Eliminar Centro de Costo"))
                {
                    BtnActualizar.Visible = true;
                    BtnEliminar.Visible = true;
                    BtnAgregar.Visible = false;
                    BtnAtrás.Visible = true;
                    TxtCodigo.Attributes["disabled"] = "disabled";
                    MostrarCentroCostos();
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

        private void MostrarCentroCostos()
        {
            tablaCentroCosto = objetoDTO.MostrarCodCentroCost(Session["Codigo"].ToString());
            if (tablaCentroCosto.Rows.Count > 0)
            {

                TxtCodigo.Text = tablaCentroCosto.Rows[0]["Codigo"].ToString();
                TxtDescripcion.Text = tablaCentroCosto.Rows[0]["Descripcion"].ToString();
                TxtNombre.Text = tablaCentroCosto.Rows[0]["Nombre"].ToString();

            }
        }//fin MostrarLineasCreditos

        protected void BtnSi_Click(object sender, EventArgs e)
        {
            if (Session["Seleccion"].Equals("Eliminar"))
            {

                try
                {
                    objetoDTO.EliminarCod(TxtCodigo.Text);
                    if (objetoDTO.ValidarCodEliminado(TxtCodigo.Text) == 0)
                    {
                        MensajeRegresar("Centro de Costo eliminado", "Se eliminó en base de datos sin problemas.");
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

                        objetoDTO.ActualizarCod(TxtCodigo.Text, TxtNombre.Text, TxtDescripcion.Text);

                        MensajeRegresar("Centro de costo actualizado", "Se actualizó en base de datos sin problemas");
                    }

                }

                catch (Exception ex)
                {
                    lblModalTitle.Text = "Error";
                    lblModalBody.Text = "Se ha producido un error, por favor reportelo con el siguiente detalle: " + ex.Message;

                }

            }//fin session actualizar
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            int retornoCodigo = objetoDTO.ValidarCod(TxtCodigo.Text);
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
                    objetoDTO.AgregarCod(TxtCodigo.Text, TxtDescripcion.Text, TxtNombre.Text);

                    //mostrar mensaje de usuario agregado 
                    Mensaje("Centro de Costo agregado", "La información se agregó en base de datos sin problemas");
                    limpiarForm();
                }//fin else validar vacios
            }//fin else duplicado
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            Session["Seleccion"] = "Actualizar";
            MensajeValidarAccion("Advertencia", "¿Esta seguro que desea actualizar?");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Session["Seleccion"] = "Eliminar";
            MensajeValidarAccion("Advertencia", "¿Está seguro que desea eliminar?");
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
                if (TxtCodigo.Text == "")
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
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            TxtNombre.Text = "";

        }//fin limpiarForm

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdmCentroCosto.aspx");
        }

        protected void Atrás_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdmCentroCosto.aspx");
        }
    }
}
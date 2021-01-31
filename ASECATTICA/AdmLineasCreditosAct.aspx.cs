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
    public partial class AdmLineasCreditosAct : System.Web.UI.Page
    {
        private DTO_LineasCreditos objetoDTO = new DTO_LineasCreditos();
        DataTable tablaLineasCreditos = new DataTable(); //tabla de líneas de crédito

        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["Seleccion"] = "";

            if (IsPostBack == false) //La página no se actualiza por segunda vez
            {
                lblTitulo.Text = Convert.ToString(Session["Titulo"]);

                //Actualizar
                if (Session["Titulo"].Equals("Actualizar / Eliminar Línea Crédito"))
                {
                    BtnActualizar.Visible = true;
                    BtnEliminar.Visible = true;
                    BtnAgregar.Visible = false;
                    TxtCodigoLineaCredito.Attributes["disabled"] = "disabled";
                    MostrarLineasCreditos();


                }

                else
                {
                    //Nuevo     

                    BtnActualizar.Visible = false;
                    BtnEliminar.Visible = false;
                    BtnAgregar.Visible = true;


                }

            }
        }//fin Page_Load

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            int retornoCodigo = objetoDTO.ValidarCod(TxtCodigoLineaCredito.Text);
            bool banderaID = false;

            if (retornoCodigo == 1)//valida si encontró un código duplicado
            {
                banderaID = true;
            }


            if (banderaID == true)
            {
               Mensaje("Código duplicado", "El Código de Línea de Crédito ya se encuentra en la base de datos, por favor ingresar otro código");

            }
            else
            {
                if (ValidarVacios() == true)
                {
                    objetoDTO.AgregarCod(TxtCodigoLineaCredito.Text, TxtNombre.Text, TxtTipoAsiento.Text,
                        TxtDescripcion.Text, TxtFechaUltAct.Text, TxtPorcentajeInteres.Text,TxtTopeMaximo.Text);

                    //mostrar mensaje de usuario agregado 
                    Mensaje("Línea de crédito agregada", "La información se agregó en base de datos sin problemas");
                    limpiarForm();
                }//fin else validar vacios
            }//fin else duplicado
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            Session["Seleccion"] = "Actualizar";
            MensajeValidarAccion("Advertencia", "¿Esta seguro que desea actualizar la línea de crédito?");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Session["Seleccion"] = "Eliminar";
            MensajeValidarAccion("Advertencia", "¿Está seguro que desea eliminar la línea de crédito?");
        }

        private void MostrarLineasCreditos()
        {
            tablaLineasCreditos = objetoDTO.MostrarLinCred(Session["CodigoLineaCredito"].ToString());
            if (tablaLineasCreditos.Rows.Count > 0)
            {
                TxtCodigoLineaCredito.Text = tablaLineasCreditos.Rows[0]["CodigoLineaCredito"].ToString();
                TxtNombre.Text = tablaLineasCreditos.Rows[0]["NombreLineaCredito"].ToString();
                TxtTipoAsiento.Text = tablaLineasCreditos.Rows[0]["TipoAsiento"].ToString();
                TxtDescripcion.Text = tablaLineasCreditos.Rows[0]["Descripcion"].ToString();

                DateTime dt = Convert.ToDateTime(tablaLineasCreditos.Rows[0]["FechaUltAct"].ToString());
                TxtFechaUltAct.Text = String.Format("{0:yyyy-MM-dd}", dt);

                TxtPorcentajeInteres.Text = tablaLineasCreditos.Rows[0]["PorcentajeInteres"].ToString();
                TxtTopeMaximo.Text = tablaLineasCreditos.Rows[0]["TopeMaximo"].ToString();


            }
        }//fin MostrarLineasCreditos

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
        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdmLineasCreditos.aspx");
        }

        public bool ValidarVacios()
        {
            String Contenido, Titulo = "";
            bool bandera = true;
            Contenido = "";
            try
            {
                // Validación de código de línea de crédito
                if (TxtCodigoLineaCredito.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Código de Línea de Crédito</b></li>");
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

                // Validación de fecha de última actualización
                if (TxtFechaUltAct.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Fecha de última actualización</b></li>");
                }

                // Validación de PorcentajeInteres
                if (TxtPorcentajeInteres.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b> Porcentaje de Interés</b></li>");
                }

                // Validación de TipoAsiento
                if (TxtTipoAsiento.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Tipo de Asiento</b></li>");
                }

                // Validación de TopeMaximo
                if (TxtTopeMaximo.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Tope Máximo</b></li>");
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
            TxtCodigoLineaCredito.Text = "";
            TxtDescripcion.Text = "";
            TxtFechaUltAct.Text = "";
            TxtNombre.Text = "";
            TxtPorcentajeInteres.Text = "";
            TxtTipoAsiento.Text = "";
            TxtTopeMaximo.Text = "";

        }//fin limpiarForm

        protected void BtnSi_Click(object sender, EventArgs e)
        {
            if (Session["Seleccion"].Equals("Eliminar"))
            {

                try
                {
                    objetoDTO.EliminarCod(TxtCodigoLineaCredito.Text);
                    if (objetoDTO.ValidarCodEliminado(TxtCodigoLineaCredito.Text) == 0)
                    {
                        MensajeRegresar("Usuario eliminado", "El usuario se eliminó en base de datos sin problemas.");
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

                        objetoDTO.ActualizarCod(TxtCodigoLineaCredito.Text, TxtNombre.Text, TxtTipoAsiento.Text,
                        TxtDescripcion.Text, TxtFechaUltAct.Text, TxtPorcentajeInteres.Text, TxtTopeMaximo.Text);

                        MensajeRegresar("Línea de crédito actualizada", "Se actualizó en base de datos sin problemas");
                    }

                }

                catch (Exception ex)
                {
                    lblModalTitle.Text = "Error";
                    lblModalBody.Text = "Se ha producido un error, por favor reportelo con el siguiente detalle: " + ex.Message;

                }

            }//fin session actualizar
        }

       
    }//fin AdmLineasCreditosAct
}//fin namespace
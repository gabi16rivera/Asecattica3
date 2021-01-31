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
    public partial class AdmAjustesAct : System.Web.UI.Page
    {

        private DTO_Ajustes objetoDTO = new DTO_Ajustes();
        DataTable tablaAjustes = new DataTable(); //tabla de ajustes

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false) //La página no se actualiza por segunda vez
            {
                lblTitulo.Text = Convert.ToString(Session["Titulo"]);

                //Actualizar
                if (Session["Titulo"].Equals("Actualizar / Eliminar Ajuste"))
                {
                    BtnActualizar.Visible = true;
                    BtnEliminar.Visible = true;
                    BtnAgregar.Visible = false;
                    txtCodigo.Attributes["disabled"] = "disabled";
                    MostrarAjustes();
                }

                else
                {
                    //Nuevo    
                    BtnActualizar.Visible = false;
                    BtnEliminar.Visible = false;
                    BtnAgregar.Visible = true;
                }

            }
        }//fin load



         protected void BtnAgregar_Click(object sender, EventArgs e)
         {
             int retornoCodigo = objetoDTO.ValidarCod(txtCodigo.Text);
             bool banderaID = false;

             if (retornoCodigo == 1)//valida si encontró un código duplicado
             {
                 banderaID = true;
             }


             if (banderaID == true)
             {
                 Mensaje("Código duplicado", "La infomación ya se encuentra en la base de datos, por favor ingresar otro código");

             }
             else
             {
                 if (ValidarVacios() == true)
                 {
                     objetoDTO.AgregarCod(txtCodigo.Text, txtNombreAjuste.Text, txtTipoAjuste.Text, txtRangoInicial.Text,
                         txtRangoFinal.Text, txtPeso.Text, txtDescripcion.Text);

                     //mostrar mensaje de usuario agregado 
                     Mensaje("Asiento agregado", "La información se agregó en base de datos sin problemas");
                     limpiarForm();
                 }//fin else validar vacios
             }//fin else duplicado*/
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
       
        private void MostrarAjustes()
        {
            tablaAjustes = objetoDTO.MostrarCodAjus(Session["CodigoAjuste"].ToString());
            if (tablaAjustes.Rows.Count > 0)
            {
                
                txtCodigo.Text = tablaAjustes.Rows[0]["CodigoAjuste"].ToString();
                txtTipoAjuste.Text = tablaAjustes.Rows[0]["TipoAjuste"].ToString();
                txtDescripcion.Text = tablaAjustes.Rows[0]["Descripcion"].ToString();
                txtNombreAjuste.Text = tablaAjustes.Rows[0]["NombreAjuste"].ToString();
                txtPeso.Text = tablaAjustes.Rows[0]["Peso"].ToString();
                txtRangoFinal.Text = tablaAjustes.Rows[0]["RangoInicial"].ToString();
                txtRangoInicial.Text = tablaAjustes.Rows[0]["RangoFinal"].ToString();

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
            Response.Redirect("~/AdmAjustes.aspx");
        }

        public bool ValidarVacios()
        {
            String Contenido, Titulo = "";
            bool bandera = true;
            Contenido = "";
            try
            {
                // Validación de código de línea de crédito
                if (txtCodigo.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Código</b></li>");
                }

                // Validación de descripción
                if (txtDescripcion.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Descripción</b></li>");
                }


                // Validación de Nombre
                if (txtNombreAjuste.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Nombre</b></li>");
                }

                // Validación de peso
                if (txtPeso.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Peso</b></li>");
                }

                // Validación de Rango Inicial
                if (txtRangoFinal.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Rango Inicial</b></li>");
                }

                // Validación de RangoInicial
                if (txtRangoInicial.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Rango Inicial</b></li>");
                }

                // Validación de TipoAjuste
                if (txtTipoAjuste.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Tipo de Ajuste</b></li>");
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
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtNombreAjuste.Text = "";
            txtPeso.Text = "";
            txtRangoFinal.Text = "";
            txtRangoInicial.Text = "";
            txtTipoAjuste.Text = "";

        }//fin limpiarForm
        
        protected void BtnSi_Click(object sender, EventArgs e)
        {
            if (Session["Seleccion"].Equals("Eliminar"))
            {

                try
                {
                    objetoDTO.EliminarCod(txtCodigo.Text);
                    if (objetoDTO.ValidarCodEliminado(txtCodigo.Text) == 0)
                    {
                        MensajeRegresar("Ajuste eliminado", "El usuario se eliminó en base de datos sin problemas.");
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

                        objetoDTO.ActualizarCod(txtCodigo.Text, txtNombreAjuste.Text, txtTipoAjuste.Text, 
                            txtRangoInicial.Text, txtRangoFinal.Text, txtPeso.Text, txtDescripcion.Text);

                        MensajeRegresar("Ajuste actualizado", "Se actualizó en base de datos sin problemas");
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
}

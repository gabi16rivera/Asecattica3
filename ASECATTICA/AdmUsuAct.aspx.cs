using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Security.Cryptography;

namespace ASECATTICA
{
    public partial class AdmUsuAct : System.Web.UI.Page
    {
        private DTO_Usuarios objetoDTO = new DTO_Usuarios();
        DTO_Usuarios objeto = new DTO_Usuarios();
        DataTable tabla = new DataTable(); //tabla de usuarios
        DataTable tablaRol = new DataTable();
        DataTable tablaEstado = new DataTable();
        DataTable tablaUbicacion = new DataTable();
        DataTable tablaCentroCosto = new DataTable();
        DataSet dpRol = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (IsPostBack == false) //La página no se actualiza por segunda vez
            {
            lblTitulo.Text = Convert.ToString(Session["Titulo"]);
                
            //Actualizar
            if (Session["Titulo"].Equals("Actualizar / Eliminar Usuario"))
            {
                BtnActualizar.Visible = true;
                BtnEliminar.Visible = true;
                BtnAgregar.Visible = false;
                TextBoxIDAsecattica.Attributes["disabled"] = "disabled";
                    lblFechaSalida.Enabled = false;
                    MostrarUsuarios();
            }
               
                else {
            //Nuevo     
                BtnActualizar.Visible = false;
                BtnEliminar.Visible = false;
                BtnAgregar.Visible = true;
                TextBoxFechaSalida.Visible = false;
                MostrarDropdowList();

                }

            }
            
        }//fin Page_Load

        private void MostrarDropdowList() {

            tablaRol = objeto.MostrarRol();
            //revisa todos los código de roles de TBRoles
            if (!IsPostBack)
            {
                DropDownListRol.Items.Insert(0, new ListItem("Seleccione el rol:", String.Empty));
                ListItem i;
                foreach (DataRow r in tablaRol.Rows)
                {
                    i = new ListItem(r["CodigoRoles"].ToString(), r["CodigoRoles"].ToString());
                    DropDownListRol.SelectedIndex = 0;
                    DropDownListRol.Items.Add(i);
                }

            }//fin if revisa roles

            tablaEstado = objeto.MostrarEstado();
            //revisa todos los código de estados de TBEstados
            if (!IsPostBack)
            {
                DropDownListEstado.Items.Insert(0, new ListItem("Seleccione el estado:", String.Empty));
                ListItem i;
                foreach (DataRow r in tablaEstado.Rows)
                {
                    i = new ListItem(r["CodigoEstado"].ToString(), r["CodigoEstado"].ToString());
                    DropDownListEstado.SelectedIndex = 0;
                    DropDownListEstado.Items.Add(i);
                }

            }//fin if revisa estados

            tablaUbicacion = objeto.MostrarUbica();
            //revisa todos los código de ubicación de TBUbicacion
            if (!IsPostBack)
            {
                DropDownListUbica.Items.Insert(0, new ListItem("Seleccione la ubicación:", String.Empty));
                ListItem i;
                foreach (DataRow r in tablaUbicacion.Rows)
                {
                    i = new ListItem(r["CodigoUbicacion"].ToString(), r["CodigoUbicacion"].ToString());
                    DropDownListUbica.SelectedIndex = 0;
                    DropDownListUbica.Items.Add(i);
                }

            }//fin if revisa ubicacion

            tablaCentroCosto = objeto.MostrarCentroCos();
            //revisa todos los código de centro de costo de TBCentroCosto
            if (!IsPostBack)
            {
                DropDownListCentroCosto.Items.Insert(0, new ListItem("Seleccione el centro de costo:", String.Empty));
                ListItem i;
                foreach (DataRow r in tablaCentroCosto.Rows)
                {
                    i = new ListItem(r["Codigo"].ToString(), r["Codigo"].ToString());
                    DropDownListCentroCosto.SelectedIndex = 0;
                    DropDownListCentroCosto.Items.Add(i);
                }

            }//fin if revisa centro de costo

        }//fin MostrarDropdowList

        private void MostrarUsuarios()
        {
            
            tabla = objeto.MostrarUsu(Session["ID_Asecattica"].ToString());
            tablaRol = objeto.MostrarRol();
            tablaEstado = objeto.MostrarEstado();
            tablaUbicacion = objeto.MostrarUbica();
            tablaCentroCosto = objeto.MostrarCentroCos();

            if (tabla.Rows.Count > 0)
            {
                TextBoxIDAsecattica.Text = tabla.Rows[0]["ID_Asecattica"].ToString();
                TextBoxCedula.Text = tabla.Rows[0]["Cedula"].ToString();
                TextBoxNombre.Text = tabla.Rows[0]["Nombre"].ToString();
                TextBoxApellido1.Text = tabla.Rows[0]["Apellido1"].ToString();
                TextBoxApellido2.Text = tabla.Rows[0]["Apellido2"].ToString();
             
            //revisa todos los código de roles de TBRoles
            if (!IsPostBack)
            {
                int indice, contador;
                indice = -1;
                contador = 0;
                ListItem i;
                foreach (DataRow r in tablaRol.Rows)
                {
                    i = new ListItem(r["CodigoRoles"].ToString());
                    string rol;
                    rol = tabla.Rows[0]["Rol"].ToString();
                    if (rol == i.ToString()){
                        indice = contador;
                    }
                    else
                    {
                        contador = contador + 1;
                    }
                    DropDownListRol.Items.Add(i);
                    DropDownListRol.DataSource = tablaRol;
                }//fin foreach

                DropDownListRol.SelectedIndex = indice;
                DropDownListRol.SelectedItem.Text = DropDownListRol.SelectedItem.Text;
            }//fin if revisa roles

            //revisa todos los código de estados de TBEstados
            if (!IsPostBack)
            {
                int indice, contador;
                indice = -1;
                contador = 0;
               ListItem i;
                foreach (DataRow r in tablaEstado.Rows)
                {
                    i = new ListItem(r["CodigoEstado"].ToString());
                    string estado;
                    estado = tabla.Rows[0]["Estado"].ToString();
                    if (estado == i.ToString())
                    {
                        indice = contador;
                    }
                    else
                    {
                        contador = contador + 1;
                    }
                    DropDownListEstado.Items.Add(i);
                    DropDownListEstado.DataSource = tablaEstado;
                }//fin foreach

                DropDownListEstado.SelectedIndex = indice;
                DropDownListEstado.SelectedItem.Text = DropDownListEstado.SelectedItem.Text;
            }//fin if revisa estado

            //revisa todos los código de estados de TBUbicacion
            if (!IsPostBack)
            {
                int indice, contador;
                indice = -1;
                contador = 0;
                ListItem i;
                foreach (DataRow r in tablaUbicacion.Rows)
                {
                    i = new ListItem(r["CodigoUbicacion"].ToString());
                    string ubicacion;
                    ubicacion = tabla.Rows[0]["Ubicacion"].ToString();
                    if (ubicacion == i.ToString())
                    {
                        indice = contador;
                    }
                    else
                    {
                        contador = contador + 1;
                    }
                    DropDownListUbica.Items.Add(i);
                    DropDownListUbica.DataSource = tablaUbicacion;
                }//fin foreach

                DropDownListUbica.SelectedIndex = indice;
                DropDownListUbica.SelectedItem.Text = DropDownListUbica.SelectedItem.Text;
            }//fin if revisa ubicación

                //revisa todos los código de roles de TBCentroCosto
                if (!IsPostBack)
                {
                    int indice, contador;
                    indice = -1;
                    contador = 0;
                    ListItem i;
                    foreach (DataRow r in tablaCentroCosto.Rows)
                    {
                        i = new ListItem(r["Codigo"].ToString());
                        string rol;
                        rol = tabla.Rows[0]["CentroCosto"].ToString();
                        if (rol == i.ToString())
                        {
                            indice = contador;
                        }
                        else
                        {
                            contador = contador + 1;
                        }
                        DropDownListCentroCosto.Items.Add(i);
                        DropDownListCentroCosto.DataSource = tablaRol;
                    }//fin foreach

                    DropDownListCentroCosto.SelectedIndex = indice;
                    DropDownListCentroCosto.SelectedItem.Text = DropDownListCentroCosto.SelectedItem.Text;
                }//fin if revisa centro de costos

                TextBoxCorreo.Text = tabla.Rows[0]["Correo"].ToString();
            TextBoxClave.Text = tabla.Rows[0]["Clave"].ToString();
            TextBoxTelefono.Text = tabla.Rows[0]["Telefono"].ToString();

            DateTime dt = Convert.ToDateTime(tabla.Rows[0]["FechaNacim"].ToString());
            TextBoxFechaNac.Text = String.Format("{0:yyyy-MM-dd}", dt);

            TextBoxEdad.Text = tabla.Rows[0]["Edad"].ToString();
            TextBoxDireccion.Text = tabla.Rows[0]["Direccion"].ToString();
            TextBoxSexo.Text = tabla.Rows[0]["Sexo"].ToString();
            
            dt = Convert.ToDateTime(tabla.Rows[0]["FechaIngreso"].ToString());
            TextBoxFechaIngreso.Text = String.Format("{0:yyyy-MM-dd}", dt);

            dt = Convert.ToDateTime(tabla.Rows[0]["FechaSalida"].ToString());
            TextBoxFechaSalida.Text = String.Format("{0:yyyy-MM-dd}", dt);

            }//fin if tabla counts mayor a cero
        }//fin método mostrar usuarios

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            int retornoID = objeto.ValidarIDAse(TextBoxIDAsecattica.Text);
            bool banderaID = false;

            if (retornoID == 1)//valida si encontró un IDAsecattica duplicado
            {
                banderaID = true;
            }
            if (banderaID == true)
            {
                Mensaje("Usuario duplicado", "El ID Asecattica ya se encuentra en la base de datos, por favor ingresar uno nuevo");
            }
            else
            {
                if (ValidarVacios() == true)
                {
                    string claveEncriptada = EncriptarContraseña(TextBoxClave.Text);
                    objetoDTO.AgregarUsu(TextBoxIDAsecattica.Text, TextBoxCedula.Text, TextBoxNombre.Text, DropDownListUbica.Text,
                        TextBoxApellido1.Text, TextBoxApellido2.Text,
                         DropDownListRol.Text, DropDownListEstado.Text, TextBoxCorreo.Text, claveEncriptada,
                         TextBoxTelefono.Text, TextBoxFechaNac.Text, TextBoxEdad.Text,
                         TextBoxDireccion.Text, TextBoxSexo.Text, TextBoxFechaIngreso.Text, TextBoxFechaSalida.Text = "");

                    //mostrar mensaje de usuario agregado 
                    Mensaje("Usuario agregado", "El usuario se agregó en base de datos sin problemas");
                    limpiarForm();
                }//fin else validar vacios
            }//fin else duplicado


        }//fin BtnAgregar_Click


        private void limpiarForm()
        {
            TextBoxIDAsecattica.Text = "";
            TextBoxCedula.Text = "";
            TextBoxNombre.Text = "";
            //DropDownListUbica.Text = "Seleccione la ubicación";
            TextBoxApellido1.Text = "";
            TextBoxApellido2.Text = "";
            //DropDownListRol.Text = "Seleccione el rol";
            //DropDownListEstado.Text = "Seleccione el estado";
            TextBoxCorreo.Text = "";
            TextBoxClave.Text = "";
            TextBoxTelefono.Text = "";
            TextBoxFechaNac.Text = "";
            TextBoxEdad.Text = "";
            TextBoxDireccion.Text = "";
            TextBoxSexo.Text = "";
            TextBoxFechaIngreso.Text = "";
            //TextBoxFechaSalida.Text = "";

        }//fin limpiarForm

        public string EncriptarContraseña(string claveOriginal) {

            SHA1 sha1 = new SHA1CryptoServiceProvider();

            byte[] inputBytes = (new System.Text.UnicodeEncoding()).GetBytes(claveOriginal);
            byte[] hash = sha1.ComputeHash(inputBytes);

            return Convert.ToBase64String(hash);
        }//fin EncriptarContraseña


        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            try {

                //MensajeButton("Advertencia", "¿Esta seguro que desea actualizar el usuario?");

                if (ValidarVacios() == true)
                {
                    string claveEncriptada = EncriptarContraseña(TextBoxClave.Text);
                    objetoDTO.ActualizarUsu(TextBoxIDAsecattica.Text, TextBoxCedula.Text, DropDownListUbica.Text, TextBoxNombre.Text, 
                    TextBoxApellido1.Text, TextBoxApellido2.Text,
                    DropDownListRol.Text, DropDownListEstado.Text, TextBoxCorreo.Text, TextBoxTelefono.Text, TextBoxFechaNac.Text,
                    TextBoxEdad.Text, TextBoxDireccion.Text, TextBoxSexo.Text, TextBoxFechaIngreso.Text, TextBoxFechaSalida.Text,
                    claveEncriptada);

                    Mensaje("Usuario actualizado", "El usuario se actualizó en base de datos sin problemas");
                    //Response.Redirect("AdmUsu.aspx");
                }
                
            }
            
            catch (Exception ex)
            {
                lblModalTitle.Text = "Error";
                lblModalBody.Text = "Se ha producido un error, por favor reportelo con el siguiente detalle: " + ex.Message;

            }
            //finally
            //{
            //    Response.Redirect("AdmUsu.aspx");
           // }
        }//fin BtnActualizar_Click

        protected void btnCerrar_Click(object sender, EventArgs e) { 
        
        }


        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try { 
            objetoDTO.EliminarUsu(TextBoxIDAsecattica.Text);
            Mensaje("Usuario eliminado", "El usuario se eliminó en base de datos sin problemas");
            //Response.Redirect("AdmUsu.aspx");
            }

            catch (Exception ex)
            {
                lblModalTitle.Text = "Error";
                lblModalBody.Text = "Se ha producido un error, por favor reportelo con el siguiente detalle: " + ex.Message;
                
            }

        }

        
        public bool ValidarVacios()
        {
            String Contenido, Titulo = "";
            bool bandera = true;
            Contenido = "";
            try
            {
                // Validación de IDAsecattica
                if (TextBoxIDAsecattica.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>ID Asecattica</b></li>");
                }

                // Validación de cédula
                if (TextBoxCedula.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Cédula</b></li>");
                }

                // Validación de Ubicación
                if (DropDownListUbica.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Ubicación</b></li>");
                }

                // Validación de Nombre
                if (TextBoxNombre.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Nombre</b></li>");
                }

                // Validación de Apellido1
                if (TextBoxApellido1.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Apellido 1</b></li>");
                }

                // Validación de Apellido2
                if (TextBoxApellido2.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Apellido 2</b></li>");
                }

                // Validación de Rol
                if (DropDownListRol.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Rol</b></li>");
                }

                // Validación de Estado
                if (DropDownListEstado.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Estado</b></li>");
                }

                // Validación de Correo Electrónico
                if (TextBoxCorreo.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Correo Electrónico</b></li>");
                }

                // Validación de Telefono
                if (TextBoxTelefono.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Teléfono</b></li>");
                }

                // Validación de Fecha de nacimiento
                if (TextBoxFechaNac.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Fecha de nacimiento</b></li>");
                }

                // Validación de Edad
                if (TextBoxEdad.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Edad</b></li>");
                }

                // Dirección
                if (TextBoxDireccion.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Dirección</b></li>");
                }

                // Validación de Sexo
                if (TextBoxSexo.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Sexo</b></li>");
                }

                // Validación de Fecha de ingreso
                if (TextBoxFechaIngreso.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Fecha de ingreso</b></li>");
                }

                // Validación de Fecha de salida
                /*if (TextBoxFechaSalida.Text == "")
                {
                    bandera = false;
                    Contenido = Contenido + System.Convert.ToString("<li>Debe completar <b>Fecha de salida</b></li>");
                }*/

                       
                if (bandera == true) { 
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
        
        
        public void Mensaje (string titulo, string contenido)
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
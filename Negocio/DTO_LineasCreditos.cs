using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class DTO_LineasCreditos
    {
        
        private DAO_LineasCreditos objetoDAO = new DAO_LineasCreditos();
        public DataTable MostrarLinCred(string CodigoLineaCredito)
        {
            DataTable tabla = new DataTable();
            tabla = objetoDAO.MostrarLineasCreditos(CodigoLineaCredito);

            return tabla;
        }

        public int ValidarCod(string codigoLineaCredito)
        {
            int datoretornoID = objetoDAO.ValidarCodigo(codigoLineaCredito);

            return datoretornoID;
        }

        public void AgregarCod(string codigoLineaCredito, string nombreLineaCredito,
            string tipoAsiento, string descripcion, string fechaUltAct, string porcentajeInteres, 
            string topeMaximo)
        {

            objetoDAO.AgregarCodigo(codigoLineaCredito, nombreLineaCredito, tipoAsiento, descripcion,
                fechaUltAct, porcentajeInteres, topeMaximo);
        }

        public void EliminarCod(string codigoLineaCredito)
        {

            objetoDAO.EliminarCodigo(codigoLineaCredito);
        }

        public int ValidarCodEliminado(string codigoLineaCredito)
        {
            int datoretorno = objetoDAO.ValidarCodigoEliminado(codigoLineaCredito);

            return datoretorno;
        }

        public void ActualizarCod(string codigoLineaCredito, string nombreLineaCredito,
            string tipoAsiento, string descripcion, string fechaUltAct, string porcentajeInteres,
            string topeMaximo)
        {
            objetoDAO.ActualizarCodigo(codigoLineaCredito, nombreLineaCredito, tipoAsiento, descripcion,
                fechaUltAct, porcentajeInteres, topeMaximo);
        }

        //-----------------------------------------------------USUARIOS-----------------------------------------

        /* public int ValidarUsuEliminado(string ID_Asecattica)
         {
             int datoretornoID = objetoDAO.ValidarUsuarioEliminado(ID_Asecattica);

             return datoretornoID;
         }

         public int ValidarIDAse(string ID_Asecattica)
         {
             int datoretornoID = objetoDAO.ValidarIDAsecattica(ID_Asecattica);

             return datoretornoID;
         }

         public int ValidarCedu(string cedula)
         {
             int datoretornoCedula = objetoDAO.ValidarCedula(cedula);

             return datoretornoCedula;
         }

         public DataTable MostrarUsu(string ID_Asecattica)
         {
             DataTable tabla = new DataTable();
             tabla = objetoDAO.MostrarUsuario(ID_Asecattica);

             return tabla;
         }

         public DataTable MostrarRol()
         {
             DataTable tablaRoles = new DataTable();

             tablaRoles = objetoDAO.MostrarRoles();
             return tablaRoles;
         }

         public DataTable MostrarEstado()
         {
             DataTable tablaEstados = new DataTable();

             tablaEstados = objetoDAO.MostrarEstados();
             return tablaEstados;
         }

         public DataTable MostrarUbica()
         {
             DataTable tablaUbicacion = new DataTable();

             tablaUbicacion = objetoDAO.MostrarUbicacion();
             return tablaUbicacion;
         }

         public DataTable MostrarCentroCos()
         {
             DataTable tablaCentroCosto = new DataTable();

             tablaCentroCosto = objetoDAO.MostrarCentroCosto();
             return tablaCentroCosto;
         }

         public void ActualizarUsu(string ID_Asecattica, string cedula, string ubicacion,
             string nombre, string apellido1, string apellido2, string rol, string estado, string correo,
             string telefono, string fechaNacim, string edad, string direccion, string sexo,
             string fechaIngreso, string fechaSalida, string clave)
         {
             objetoDAO.ActualizarUsuarios(ID_Asecattica, cedula, ubicacion, nombre, apellido1, apellido2,
                 rol, estado, correo, telefono, fechaNacim, edad, direccion, sexo, fechaIngreso, fechaSalida, clave);
         }

         public void AgregarUsu(string ID_Asecattica, string cedula, string ubicacion,
             string nombre, string apellido1, string apellido2, string rol, string estado, string correo, string clave,
             string telefono, string fechaNacim, string edad, string direccion, string sexo,
             string fechaIngreso, string fechaSalida)
         {

             objetoDAO.AgregarUsuarios(ID_Asecattica, cedula, ubicacion, nombre, apellido1, apellido2,
                 rol, estado, correo, clave, telefono, fechaNacim, edad, direccion, sexo, fechaIngreso, fechaSalida);
         }

         public void EliminarUsu(string ID_Asecattica)
         {

             objetoDAO.EliminarUsuarios(ID_Asecattica);
         }*/

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DAO_LineasCreditos 
    { 

        private DAO_Conexion conexion = new DAO_Conexion();

        public DataTable MostrarLineasCreditos(string codigoLineaCredito)
        {
            DataTable tabla = new DataTable();
            SqlDataReader leer;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTiposLineasCreditos";
            comando.Parameters.AddWithValue("@choice", "SELECT_CODIGO");
            comando.Parameters.AddWithValue("@CodigoLineaCredito", codigoLineaCredito);
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public int ValidarCodigo(string codigoLineaCredito)
        {
            SqlCommand comandoActUsu = new SqlCommand();
            comandoActUsu.Connection = conexion.AbrirConexion();
            comandoActUsu.CommandText = "sp_crud_TBTiposLineasCreditos";
            comandoActUsu.CommandType = CommandType.StoredProcedure;
            comandoActUsu.Parameters.AddWithValue("@choice", "VALIDAR_CODIGO");
            comandoActUsu.Parameters.AddWithValue("@CodigoLineaCredito", codigoLineaCredito);

            return (int)comandoActUsu.ExecuteScalar();

        }


        public void AgregarCodigo(string codigoLineaCredito, string nombreLineaCredito, string tipoAsiento,
            string descripcion, string fechaUltAct, string porcentajeInteres, string topeMaximo)
        {
            SqlCommand comandoAgregarUsu = new SqlCommand();
            comandoAgregarUsu.Connection = conexion.AbrirConexion();
            comandoAgregarUsu.CommandText = "sp_crud_TBTiposLineasCreditos";
            comandoAgregarUsu.CommandType = CommandType.StoredProcedure;
            comandoAgregarUsu.Parameters.AddWithValue("@choice", "INSERT");
            comandoAgregarUsu.Parameters.AddWithValue("@CodigoLineaCredito", codigoLineaCredito);
            comandoAgregarUsu.Parameters.AddWithValue("@NombreLineaCredito", nombreLineaCredito);
            comandoAgregarUsu.Parameters.AddWithValue("@TipoAsiento", tipoAsiento);
            comandoAgregarUsu.Parameters.AddWithValue("@Descripcion", descripcion);
            comandoAgregarUsu.Parameters.AddWithValue("@FechaUltAct", fechaUltAct);
            comandoAgregarUsu.Parameters.AddWithValue("@PorcentajeInteres", porcentajeInteres);
            comandoAgregarUsu.Parameters.AddWithValue("@TopeMaximo", topeMaximo);
            comandoAgregarUsu.ExecuteNonQuery(); //excepción de duplicado de id
            comandoAgregarUsu.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void ActualizarCodigo(string codigoLineaCredito, string nombreLineaCredito, string tipoAsiento,
            string descripcion, string fechaUltAct, string porcentajeInteres, string topeMaximo)
        {
            SqlCommand comandoActUsu = new SqlCommand();
            comandoActUsu.Connection = conexion.AbrirConexion();
            comandoActUsu.CommandText = "sp_crud_TBTiposLineasCreditos";
            comandoActUsu.CommandType = CommandType.StoredProcedure;
            comandoActUsu.Parameters.AddWithValue("@choice", "UPDATE");
            comandoActUsu.Parameters.AddWithValue("@CodigoLineaCredito", codigoLineaCredito);
            comandoActUsu.Parameters.AddWithValue("@NombreLineaCredito", nombreLineaCredito);
            comandoActUsu.Parameters.AddWithValue("@TipoAsiento", tipoAsiento);
            comandoActUsu.Parameters.AddWithValue("@TopeMaximo", topeMaximo);
            comandoActUsu.Parameters.AddWithValue("@Descripcion", descripcion);
            comandoActUsu.Parameters.AddWithValue("@FechaUltAct", fechaUltAct);
            comandoActUsu.Parameters.AddWithValue("@PorcentajeInteres", porcentajeInteres);
            comandoActUsu.ExecuteNonQuery();
            comandoActUsu.Parameters.Clear();
            conexion.CerrarConexion();

        }//fin actualizar usuarios

        public void EliminarCodigo(string codigoLineaCredito)
        {
            SqlCommand comandoAgregarUsu = new SqlCommand();
            comandoAgregarUsu.Connection = conexion.AbrirConexion();
            comandoAgregarUsu.CommandText = "sp_crud_TBTiposLineasCreditos";
            comandoAgregarUsu.CommandType = CommandType.StoredProcedure;
            comandoAgregarUsu.Parameters.AddWithValue("@choice", "DELETE");
            comandoAgregarUsu.Parameters.AddWithValue("@CodigoLineaCredito", codigoLineaCredito);
            comandoAgregarUsu.ExecuteNonQuery(); //excepción de duplicado de id
            comandoAgregarUsu.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public int ValidarCodigoEliminado(string codigoLineaCredito)
        {
            SqlCommand comandoActUsu = new SqlCommand();
            comandoActUsu.Connection = conexion.AbrirConexion();
            comandoActUsu.CommandText = "sp_crud_TBTiposLineasCreditos";
            comandoActUsu.CommandType = CommandType.StoredProcedure;
            comandoActUsu.Parameters.AddWithValue("@choice", "VALIDA_COD_ELIMINADO");
            comandoActUsu.Parameters.AddWithValue("@CodigoLineaCredito", codigoLineaCredito);
            if (comandoActUsu.ExecuteScalar() == null)
            {
                return 0;

            }
            else
            {
                return (int)comandoActUsu.ExecuteScalar();
            }

        }

        public void ActualizarUsuarios(string ID_Asecattica, string cedula, string ubicacion,
            string nombre, string apellido1, string apellido2, string rol, string estado, string correo,
            string telefono, string fechaNacim, string edad, string direccion, string sexo,
            string fechaIngreso, string fechaSalida, string clave)
        {
            SqlCommand comandoActUsu = new SqlCommand();
            comandoActUsu.Connection = conexion.AbrirConexion();
            comandoActUsu.CommandText = "sp_crud_TBUsuarios";
            comandoActUsu.CommandType = CommandType.StoredProcedure;
            comandoActUsu.Parameters.AddWithValue("@choice", "UPDATE");
            comandoActUsu.Parameters.AddWithValue("@ID_Asecattica", ID_Asecattica);
            comandoActUsu.Parameters.AddWithValue("@Cedula", cedula);
            comandoActUsu.Parameters.AddWithValue("@Ubicacion", ubicacion);
            comandoActUsu.Parameters.AddWithValue("@Nombre", nombre);
            comandoActUsu.Parameters.AddWithValue("@Apellido1", apellido1);
            comandoActUsu.Parameters.AddWithValue("@Apellido2", apellido2);
            comandoActUsu.Parameters.AddWithValue("@Rol", rol);
            comandoActUsu.Parameters.AddWithValue("@Estado", estado);
            comandoActUsu.Parameters.AddWithValue("@Correo", correo);
            comandoActUsu.Parameters.AddWithValue("@Telefono", telefono);
            comandoActUsu.Parameters.AddWithValue("@FechaNacim", fechaNacim);
            comandoActUsu.Parameters.AddWithValue("@Edad", edad);
            comandoActUsu.Parameters.AddWithValue("@Direccion", direccion);
            comandoActUsu.Parameters.AddWithValue("@Sexo", sexo);
            comandoActUsu.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
            comandoActUsu.Parameters.AddWithValue("@fechaSalida", fechaSalida);
            comandoActUsu.Parameters.AddWithValue("@Clave", clave);
            comandoActUsu.ExecuteNonQuery();
            comandoActUsu.Parameters.Clear();
            conexion.CerrarConexion();

        }//fin actualizar usuarios

        
    }
}
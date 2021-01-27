using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DAO_Asientos
    { 

        private DAO_Conexion conexion = new DAO_Conexion();

        public DataTable MostrarAsientos(string codigoAsiento)
        {
            DataTable tabla = new DataTable();
            SqlDataReader leer;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTipoAsiento";
            comando.Parameters.AddWithValue("@choice", "SELECT_CODIGO");
            comando.Parameters.AddWithValue("@CodigoTipoAsiento", codigoAsiento);
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public int ValidarCodigo(string codigoAsiento)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTipoAsiento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "VALIDAR_CODIGO");
            comando.Parameters.AddWithValue("@CodigoTipoAsiento", codigoAsiento);

            return (int)comando.ExecuteScalar();

        }


        public void AgregarCodigo(string codigoAsiento, string tipo, string descripcion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTipoAsiento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "INSERT");
            comando.Parameters.AddWithValue("@CodigoTipoAsiento", codigoAsiento);
            comando.Parameters.AddWithValue("@TipoAsiento", tipo);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.ExecuteNonQuery(); //excepción de duplicado de id
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void ActualizarCodigo(string codigoAsiento, string tipo, string descripcion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTipoAsiento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "UPDATE");
            comando.Parameters.AddWithValue("@CodigoTipoAsiento", codigoAsiento);
            comando.Parameters.AddWithValue("@TipoAsiento", tipo);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }//fin actualizar usuarios

        public void EliminarCodigo(string codigoAsiento)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTipoAsiento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "DELETE");
            comando.Parameters.AddWithValue("@CodigoTipoAsiento", codigoAsiento);
            comando.ExecuteNonQuery(); //excepción de duplicado de id
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public int ValidarCodigoEliminado(string codigoAsiento)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTipoAsiento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "VALIDA_COD_ELIMINADO");
            comando.Parameters.AddWithValue("@CodigoTipoAsiento", codigoAsiento);
            if (comando.ExecuteScalar() == null)
            {
                return 0;

            }
            else
            {
                return (int)comando.ExecuteScalar();
            }

        }

        
    }
}
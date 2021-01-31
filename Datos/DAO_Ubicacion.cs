using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DAO_Ubicacion
    { 

        private DAO_Conexion conexion = new DAO_Conexion();

        public DataTable MostrarUbicacion(string codigo)
        {
            DataTable tabla = new DataTable();
            SqlDataReader leer;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBUbicacion";
            comando.Parameters.AddWithValue("@choice", "SELECT_CODIGO");
            comando.Parameters.AddWithValue("@Codigo", codigo);
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public int ValidarCodigo(string codigo)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBUbicacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "VALIDAR_CODIGO");
            comando.Parameters.AddWithValue("@Codigo", codigo);

            return (int)comando.ExecuteScalar();

        }


        public void AgregarCodigo(string codigo, string nombre, string descripcion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBUbicacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "INSERT");
            comando.Parameters.AddWithValue("@Codigo", codigo);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.ExecuteNonQuery(); //excepción de duplicado de id
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void ActualizarCodigo(string codigo, string nombre, string descripcion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBUbicacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "UPDATE");
            comando.Parameters.AddWithValue("@Codigo", codigo);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }//fin actualizar usuarios

        public void EliminarCodigo(string codigo)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBUbicacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "DELETE");
            comando.Parameters.AddWithValue("@Codigo", codigo);
            comando.ExecuteNonQuery(); //excepción de duplicado de id
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public int ValidarCodigoEliminado(string codigo)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBUbicacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "VALIDA_COD_ELIMINADO");
            comando.Parameters.AddWithValue("@Codigo", codigo);
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
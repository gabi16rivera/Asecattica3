using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DAO_Ajustes
    { 

        private DAO_Conexion conexion = new DAO_Conexion();

        public DataTable MostrarAjustes(string codigoAjuste)
        {
            DataTable tabla = new DataTable();
            SqlDataReader leer;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBAjustes";
            comando.Parameters.AddWithValue("@choice", "SELECT_CODIGO");
            comando.Parameters.AddWithValue("@CodigoAjuste", codigoAjuste);
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public int ValidarCodigo(string codigoAjuste)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBAjustes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "VALIDAR_CODIGO");
            comando.Parameters.AddWithValue("@CodigoAjuste", codigoAjuste);

            return (int)comando.ExecuteScalar();

        }


        public void AgregarCodigo(string codigoAjuste, string nombreAjuste, string tipoAjuste,
            string rangoInicial, string rangoFinal, string peso, string descripcion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBAjustes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "INSERT");
            comando.Parameters.AddWithValue("@CodigoAjuste", codigoAjuste);
            comando.Parameters.AddWithValue("@NombreAjuste", nombreAjuste);
            comando.Parameters.AddWithValue("@TipoAjuste", tipoAjuste);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@RangoInicial", rangoInicial);
            comando.Parameters.AddWithValue("@RangoFinal", rangoFinal);
            comando.Parameters.AddWithValue("@Peso", peso);
            comando.ExecuteNonQuery(); //excepción de duplicado de id
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void ActualizarCodigo(string codigoAjuste, string nombreAjuste, string tipoAjuste,
            string rangoInicial, string rangoFinal, string peso, string descripcion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBAjustes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "UPDATE");
            comando.Parameters.AddWithValue("@CodigoAjuste", codigoAjuste);
            comando.Parameters.AddWithValue("@NombreAjuste", nombreAjuste);
            comando.Parameters.AddWithValue("@TipoAjuste", tipoAjuste);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@RangoInicial", rangoInicial);
            comando.Parameters.AddWithValue("@RangoFinal", rangoFinal);
            comando.Parameters.AddWithValue("@Peso", peso);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }//fin actualizar usuarios

        public void EliminarCodigo(string codigoAjuste)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBAjustes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "DELETE");
            comando.Parameters.AddWithValue("@CodigoAjuste", codigoAjuste);
            comando.ExecuteNonQuery(); //excepción de duplicado de id
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public int ValidarCodigoEliminado(string codigoAjuste)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBAjustes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "VALIDA_COD_ELIMINADO");
            comando.Parameters.AddWithValue("@CodigoAjuste", codigoAjuste);
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
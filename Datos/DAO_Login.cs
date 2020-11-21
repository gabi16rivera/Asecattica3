using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DAO_Login
    {
        private DAO_Conexion conexion = new DAO_Conexion();
        public int ValidarLogin(string cedula,string clave)
        {
            SqlCommand comandoValidar = new SqlCommand();
            comandoValidar.Connection = conexion.AbrirConexion();
            comandoValidar.CommandText = "sp_crud_TBUsuarios";
            comandoValidar.CommandType = CommandType.StoredProcedure;
            comandoValidar.Parameters.AddWithValue("@choice", "VALIDAR_LOGIN");
            comandoValidar.Parameters.AddWithValue("@Cedula", cedula);
            comandoValidar.Parameters.AddWithValue("@clave", clave);

            return (int)comandoValidar.ExecuteScalar();

        }//validar login

        public int ValidarCedula(string cedula)
        {
            SqlCommand comandoValidar = new SqlCommand();
            comandoValidar.Connection = conexion.AbrirConexion();
            comandoValidar.CommandText = "sp_crud_TBUsuarios";
            comandoValidar.CommandType = CommandType.StoredProcedure;
            comandoValidar.Parameters.AddWithValue("@choice", "VALIDAR_CEDULA");
            comandoValidar.Parameters.AddWithValue("@Cedula", cedula);

            return (int)comandoValidar.ExecuteScalar();

        }//validar login

        public DataTable ValidarCorreo(string cedula)
        {
            DataTable tabla = new DataTable();
            SqlDataReader leer;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "VALIDAR_CORREO");
            comando.Parameters.AddWithValue("@Cedula", cedula);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }//fin validar correo

        public void ActualizarClave(string cedula, string clave)
        {
            SqlCommand comandoActUsu = new SqlCommand();
            comandoActUsu.Connection = conexion.AbrirConexion();
            comandoActUsu.CommandText = "sp_crud_TBUsuarios";
            comandoActUsu.CommandType = CommandType.StoredProcedure;
            comandoActUsu.Parameters.AddWithValue("@choice", "USU_MODIFICAR_CLAVE");
            comandoActUsu.Parameters.AddWithValue("@Cedula", cedula);
            comandoActUsu.Parameters.AddWithValue("@Clave", clave);
            comandoActUsu.ExecuteNonQuery();
            comandoActUsu.Parameters.Clear();
            conexion.CerrarConexion();

        }//fin actualizar usuarios

    }
}
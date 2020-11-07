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
            SqlCommand comandoActUsu = new SqlCommand();
            comandoActUsu.Connection = conexion.AbrirConexion();
            comandoActUsu.CommandText = "sp_crud_TBUsuarios";
            comandoActUsu.CommandType = CommandType.StoredProcedure;
            comandoActUsu.Parameters.AddWithValue("@choice", "VALIDAR_LOGIN");
            comandoActUsu.Parameters.AddWithValue("@Cedula", cedula);
            comandoActUsu.Parameters.AddWithValue("@clave", clave);

            return (int)comandoActUsu.ExecuteScalar();

        }//validar login


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class DAO_Conexion
    {
        private SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["bdAsecatticaConnectionString"].ConnectionString);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }


    }
}
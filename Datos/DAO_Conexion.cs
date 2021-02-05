using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DAO_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=SQL5063.site4now.net;Initial Catalog=DB_A6C94E_bdAsecattica;User Id=DB_A6C94E_bdAsecattica_admin;Password=4553c4tt1c4");
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
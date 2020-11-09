﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class DTO_Login
    {
        
        private DAO_Login objetoDAO = new DAO_Login();

        public int ValidarLoginUsu(string cedula, string clave)
        {
            int datoretornoID = objetoDAO.ValidarLogin(cedula, clave);

            return datoretornoID;
        }

        public DataTable ValidarCorreoUsu(string cedula)
        {
            DataTable tabla = new DataTable();
            tabla = objetoDAO.ValidarCorreo(cedula);

            return tabla;
        }

        

}
}
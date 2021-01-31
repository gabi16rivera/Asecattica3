using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class DTO_Roles
    {
        
        private DAO_Roles objetoDAO = new DAO_Roles();
        public DataTable MostrarRole(string codigo)
        {
            DataTable tabla = new DataTable();
            tabla = objetoDAO.MostrarRoles(codigo);

            return tabla;
        }

        public int ValidarCod(string codigo)
        {
            int datoretornoID = objetoDAO.ValidarCodigo(codigo);

            return datoretornoID;
        }

        public void AgregarCod(string codigo, string nombre, string descripcion)
        {

            objetoDAO.AgregarCodigo(codigo, nombre, descripcion);
        }

        public void EliminarCod(string codigo)
        {

            objetoDAO.EliminarCodigo(codigo);
        }

        public int ValidarCodEliminado(string codigo)
        {
            int datoretorno = objetoDAO.ValidarCodigoEliminado(codigo);

            return datoretorno;
        }

        public void ActualizarCod(string codigo, string nombre, string descripcion)
        {
            objetoDAO.ActualizarCodigo(codigo, nombre, descripcion);
        }
 
    }
}
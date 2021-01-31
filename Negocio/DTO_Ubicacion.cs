using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class DTO_Ubicacion
    {
        
        private DAO_Ubicacion objetoDAO = new DAO_Ubicacion();
        public DataTable MostrarCodCentroCost(string codigo)
        {
            DataTable tabla = new DataTable();
            tabla = objetoDAO.MostrarUbicacion(codigo);

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
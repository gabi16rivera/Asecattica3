using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class DTO_Asientos
    {
        
        private DAO_Asientos objetoDAO = new DAO_Asientos();
        public DataTable MostrarCodAsien(string codigoAsiento)
        {
            DataTable tabla = new DataTable();
            tabla = objetoDAO.MostrarAsientos(codigoAsiento);

            return tabla;
        }

        public int ValidarCod(string codigoAsiento)
        {
            int datoretornoID = objetoDAO.ValidarCodigo(codigoAsiento);

            return datoretornoID;
        }

        public void AgregarCod(string codigoAsiento, string tipo, string descripcion)
        {

            objetoDAO.AgregarCodigo(codigoAsiento, tipo, descripcion);
        }

        public void EliminarCod(string codigoAsiento)
        {

            objetoDAO.EliminarCodigo(codigoAsiento);
        }

        public int ValidarCodEliminado(string codigoAsiento)
        {
            int datoretorno = objetoDAO.ValidarCodigoEliminado(codigoAsiento);

            return datoretorno;
        }

        public void ActualizarCod(string codigoAsiento, string tipo, string descripcion)
        {
            objetoDAO.ActualizarCodigo(codigoAsiento, tipo, descripcion);
        }
 
    }
}
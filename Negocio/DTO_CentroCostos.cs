using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class DTO_CentroCostos
    {
        
        private DAO_CentroCostos objetoDAO = new DAO_CentroCostos();
        public DataTable MostrarCodCentroCost(string codigoCentroCosto)
        {
            DataTable tabla = new DataTable();
            tabla = objetoDAO.MostrarCentroCosto(codigoCentroCosto);

            return tabla;
        }

        public int ValidarCod(string codigoCentroCosto)
        {
            int datoretornoID = objetoDAO.ValidarCodigo(codigoCentroCosto);

            return datoretornoID;
        }

        public void AgregarCod(string codigoCentroCosto, string nombre, string descripcion)
        {

            objetoDAO.AgregarCodigo(codigoCentroCosto, nombre, descripcion);
        }

        public void EliminarCod(string codigoCentroCosto)
        {

            objetoDAO.EliminarCodigo(codigoCentroCosto);
        }

        public int ValidarCodEliminado(string codigoCentroCosto)
        {
            int datoretorno = objetoDAO.ValidarCodigoEliminado(codigoCentroCosto);

            return datoretorno;
        }

        public void ActualizarCod(string codigoCentroCosto, string nombre, string descripcion)
        {
            objetoDAO.ActualizarCodigo(codigoCentroCosto, nombre, descripcion);
        }
 
    }
}
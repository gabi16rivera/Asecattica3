using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class DTO_LineasCreditos
    {
        
        private DAO_LineasCreditos objetoDAO = new DAO_LineasCreditos();
        public DataTable MostrarLinCred(string CodigoLineaCredito)
        {
            DataTable tabla = new DataTable();
            tabla = objetoDAO.MostrarLineasCreditos(CodigoLineaCredito);

            return tabla;
        }

        public int ValidarCod(string codigoLineaCredito)
        {
            int datoretornoID = objetoDAO.ValidarCodigo(codigoLineaCredito);

            return datoretornoID;
        }

        public void AgregarCod(string codigoLineaCredito, string nombreLineaCredito,
            string tipoAsiento, string descripcion, string fechaUltAct, string porcentajeInteres, 
            string topeMaximo)
        {

            objetoDAO.AgregarCodigo(codigoLineaCredito, nombreLineaCredito, tipoAsiento, descripcion,
                fechaUltAct, porcentajeInteres, topeMaximo);
        }

        public void EliminarCod(string codigoLineaCredito)
        {

            objetoDAO.EliminarCodigo(codigoLineaCredito);
        }

        public int ValidarCodEliminado(string codigoLineaCredito)
        {
            int datoretorno = objetoDAO.ValidarCodigoEliminado(codigoLineaCredito);

            return datoretorno;
        }

        public void ActualizarCod(string codigoLineaCredito, string nombreLineaCredito,
            string tipoAsiento, string descripcion, string fechaUltAct, string porcentajeInteres,
            string topeMaximo)
        {
            objetoDAO.ActualizarCodigo(codigoLineaCredito, nombreLineaCredito, tipoAsiento, descripcion,
                fechaUltAct, porcentajeInteres, topeMaximo);
        }
 
    }
}
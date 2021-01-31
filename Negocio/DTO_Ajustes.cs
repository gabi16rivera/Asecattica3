using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class DTO_Ajustes
    {
        
        private DAO_Ajustes objetoDAO = new DAO_Ajustes();
        public DataTable MostrarCodAjus(string codigoAjuste)
        {
            DataTable tabla = new DataTable();
            tabla = objetoDAO.MostrarAjustes(codigoAjuste);

            return tabla;
        }

        public int ValidarCod(string codigoAjuste)
        {
            int datoretornoID = objetoDAO.ValidarCodigo(codigoAjuste);

            return datoretornoID;
        }

        public void AgregarCod(string codigoAjuste, string nombreAjuste, string tipoAjuste,
            string rangoInicial, string rangoFinal, string peso, string descripcion)
        {

            objetoDAO.AgregarCodigo(codigoAjuste, nombreAjuste, tipoAjuste, rangoInicial, rangoFinal, peso, descripcion);
        }

        public void EliminarCod(string codigoAjuste)
        {

            objetoDAO.EliminarCodigo(codigoAjuste);
        }

        public int ValidarCodEliminado(string codigoAjuste)
        {
            int datoretorno = objetoDAO.ValidarCodigoEliminado(codigoAjuste);

            return datoretorno;
        }

        public void ActualizarCod(string codigoAjuste, string nombreLineaCredito,
            string tipoAsiento, string descripcion, string fechaUltAct, string porcentajeInteres,
            string topeMaximo)
        {
            objetoDAO.ActualizarCodigo(codigoAjuste, nombreLineaCredito, tipoAsiento, descripcion,
                fechaUltAct, porcentajeInteres, topeMaximo);
        }
 
    }
}
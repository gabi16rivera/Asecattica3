﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DAO_LineasCreditos 
    { 

        private DAO_Conexion conexion = new DAO_Conexion();

        public DataTable MostrarLineasCreditos(string codigoLineaCredito)
        {
            DataTable tabla = new DataTable();
            SqlDataReader leer;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTiposLineasCreditos";
            comando.Parameters.AddWithValue("@choice", "SELECT_CODIGO");
            comando.Parameters.AddWithValue("@CodigoLineaCredito", codigoLineaCredito);
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public int ValidarCodigo(string codigoLineaCredito)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTiposLineasCreditos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "VALIDAR_CODIGO");
            comando.Parameters.AddWithValue("@CodigoLineaCredito", codigoLineaCredito);

            return (int)comando.ExecuteScalar();

        }


        public void AgregarCodigo(string codigoLineaCredito, string nombreLineaCredito, string tipoAsiento,
            string descripcion, string fechaUltAct, string porcentajeInteres, string topeMaximo)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTiposLineasCreditos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "INSERT");
            comando.Parameters.AddWithValue("@CodigoLineaCredito", codigoLineaCredito);
            comando.Parameters.AddWithValue("@NombreLineaCredito", nombreLineaCredito);
            comando.Parameters.AddWithValue("@TipoAsiento", tipoAsiento);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@FechaUltAct", fechaUltAct);
            comando.Parameters.AddWithValue("@PorcentajeInteres", porcentajeInteres);
            comando.Parameters.AddWithValue("@TopeMaximo", topeMaximo);
            comando.ExecuteNonQuery(); //excepción de duplicado de id
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void ActualizarCodigo(string codigoLineaCredito, string nombreLineaCredito, string tipoAsiento,
            string descripcion, string fechaUltAct, string porcentajeInteres, string topeMaximo)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTiposLineasCreditos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "UPDATE");
            comando.Parameters.AddWithValue("@CodigoLineaCredito", codigoLineaCredito);
            comando.Parameters.AddWithValue("@NombreLineaCredito", nombreLineaCredito);
            comando.Parameters.AddWithValue("@TipoAsiento", tipoAsiento);
            comando.Parameters.AddWithValue("@TopeMaximo", topeMaximo);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@FechaUltAct", fechaUltAct);
            comando.Parameters.AddWithValue("@PorcentajeInteres", porcentajeInteres);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }//fin actualizar usuarios

        public void EliminarCodigo(string codigoLineaCredito)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTiposLineasCreditos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "DELETE");
            comando.Parameters.AddWithValue("@CodigoLineaCredito", codigoLineaCredito);
            comando.ExecuteNonQuery(); //excepción de duplicado de id
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public int ValidarCodigoEliminado(string codigoLineaCredito)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBTiposLineasCreditos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@choice", "VALIDA_COD_ELIMINADO");
            comando.Parameters.AddWithValue("@CodigoLineaCredito", codigoLineaCredito);
            if (comando.ExecuteScalar() == null)
            {
                return 0;

            }
            else
            {
                return (int)comando.ExecuteScalar();
            }

        }
 
    }
}
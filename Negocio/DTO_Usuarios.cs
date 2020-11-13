using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class DTO_Usuarios
    {
        
        private DAO_Usuarios objetoDAO = new DAO_Usuarios();

        public int ValidarUsuEliminado(string ID_Asecattica)
        {
            int datoretornoID = objetoDAO.ValidarUsuarioEliminado(ID_Asecattica);

            return datoretornoID;
        }

        public int ValidarIDAse(string ID_Asecattica)
        {
            int datoretornoID = objetoDAO.ValidarIDAsecattica(ID_Asecattica);

            return datoretornoID;
        }

        public DataTable MostrarUsu(string ID_Asecattica)
        {
            DataTable tabla = new DataTable();
            tabla = objetoDAO.MostrarUsuario(ID_Asecattica);
            
            return tabla;
        }

        public DataTable MostrarRol()
        {
            DataTable tablaRoles = new DataTable();

            tablaRoles = objetoDAO.MostrarRoles();
            return tablaRoles;
        }

        public DataTable MostrarEstado()
        {
            DataTable tablaEstados = new DataTable();

            tablaEstados = objetoDAO.MostrarEstados();
            return tablaEstados;
        }

        public DataTable MostrarUbica()
        {
            DataTable tablaUbicacion = new DataTable();

            tablaUbicacion = objetoDAO.MostrarUbicacion();
            return tablaUbicacion;
        }

        public DataTable MostrarCentroCos()
        {
            DataTable tablaCentroCosto = new DataTable();

            tablaCentroCosto = objetoDAO.MostrarCentroCosto();
            return tablaCentroCosto;
        }

        public void ActualizarUsu(string ID_Asecattica, string cedula, string ubicacion,
            string nombre, string apellido1, string apellido2, string rol, string estado, string correo,
            string telefono, string fechaNacim, string edad, string direccion, string sexo,
            string fechaIngreso, string fechaSalida, string clave)
        {
            objetoDAO.ActualizarUsuarios(ID_Asecattica, cedula, ubicacion, nombre, apellido1, apellido2,
                rol, estado, correo, telefono, fechaNacim, edad, direccion, sexo, fechaIngreso, fechaSalida, clave);
        }

        public void AgregarUsu(string ID_Asecattica, string cedula, string ubicacion,
            string nombre, string apellido1, string apellido2, string rol, string estado, string correo, string clave,
            string telefono, string fechaNacim, string edad, string direccion, string sexo,
            string fechaIngreso, string fechaSalida)
        {

            objetoDAO.AgregarUsuarios(ID_Asecattica, cedula, ubicacion, nombre, apellido1, apellido2,
                rol, estado, correo, clave, telefono, fechaNacim, edad, direccion, sexo, fechaIngreso, fechaSalida);
        }

        public void EliminarUsu(string ID_Asecattica)
        {

            objetoDAO.EliminarUsuarios(ID_Asecattica);
        }

    }
}
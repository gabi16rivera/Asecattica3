using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DAO_Usuarios
    {

        private DAO_Conexion conexion = new DAO_Conexion();

        public int ValidarUsuarioEliminado(string ID_Asecattica)
        {
            SqlCommand comandoActUsu = new SqlCommand();
            comandoActUsu.Connection = conexion.AbrirConexion();
            comandoActUsu.CommandText = "sp_crud_TBUsuarios";
            comandoActUsu.CommandType = CommandType.StoredProcedure;
            comandoActUsu.Parameters.AddWithValue("@choice", "VALIDA_USU_ELIMINADO");
            comandoActUsu.Parameters.AddWithValue("@ID_Asecattica", ID_Asecattica);
            if (comandoActUsu.ExecuteScalar()==null)
            {
                return 0;

            }
            else
            {
                return (int)comandoActUsu.ExecuteScalar();
            }

        }

        public int ValidarIDAsecattica(string ID_Asecattica)
        {
            SqlCommand comandoActUsu = new SqlCommand();
            comandoActUsu.Connection = conexion.AbrirConexion();
            comandoActUsu.CommandText = "sp_crud_TBUsuarios";
            comandoActUsu.CommandType = CommandType.StoredProcedure;
            comandoActUsu.Parameters.AddWithValue("@choice", "VALIDAR_IDASECATTICA");
            comandoActUsu.Parameters.AddWithValue("@ID_Asecattica", ID_Asecattica);

            return (int)comandoActUsu.ExecuteScalar();

        }

        public int ValidarCedula(string cedula)
        {
            SqlCommand comandoActUsu = new SqlCommand();
            comandoActUsu.Connection = conexion.AbrirConexion();
            comandoActUsu.CommandText = "sp_crud_TBUsuarios";
            comandoActUsu.CommandType = CommandType.StoredProcedure;
            comandoActUsu.Parameters.AddWithValue("@choice", "VALIDAR_CEDULA");
            comandoActUsu.Parameters.AddWithValue("@Cedula", cedula);

            return (int)comandoActUsu.ExecuteScalar();

        }

        public DataTable MostrarUsuario(string ID_Asecattica)
        {
            DataTable tabla = new DataTable();
            SqlDataReader leer;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_crud_TBUsuarios";
            comando.Parameters.AddWithValue("@choice", "SELECT_IDASECATTICA");
            comando.Parameters.AddWithValue("@ID_Asecattica", ID_Asecattica);
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public SqlDataReader MostrarListItem()
        {
            DataTable tablaRol = new DataTable();
            SqlDataReader leerRol;
            SqlCommand comandoRol = new SqlCommand();
            comandoRol.Connection = conexion.AbrirConexion();
            comandoRol.CommandText = "sp_crud_TBRoles";
            comandoRol.Parameters.AddWithValue("@choice", "Select");
            comandoRol.CommandType = CommandType.StoredProcedure;
            leerRol = comandoRol.ExecuteReader();



            return leerRol;

        }

        public DataTable MostrarRoles()
        {
            DataTable tablaRol = new DataTable();
            SqlDataReader leerRol;
            SqlCommand comandoRol = new SqlCommand();
            comandoRol.Connection = conexion.AbrirConexion();
            comandoRol.CommandText = "sp_crud_TBRoles";
            comandoRol.Parameters.AddWithValue("@choice", "Select");
            comandoRol.CommandType = CommandType.StoredProcedure;
            leerRol = comandoRol.ExecuteReader();
            tablaRol.Load(leerRol);
            conexion.CerrarConexion();
            return tablaRol;

        }

        public DataTable MostrarEstados()
        {
            DataTable tablaEstados = new DataTable();
            SqlDataReader leerEstado;
            SqlCommand comandoEstado = new SqlCommand();
            comandoEstado.Connection = conexion.AbrirConexion();
            comandoEstado.CommandText = "sp_crud_TBEstados";
            comandoEstado.Parameters.AddWithValue("@choice", "Select");
            comandoEstado.CommandType = CommandType.StoredProcedure;
            leerEstado = comandoEstado.ExecuteReader();
            tablaEstados.Load(leerEstado);
            conexion.CerrarConexion();
            return tablaEstados;

        }

        public DataTable MostrarUbicacion()
        {
            DataTable tablaUbicacion = new DataTable();
            SqlDataReader leerUbicacion;
            SqlCommand comandoUbica = new SqlCommand();
            comandoUbica.Connection = conexion.AbrirConexion();
            comandoUbica.CommandText = "sp_crud_TBUbicacion";
            comandoUbica.Parameters.AddWithValue("@choice", "Select");
            comandoUbica.CommandType = CommandType.StoredProcedure;
            leerUbicacion = comandoUbica.ExecuteReader();
            tablaUbicacion.Load(leerUbicacion);
            conexion.CerrarConexion();
            return tablaUbicacion;

        }

        public DataTable MostrarCentroCosto()
        {
            DataTable tablaCentroCosto = new DataTable();
            SqlDataReader leerCentroCosto;
            SqlCommand comandoCentroCosto = new SqlCommand();
            comandoCentroCosto.Connection = conexion.AbrirConexion();
            comandoCentroCosto.CommandText = "sp_crud_TBCentroCosto";
            comandoCentroCosto.Parameters.AddWithValue("@choice", "Select");
            comandoCentroCosto.CommandType = CommandType.StoredProcedure;
            leerCentroCosto = comandoCentroCosto.ExecuteReader();
            tablaCentroCosto.Load(leerCentroCosto);
            conexion.CerrarConexion();
            return tablaCentroCosto;

        }

        //Actualiza los usuarios en la BD
        public void ActualizarUsuarios(string ID_Asecattica, string cedula, string ubicacion,
            string nombre, string apellido1, string apellido2, string rol, string estado, string correo,
            string telefono, string fechaNacim, string edad, string direccion, string sexo, 
            string fechaIngreso, string fechaSalida, string clave) 
        {
            SqlCommand comandoActUsu = new SqlCommand();
            comandoActUsu.Connection = conexion.AbrirConexion();
            comandoActUsu.CommandText = "sp_crud_TBUsuarios";
            comandoActUsu.CommandType = CommandType.StoredProcedure;
            comandoActUsu.Parameters.AddWithValue("@choice", "UPDATE");
            comandoActUsu.Parameters.AddWithValue("@ID_Asecattica", ID_Asecattica);
            comandoActUsu.Parameters.AddWithValue("@Cedula", cedula);
            comandoActUsu.Parameters.AddWithValue("@Ubicacion", ubicacion);
            comandoActUsu.Parameters.AddWithValue("@Nombre", nombre);
            comandoActUsu.Parameters.AddWithValue("@Apellido1", apellido1);
            comandoActUsu.Parameters.AddWithValue("@Apellido2", apellido2);
            comandoActUsu.Parameters.AddWithValue("@Rol", rol);
            comandoActUsu.Parameters.AddWithValue("@Estado", estado);
            comandoActUsu.Parameters.AddWithValue("@Correo", correo);
            comandoActUsu.Parameters.AddWithValue("@Telefono", telefono);
            comandoActUsu.Parameters.AddWithValue("@FechaNacim", fechaNacim);
            comandoActUsu.Parameters.AddWithValue("@Edad", edad);
            comandoActUsu.Parameters.AddWithValue("@Direccion", direccion);
            comandoActUsu.Parameters.AddWithValue("@Sexo", sexo);
            comandoActUsu.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
            comandoActUsu.Parameters.AddWithValue("@fechaSalida", fechaSalida);
            comandoActUsu.Parameters.AddWithValue("@Clave", clave);
            comandoActUsu.ExecuteNonQuery();
            comandoActUsu.Parameters.Clear();
            conexion.CerrarConexion();

        }//fin actualizar usuarios

        public void AgregarUsuarios(string ID_Asecattica, string cedula, string ubicacion,
            string nombre, string apellido1, string apellido2, string rol, string estado, string correo, string clave,
            string telefono, string fechaNacim, string edad, string direccion, string sexo,
            string fechaIngreso, string fechaSalida)
        {
            SqlCommand comandoAgregarUsu = new SqlCommand();
            comandoAgregarUsu.Connection = conexion.AbrirConexion();
            comandoAgregarUsu.CommandText = "sp_crud_TBUsuarios";
            comandoAgregarUsu.CommandType = CommandType.StoredProcedure;
            comandoAgregarUsu.Parameters.AddWithValue("@choice", "INSERT");
            comandoAgregarUsu.Parameters.AddWithValue("@ID_Asecattica", ID_Asecattica);
            comandoAgregarUsu.Parameters.AddWithValue("@Cedula", cedula);
            comandoAgregarUsu.Parameters.AddWithValue("@Ubicacion", ubicacion);
            comandoAgregarUsu.Parameters.AddWithValue("@Nombre", nombre);
            comandoAgregarUsu.Parameters.AddWithValue("@Apellido1", apellido1);
            comandoAgregarUsu.Parameters.AddWithValue("@Apellido2", apellido2);
            comandoAgregarUsu.Parameters.AddWithValue("@Rol", rol);
            comandoAgregarUsu.Parameters.AddWithValue("@Estado", estado);
            comandoAgregarUsu.Parameters.AddWithValue("@Correo", correo);
            comandoAgregarUsu.Parameters.AddWithValue("@Clave", clave);
            comandoAgregarUsu.Parameters.AddWithValue("@Telefono", telefono);
            comandoAgregarUsu.Parameters.AddWithValue("@FechaNacim", fechaNacim);
            comandoAgregarUsu.Parameters.AddWithValue("@Edad", edad);
            comandoAgregarUsu.Parameters.AddWithValue("@Direccion", direccion);
            comandoAgregarUsu.Parameters.AddWithValue("@Sexo", sexo);
            comandoAgregarUsu.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
            comandoAgregarUsu.Parameters.AddWithValue("@fechaSalida", fechaSalida);
            comandoAgregarUsu.ExecuteNonQuery(); //excepción de duplicado de id
            comandoAgregarUsu.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void EliminarUsuarios(string ID_Asecattica)
        {
            SqlCommand comandoAgregarUsu = new SqlCommand();
            comandoAgregarUsu.Connection = conexion.AbrirConexion();
            comandoAgregarUsu.CommandText = "sp_crud_TBUsuarios";
            comandoAgregarUsu.CommandType = CommandType.StoredProcedure;
            comandoAgregarUsu.Parameters.AddWithValue("@choice", "DELETE");
            comandoAgregarUsu.Parameters.AddWithValue("@ID_Asecattica", ID_Asecattica);
            comandoAgregarUsu.ExecuteNonQuery(); //excepción de duplicado de id
            comandoAgregarUsu.Parameters.Clear();
            conexion.CerrarConexion();

        }

    }
}
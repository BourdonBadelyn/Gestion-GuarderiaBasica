using System;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace capaDatos
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlCommand cmd;
        private SqlDataReader dr;

        // Insertar Niño
        public void InsertarNino(string nombre, string apellido, DateTime fechaNacimiento, string nombreTutor, string telefonoTutor, string direccion)
        {
            cmd = new SqlCommand("sp_InsertarNino", conexion.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Apellido", apellido);
            cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
            cmd.Parameters.AddWithValue("@NombreTutor", nombreTutor);
            cmd.Parameters.AddWithValue("@TelefonoTutor", telefonoTutor);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        // Obtener Niños
        public DataTable ObtenerNinos()
        {
            DataTable tabla = new DataTable();
            cmd = new SqlCommand("sp_ObtenerNinos", conexion.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

        // Actualizar Niño
        

        // Eliminar (desactivar) Niño
        public void EliminarNino(int idNino)
        {
            cmd = new SqlCommand("sp_EliminarNino", conexion.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdNino", idNino);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}

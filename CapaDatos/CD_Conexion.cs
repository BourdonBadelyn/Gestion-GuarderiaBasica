using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private readonly string connectionString = "Data Source=DESKTOP-6JQD8KN\\SQLEXPRESS;Initial Catalog=Guarderia;Integrated Security=True";

        private SqlConnection conexion;
        public CD_Conexion()
        {
            conexion = new SqlConnection(connectionString);
        }
        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (SqlException ex)
            {
                // Puedes registrar el error, lanzar una excepción personalizada, etc.
                throw new Exception("Error al abrir la conexión con la base de datos.", ex);
            }
            return conexion;
        }


        public SqlConnection CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al cerrar la conexión con la base de datos.", ex);
            }
            return conexion;
        }


        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }


    }
}

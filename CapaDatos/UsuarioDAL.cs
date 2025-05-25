using System.Data.SqlClient;
using System;
using System.Data;

namespace CapaDatos
{
    public class UsuarioDAL
    {
        private readonly string conexion = "Data Source=DESKTOP-6JQD8KN\\SQLEXPRESS;Initial Catalog = Guarderia; Integrated Security = True";

        public bool RegistrarUsuario(string usuario, string hash, string nombre, string correo, int rolId, bool activo)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Usuarios (Usuario, Contrasena, NombreCompleto, Correo, RolId, Activo)
                    VALUES (@Usuario, @Contrasena, @Nombre, @Correo, @RolId, @Activo)", conn);

                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contrasena", hash);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@RolId", rolId);
                cmd.Parameters.AddWithValue("@Activo", activo);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ObtenerRoles()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombre FROM Roles", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }

        // Validar usuario con rol incluido
        public DataRow ObtenerUsuarioPorNombre(string usuario)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                string consulta = @"
                    SELECT U.*, R.Nombre AS NombreRol
                    FROM Usuarios U
                    JOIN Roles R ON U.RolId = R.Id
                    WHERE U.Usuario = @Usuario AND U.Activo = 1";

                SqlCommand cmd = new SqlCommand(consulta, conn);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];
                else
                    return null;
            }
        }
    }
}

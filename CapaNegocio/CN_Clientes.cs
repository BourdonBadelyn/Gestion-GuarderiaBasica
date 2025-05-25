using System;
using System.Data;
using capaDatos;

namespace capaNegocio
{
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();

        // Insertar
        public void InsertarNino(string nombre, string apellido, DateTime fechaNacimiento, string nombreTutor, string telefonoTutor, string direccion)
        {
            // Validaciones básicas (opcional)
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(apellido)) throw new ArgumentException("El apellido es obligatorio.");

            objetoCD.InsertarNino(nombre, apellido, fechaNacimiento, nombreTutor, telefonoTutor, direccion);
        }

        // Mostrar todos los niños activos
        public DataTable MostrarNinos()
        {
            return objetoCD.ObtenerNinos();
        }

        // Editar
        public void EditarNino(int idNino, string nombre, string apellido, DateTime fechaNacimiento, string nombreTutor, string telefonoTutor, string direccion, bool activo)
        {
           
        }

        // Eliminar (desactivar)
        public void EliminarNino(int idNino)
        {
            objetoCD.EliminarNino(idNino);
        }
    }
}

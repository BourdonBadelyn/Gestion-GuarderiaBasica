using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class CN_Login
    {

        private UsuarioBLL usuarioBLL = new UsuarioBLL();

        public DataRow ValidarLogin(string usuario, string contrasena)
        {
            var usuarioData = usuarioBLL.ObtenerUsuario(usuario);
            if (usuarioData == null) return null;

            string hashIngresado = usuarioBLL
                .GetType()
                .GetMethod("HashearContrasena", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .Invoke(usuarioBLL, new object[] { contrasena }) as string;

            string hashAlmacenado = usuarioData["Contrasena"].ToString();

            if (hashIngresado == hashAlmacenado)
                return usuarioData;

            return null;
        }
    }
}

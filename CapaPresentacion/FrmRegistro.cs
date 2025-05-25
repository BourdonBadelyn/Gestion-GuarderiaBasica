using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using static CapaNegocio.UsuarioBLL;

namespace CapaPresentacion
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            CargarRoles();
            txtContrasena.PasswordChar = '*';

        }

        public string HashearContrasena(string contrasena)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contrasena));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                cmbRol.SelectedValue == null)
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }


            var usuarioBLL = new UsuarioBLL();

            bool resultado = usuarioBLL.Registrar(
                txtUsuario.Text.Trim(),
                txtContrasena.Text,
                txtNombre.Text.Trim(),
                txtCorreo.Text.Trim(),
                (int)cmbRol.SelectedValue,
                chkActivo.Checked
            );

            if (resultado)
            {
                MessageBox.Show("Usuario registrado correctamente.");

                LimpiarCampos();

                // Abre el formulario Login y cierra el actual
                FrmLogin login = new FrmLogin(); // Asegúrate de tener este formulario creado
                login.Show();
                this.Hide(); // O this

            }

            else
            {
                MessageBox.Show("Error al registrar.");
            }
        }

        private void RegistrarUsuarioForm_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void CargarRoles()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            var tabla = usuarioBLL.ObtenerRoles();

            cmbRol.DataSource = tabla;
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "Id";
        }

        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            cmbRol.SelectedIndex = 0;
            chkActivo.Checked = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}

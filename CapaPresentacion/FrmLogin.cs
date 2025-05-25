using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtContrasenaLogin.PasswordChar = '*';
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioLogin.Text) || string.IsNullOrWhiteSpace(txtContrasenaLogin.Text))
            {
                MessageBox.Show("Por favor, completa ambos campos.");
                return;
            }

            var usuarioBLL = new UsuarioBLL();
            var usuario = usuarioBLL.ObtenerUsuario(txtUsuarioLogin.Text.Trim());

            if (usuario == null)
            {
                MessageBox.Show("Usuario no encontrado o inactivo.");
                return;
            }

            string hashIngresado = usuarioBLL.GetType()
                .GetMethod("HashearContrasena", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .Invoke(usuarioBLL, new object[] { txtContrasenaLogin.Text }) as string;

            string hashAlmacenado = usuario["Contrasena"].ToString();

            if (hashIngresado == hashAlmacenado)
            {
                string rol = usuario["NombreRol"].ToString(); 
                MessageBox.Show($"¡Bienvenido! Rol: {rol}");



                Session.Usuario = usuario["Usuario"].ToString(); 
                Session.Rol = usuario["NombreRol"].ToString();

                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

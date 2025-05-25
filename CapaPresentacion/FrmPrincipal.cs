using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Si el rol es EMPLEADO, ocultar el botón Usuarios
            if (Session.Rol == "Empleado")
            {
                btnUsuario.Visible = false;
            }

            // También puedes mostrar el nombre del usuario en un label si quieres
            lblBienvenido.Text = $"Bienvenido, {Session.Usuario}";


            if (Session.Rol == "Solo Lectura")
            {
                btnVentas.Enabled = false;
                btnServicios.Enabled = false;
                btnUsuario.Enabled = false;
                btnReportes.Enabled = true; // Puede ver reportes
                
            }


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
        
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
            
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.Show();
          
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            FrmServicios frmServicios = new FrmServicios();
            frmServicios.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes();
            frmReportes.Show();
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
           
        }
    }
}

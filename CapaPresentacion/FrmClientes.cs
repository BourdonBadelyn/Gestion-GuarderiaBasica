using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;


namespace CapaPresentacion
{
    public partial class FrmClientes : Form
    {

        CN_Clientes objetoCN = new CN_Clientes();
        private int idNino = 0;
        private bool editar = false;
        private bool esNuevo = true;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            LimpiarCampos();

            if (Session.Rol == "Solo Lectura")
            {
                btnReporteCliente.Enabled = false;
                btnEditarCliente.Enabled = false;
                btnEliminar.Enabled = false;
                btnBuscarCliente.Enabled = true; // Buscar sí puede
                dgvClientes.ReadOnly = true;
                btnEliminar.Enabled = false;
                btnGuardarCliente.Enabled = false;
                btnCancelarCliente.Enabled = false;

            }

        }

        private void LimpiarCampos()
        {
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtNombreTutorCliente.Clear();
            txtDateCliente.Value = DateTime.Today;
            txtTelefonoTutor.Clear();
            txtDireccionCliente.Clear();
            txtBuscarCliente.Clear();
            esNuevo = true;
            idNino = 0;
        }

        private void MostrarClientes()
        {
            dgvClientes.DataSource = objetoCN.MostrarNinos();
            lblTotalCliente.Text = "Total: " + dgvClientes.Rows.Count.ToString();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (esNuevo)
                {
                    objetoCN.InsertarNino(
                        txtNombreCliente.Text,
                        txtApellidoCliente.Text,
                        txtDateCliente.Value,
                        txtNombreTutorCliente.Text,
                        txtTelefonoTutor.Text,
                        txtDireccionCliente.Text
                    );
                    MessageBox.Show("Cliente registrado correctamente.");
                }
                else
                {
                    objetoCN.EditarNino(
                        idNino,
                        txtNombreCliente.Text,
                        txtApellidoCliente.Text,
                        txtDateCliente.Value,
                        txtNombreTutorCliente.Text,
                        txtTelefonoTutor.Text,
                        txtDireccionCliente.Text,
                        true // siempre lo dejamos activo al editar
                    );
                    MessageBox.Show("Cliente actualizado correctamente.");
                }

                MostrarClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            LimpiarCampos();
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                idNino = Convert.ToInt32(fila.Cells["IdNino"].Value);
                txtNombreCliente.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellidoCliente.Text = fila.Cells["Apellido"].Value.ToString();
                txtNombreTutorCliente.Text = fila.Cells["NombreTutor"].Value.ToString();
                txtDateCliente.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
                txtTelefonoTutor.Text = fila.Cells["TelefonoTutor"].Value.ToString();
                txtDireccionCliente.Text = fila.Cells["Direccion"].Value.ToString();
                esNuevo = false;
            }
        }

       

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            DataView dv = objetoCN.MostrarNinos().DefaultView;
            dv.RowFilter = $"Nombre LIKE '%{txtBuscarCliente.Text}%' OR Apellido LIKE '%{txtBuscarCliente.Text}%'";
            dgvClientes.DataSource = dv;
            lblTotalCliente.Text = "Total: " + dv.Count.ToString();
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void groupBoxCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idNino != 0)
            {
                DialogResult resultado = MessageBox.Show("¿Deseas marcar este cliente como inactivo?", "Confirmar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    objetoCN.EditarNino(
                        idNino,
                        txtNombreCliente.Text,
                        txtApellidoCliente.Text,
                        txtDateCliente.Value,
                        txtNombreTutorCliente.Text,
                        txtTelefonoTutor.Text,
                        txtDireccionCliente.Text,
                        false // ← Marcamos como inactivo
                    );
                    MostrarClientes();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente para eliminar.");
            }

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (idNino != 0)
            {
                objetoCN.EditarNino(
                    idNino,
                    txtNombreCliente.Text,
                    txtApellidoCliente.Text,
                    txtDateCliente.Value,
                    txtNombreTutorCliente.Text,
                    txtTelefonoTutor.Text,
                    txtDireccionCliente.Text,
                    true // ← Lo dejamos como activo
                );
                MessageBox.Show("Cliente editado correctamente.");
                MostrarClientes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Selecciona un cliente para editar.");
            }
        }
    }
}

namespace CapaPresentacion
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalCliente = new System.Windows.Forms.Label();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefonoTutor = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDateCliente = new System.Windows.Forms.DateTimePicker();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNombreTutorCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNombreTutor = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.panelClientessuperior = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panellateralClientes = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureCliente = new System.Windows.Forms.PictureBox();
            this.btnSalirCliente = new System.Windows.Forms.Button();
            this.btnReporteCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnCancelarCliente = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.groupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panelClientessuperior.SuspendLayout();
            this.panellateralClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalCliente
            // 
            this.lblTotalCliente.AutoSize = true;
            this.lblTotalCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCliente.Location = new System.Drawing.Point(896, 395);
            this.lblTotalCliente.Name = "lblTotalCliente";
            this.lblTotalCliente.Size = new System.Drawing.Size(62, 25);
            this.lblTotalCliente.TabIndex = 51;
            this.lblTotalCliente.Text = "Total:";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.txtDireccionCliente);
            this.groupBoxCliente.Controls.Add(this.txtApellidoCliente);
            this.groupBoxCliente.Controls.Add(this.lblDireccion);
            this.groupBoxCliente.Controls.Add(this.txtTelefonoTutor);
            this.groupBoxCliente.Controls.Add(this.lblTelefono);
            this.groupBoxCliente.Controls.Add(this.txtDateCliente);
            this.groupBoxCliente.Controls.Add(this.txtNombreCliente);
            this.groupBoxCliente.Controls.Add(this.txtNombreTutorCliente);
            this.groupBoxCliente.Controls.Add(this.lblNombre);
            this.groupBoxCliente.Controls.Add(this.label7);
            this.groupBoxCliente.Controls.Add(this.lblFechaNacimiento);
            this.groupBoxCliente.Controls.Add(this.lblNombreTutor);
            this.groupBoxCliente.Controls.Add(this.lblApellido);
            this.groupBoxCliente.Location = new System.Drawing.Point(68, 124);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(949, 214);
            this.groupBoxCliente.TabIndex = 50;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Datos";
            this.groupBoxCliente.Enter += new System.EventHandler(this.groupBoxCliente_Enter);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(568, 122);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(216, 26);
            this.txtDireccionCliente.TabIndex = 60;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(119, 78);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(239, 26);
            this.txtApellidoCliente.TabIndex = 59;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(405, 125);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 23);
            this.lblDireccion.TabIndex = 55;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtTelefonoTutor
            // 
            this.txtTelefonoTutor.Location = new System.Drawing.Point(568, 78);
            this.txtTelefonoTutor.Name = "txtTelefonoTutor";
            this.txtTelefonoTutor.Size = new System.Drawing.Size(216, 26);
            this.txtTelefonoTutor.TabIndex = 53;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(405, 81);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(133, 23);
            this.lblTelefono.TabIndex = 52;
            this.lblTelefono.Text = "TelefonoTutor";
            // 
            // txtDateCliente
            // 
            this.txtDateCliente.Location = new System.Drawing.Point(568, 33);
            this.txtDateCliente.Name = "txtDateCliente";
            this.txtDateCliente.Size = new System.Drawing.Size(209, 26);
            this.txtDateCliente.TabIndex = 51;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(119, 36);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(239, 26);
            this.txtNombreCliente.TabIndex = 50;
            // 
            // txtNombreTutorCliente
            // 
            this.txtNombreTutorCliente.Location = new System.Drawing.Point(138, 119);
            this.txtNombreTutorCliente.Name = "txtNombreTutorCliente";
            this.txtNombreTutorCliente.Size = new System.Drawing.Size(216, 26);
            this.txtNombreTutorCliente.TabIndex = 47;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 43;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(405, 39);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(155, 23);
            this.lblFechaNacimiento.TabIndex = 41;
            this.lblFechaNacimiento.Text = "fechaNacimiento";
            // 
            // lblNombreTutor
            // 
            this.lblNombreTutor.AutoSize = true;
            this.lblNombreTutor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTutor.Location = new System.Drawing.Point(-5, 122);
            this.lblNombreTutor.Name = "lblNombreTutor";
            this.lblNombreTutor.Size = new System.Drawing.Size(137, 25);
            this.lblNombreTutor.TabIndex = 40;
            this.lblNombreTutor.Text = "NombreTutor";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(6, 78);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(87, 25);
            this.lblApellido.TabIndex = 39;
            this.lblApellido.Text = "Apellido";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(256, 394);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(422, 26);
            this.txtBuscarCliente.TabIndex = 48;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 433);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.Size = new System.Drawing.Size(903, 229);
            this.dgvClientes.TabIndex = 47;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellClick);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(164, 394);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(72, 25);
            this.lblBuscar.TabIndex = 44;
            this.lblBuscar.Text = "Buscar";
            // 
            // panelClientessuperior
            // 
            this.panelClientessuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(234)))));
            this.panelClientessuperior.Controls.Add(this.label2);
            this.panelClientessuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientessuperior.Location = new System.Drawing.Point(0, 0);
            this.panelClientessuperior.Name = "panelClientessuperior";
            this.panelClientessuperior.Size = new System.Drawing.Size(1105, 104);
            this.panelClientessuperior.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(799, 84);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gestion De Clientes";
            // 
            // panellateralClientes
            // 
            this.panellateralClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(72)))), ((int)(((byte)(122)))));
            this.panellateralClientes.Controls.Add(this.btnEliminar);
            this.panellateralClientes.Controls.Add(this.pictureCliente);
            this.panellateralClientes.Controls.Add(this.btnSalirCliente);
            this.panellateralClientes.Controls.Add(this.btnCancelarCliente);
            this.panellateralClientes.Controls.Add(this.btnReporteCliente);
            this.panellateralClientes.Controls.Add(this.btnGuardarCliente);
            this.panellateralClientes.Controls.Add(this.btnEditarCliente);
            this.panellateralClientes.Dock = System.Windows.Forms.DockStyle.Right;
            this.panellateralClientes.Location = new System.Drawing.Point(1105, 0);
            this.panellateralClientes.Name = "panellateralClientes";
            this.panellateralClientes.Size = new System.Drawing.Size(236, 708);
            this.panellateralClientes.TabIndex = 42;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(234)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.description_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(12, 394);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(212, 79);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureCliente
            // 
            this.pictureCliente.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureCliente.Image = global::CapaPresentacion.Properties.Resources._7890168;
            this.pictureCliente.Location = new System.Drawing.Point(33, 12);
            this.pictureCliente.Name = "pictureCliente";
            this.pictureCliente.Size = new System.Drawing.Size(200, 103);
            this.pictureCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCliente.TabIndex = 5;
            this.pictureCliente.TabStop = false;
            // 
            // btnSalirCliente
            // 
            this.btnSalirCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(234)))));
            this.btnSalirCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalirCliente.Image = global::CapaPresentacion.Properties.Resources.logout_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            this.btnSalirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirCliente.Location = new System.Drawing.Point(12, 585);
            this.btnSalirCliente.Name = "btnSalirCliente";
            this.btnSalirCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalirCliente.Size = new System.Drawing.Size(212, 77);
            this.btnSalirCliente.TabIndex = 4;
            this.btnSalirCliente.Text = "Salir";
            this.btnSalirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirCliente.UseVisualStyleBackColor = false;
            this.btnSalirCliente.Click += new System.EventHandler(this.btnSalirCliente_Click);
            // 
            // btnReporteCliente
            // 
            this.btnReporteCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(234)))));
            this.btnReporteCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReporteCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReporteCliente.Image = global::CapaPresentacion.Properties.Resources.description_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            this.btnReporteCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteCliente.Location = new System.Drawing.Point(12, 219);
            this.btnReporteCliente.Name = "btnReporteCliente";
            this.btnReporteCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReporteCliente.Size = new System.Drawing.Size(212, 79);
            this.btnReporteCliente.TabIndex = 3;
            this.btnReporteCliente.Text = "Reporte";
            this.btnReporteCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteCliente.UseVisualStyleBackColor = false;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(234)))));
            this.btnEditarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarCliente.Image = global::CapaPresentacion.Properties.Resources.refresh_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCliente.Location = new System.Drawing.Point(12, 133);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditarCliente.Size = new System.Drawing.Size(212, 79);
            this.btnEditarCliente.TabIndex = 1;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(234)))));
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCliente.Image = global::CapaPresentacion.Properties.Resources.add_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.Location = new System.Drawing.Point(724, 380);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuscarCliente.Size = new System.Drawing.Size(129, 47);
            this.btnBuscarCliente.TabIndex = 49;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(234)))));
            this.btnCancelarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarCliente.Image = global::CapaPresentacion.Properties.Resources.logout_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            this.btnCancelarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCliente.Location = new System.Drawing.Point(12, 479);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancelarCliente.Size = new System.Drawing.Size(212, 79);
            this.btnCancelarCliente.TabIndex = 45;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCliente.UseVisualStyleBackColor = false;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(234)))));
            this.btnGuardarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarCliente.Image = global::CapaPresentacion.Properties.Resources.add_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            this.btnGuardarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCliente.Location = new System.Drawing.Point(12, 304);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardarCliente.Size = new System.Drawing.Size(212, 84);
            this.btnGuardarCliente.TabIndex = 46;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCliente.UseVisualStyleBackColor = false;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 708);
            this.Controls.Add(this.lblTotalCliente);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.panelClientessuperior);
            this.Controls.Add(this.panellateralClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacturas1";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panelClientessuperior.ResumeLayout(false);
            this.panelClientessuperior.PerformLayout();
            this.panellateralClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalCliente;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefonoTutor;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.DateTimePicker txtDateCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNombreTutorCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNombreTutor;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnCancelarCliente;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.FlowLayoutPanel panelClientessuperior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panellateralClientes;
        private System.Windows.Forms.PictureBox pictureCliente;
        private System.Windows.Forms.Button btnSalirCliente;
        private System.Windows.Forms.Button btnReporteCliente;

        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Button btnEliminar;
    }
}
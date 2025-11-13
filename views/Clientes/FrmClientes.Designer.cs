namespace BarrancoNacano.Views.Clientes
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblCedula = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblDireccion = new Label();
            lblBarrio = new Label();
            lblCiudad = new Label();
            lblIngresosMensuales = new Label();
            lblCargo = new Label();
            lblDireccionDeLaEmpresa = new Label();
            lblEmpresa = new Label();
            lblR1Nombre = new Label();
            lblR1Direccion = new Label();
            lblR1Telefono = new Label();
            lblR2Nombre = new Label();
            lblR2Direccion = new Label();
            lblR2Telefono = new Label();
            lblDocumentos = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCedula = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            txtBarrio = new TextBox();
            txtCiudad = new TextBox();
            txtEmpresa = new TextBox();
            txtDireccionEmpresa = new TextBox();
            txtCargo = new TextBox();
            txtIngresosMensuales = new TextBox();
            txtR1Nombre = new TextBox();
            txtR2Nombre = new TextBox();
            txtR1Telefono = new TextBox();
            txtR1Direccion = new TextBox();
            txtR2Telefono = new TextBox();
            txtR2Direccion = new TextBox();
            txtDocumentos = new TextBox();
            btnGuardar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnSeleccionarDocumento = new Button();
            groupDatosPersonales = new GroupBox();
            groupDatosLaborales = new GroupBox();
            groupReferencia = new GroupBox();
            groupReferencia2 = new GroupBox();
            groupDocumentos = new GroupBox();
            groupBotones = new GroupBox();
            dgvClientes = new DataGridView();
            groupDatosPersonales.SuspendLayout();
            groupDatosLaborales.SuspendLayout();
            groupReferencia.SuspendLayout();
            groupReferencia2.SuspendLayout();
            groupDocumentos.SuspendLayout();
            groupBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            lblNombre.Click += label1_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(16, 67);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(16, 114);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(47, 15);
            lblCedula.TabIndex = 3;
            lblCedula.Text = "Cédula:";
            lblCedula.Click += lblCedula_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(15, 162);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(15, 207);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(46, 15);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(15, 255);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección:";
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Location = new Point(18, 326);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(38, 15);
            lblBarrio.TabIndex = 15;
            lblBarrio.Text = "Barrio";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(16, 292);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(45, 15);
            lblCiudad.TabIndex = 13;
            lblCiudad.Text = "Ciudad";
            // 
            // lblIngresosMensuales
            // 
            lblIngresosMensuales.AutoSize = true;
            lblIngresosMensuales.Location = new Point(15, 162);
            lblIngresosMensuales.Name = "lblIngresosMensuales";
            lblIngresosMensuales.Size = new Size(113, 15);
            lblIngresosMensuales.TabIndex = 4;
            lblIngresosMensuales.Text = "Ingresos Mensuales:";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(16, 114);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(42, 15);
            lblCargo.TabIndex = 3;
            lblCargo.Text = "Cargo:";
            // 
            // lblDireccionDeLaEmpresa
            // 
            lblDireccionDeLaEmpresa.AutoSize = true;
            lblDireccionDeLaEmpresa.Location = new Point(16, 67);
            lblDireccionDeLaEmpresa.Name = "lblDireccionDeLaEmpresa";
            lblDireccionDeLaEmpresa.Size = new Size(92, 30);
            lblDireccionDeLaEmpresa.TabIndex = 2;
            lblDireccionDeLaEmpresa.Text = "Direccion De La \r\nEmpresa:";
            lblDireccionDeLaEmpresa.Click += label8_Click;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(16, 19);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(55, 15);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "Empresa:";
            // 
            // lblR1Nombre
            // 
            lblR1Nombre.AutoSize = true;
            lblR1Nombre.Location = new Point(16, 19);
            lblR1Nombre.Name = "lblR1Nombre";
            lblR1Nombre.Size = new Size(110, 15);
            lblR1Nombre.TabIndex = 0;
            lblR1Nombre.Text = "Nombre Completo:";
            lblR1Nombre.Click += label1_Click_1;
            // 
            // lblR1Direccion
            // 
            lblR1Direccion.AutoSize = true;
            lblR1Direccion.Location = new Point(29, 59);
            lblR1Direccion.Name = "lblR1Direccion";
            lblR1Direccion.Size = new Size(60, 15);
            lblR1Direccion.TabIndex = 2;
            lblR1Direccion.Text = "Direccion:";
            // 
            // lblR1Telefono
            // 
            lblR1Telefono.AutoSize = true;
            lblR1Telefono.Location = new Point(29, 106);
            lblR1Telefono.Name = "lblR1Telefono";
            lblR1Telefono.Size = new Size(55, 15);
            lblR1Telefono.TabIndex = 3;
            lblR1Telefono.Text = "Telefono:";
            // 
            // lblR2Nombre
            // 
            lblR2Nombre.AutoSize = true;
            lblR2Nombre.Location = new Point(16, 19);
            lblR2Nombre.Name = "lblR2Nombre";
            lblR2Nombre.Size = new Size(110, 15);
            lblR2Nombre.TabIndex = 0;
            lblR2Nombre.Text = "Nombre Completo:";
            // 
            // lblR2Direccion
            // 
            lblR2Direccion.AutoSize = true;
            lblR2Direccion.Location = new Point(29, 59);
            lblR2Direccion.Name = "lblR2Direccion";
            lblR2Direccion.Size = new Size(60, 15);
            lblR2Direccion.TabIndex = 2;
            lblR2Direccion.Text = "Direccion:";
            // 
            // lblR2Telefono
            // 
            lblR2Telefono.AutoSize = true;
            lblR2Telefono.Location = new Point(29, 106);
            lblR2Telefono.Name = "lblR2Telefono";
            lblR2Telefono.Size = new Size(55, 15);
            lblR2Telefono.TabIndex = 3;
            lblR2Telefono.Text = "Telefono:";
            // 
            // lblDocumentos
            // 
            lblDocumentos.AutoSize = true;
            lblDocumentos.Location = new Point(16, 19);
            lblDocumentos.Name = "lblDocumentos";
            lblDocumentos.Size = new Size(53, 15);
            lblDocumentos.TabIndex = 0;
            lblDocumentos.Text = "Archivos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(134, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(136, 59);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(207, 23);
            txtApellido.TabIndex = 12;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(136, 106);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(207, 23);
            txtCedula.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(136, 154);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(207, 23);
            txtTelefono.TabIndex = 10;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(136, 199);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(207, 23);
            txtCorreo.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(136, 247);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(207, 23);
            txtDireccion.TabIndex = 7;
            // 
            // txtBarrio
            // 
            txtBarrio.Location = new Point(134, 323);
            txtBarrio.Name = "txtBarrio";
            txtBarrio.Size = new Size(207, 23);
            txtBarrio.TabIndex = 16;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(134, 289);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(207, 23);
            txtCiudad.TabIndex = 14;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(134, 20);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(207, 23);
            txtEmpresa.TabIndex = 1;
            // 
            // txtDireccionEmpresa
            // 
            txtDireccionEmpresa.Location = new Point(136, 59);
            txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            txtDireccionEmpresa.Size = new Size(207, 23);
            txtDireccionEmpresa.TabIndex = 12;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(136, 106);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(207, 23);
            txtCargo.TabIndex = 11;
            // 
            // txtIngresosMensuales
            // 
            txtIngresosMensuales.Location = new Point(136, 154);
            txtIngresosMensuales.Name = "txtIngresosMensuales";
            txtIngresosMensuales.Size = new Size(207, 23);
            txtIngresosMensuales.TabIndex = 10;
            // 
            // txtR1Nombre
            // 
            txtR1Nombre.Location = new Point(134, 20);
            txtR1Nombre.Name = "txtR1Nombre";
            txtR1Nombre.Size = new Size(180, 23);
            txtR1Nombre.TabIndex = 1;
            // 
            // txtR2Nombre
            // 
            txtR2Nombre.Location = new Point(134, 20);
            txtR2Nombre.Name = "txtR2Nombre";
            txtR2Nombre.Size = new Size(180, 23);
            txtR2Nombre.TabIndex = 1;
            // 
            // txtR1Telefono
            // 
            txtR1Telefono.Location = new Point(136, 106);
            txtR1Telefono.Name = "txtR1Telefono";
            txtR1Telefono.Size = new Size(178, 23);
            txtR1Telefono.TabIndex = 11;
            // 
            // txtR1Direccion
            // 
            txtR1Direccion.Location = new Point(136, 59);
            txtR1Direccion.Name = "txtR1Direccion";
            txtR1Direccion.Size = new Size(178, 23);
            txtR1Direccion.TabIndex = 12;
            // 
            // txtR2Telefono
            // 
            txtR2Telefono.Location = new Point(136, 106);
            txtR2Telefono.Name = "txtR2Telefono";
            txtR2Telefono.Size = new Size(178, 23);
            txtR2Telefono.TabIndex = 11;
            // 
            // txtR2Direccion
            // 
            txtR2Direccion.Location = new Point(136, 59);
            txtR2Direccion.Name = "txtR2Direccion";
            txtR2Direccion.Size = new Size(178, 23);
            txtR2Direccion.TabIndex = 12;
            // 
            // txtDocumentos
            // 
            txtDocumentos.Location = new Point(116, 22);
            txtDocumentos.Name = "txtDocumentos";
            txtDocumentos.Size = new Size(99, 23);
            txtDocumentos.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(21, 25);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(210, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(21, 60);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(210, 23);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(21, 89);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(210, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(21, 119);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(210, 23);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarDocumento
            // 
            btnSeleccionarDocumento.Location = new Point(239, 21);
            btnSeleccionarDocumento.Name = "btnSeleccionarDocumento";
            btnSeleccionarDocumento.Size = new Size(75, 23);
            btnSeleccionarDocumento.TabIndex = 36;
            btnSeleccionarDocumento.Text = "Cargar";
            btnSeleccionarDocumento.UseVisualStyleBackColor = true;
            btnSeleccionarDocumento.Click += btnSeleccionarDocumento_Click;
            // 
            // groupDatosPersonales
            // 
            groupDatosPersonales.Controls.Add(txtBarrio);
            groupDatosPersonales.Controls.Add(lblBarrio);
            groupDatosPersonales.Controls.Add(txtCiudad);
            groupDatosPersonales.Controls.Add(lblCiudad);
            groupDatosPersonales.Controls.Add(lblNombre);
            groupDatosPersonales.Controls.Add(txtNombre);
            groupDatosPersonales.Controls.Add(lblApellido);
            groupDatosPersonales.Controls.Add(lblCedula);
            groupDatosPersonales.Controls.Add(lblTelefono);
            groupDatosPersonales.Controls.Add(lblCorreo);
            groupDatosPersonales.Controls.Add(lblDireccion);
            groupDatosPersonales.Controls.Add(txtDireccion);
            groupDatosPersonales.Controls.Add(txtCorreo);
            groupDatosPersonales.Controls.Add(txtTelefono);
            groupDatosPersonales.Controls.Add(txtCedula);
            groupDatosPersonales.Controls.Add(txtApellido);
            groupDatosPersonales.Location = new Point(12, 24);
            groupDatosPersonales.Name = "groupDatosPersonales";
            groupDatosPersonales.Size = new Size(365, 380);
            groupDatosPersonales.TabIndex = 31;
            groupDatosPersonales.TabStop = false;
            groupDatosPersonales.Text = "Datos Personales";
            // 
            // groupDatosLaborales
            // 
            groupDatosLaborales.Controls.Add(lblEmpresa);
            groupDatosLaborales.Controls.Add(txtEmpresa);
            groupDatosLaborales.Controls.Add(lblDireccionDeLaEmpresa);
            groupDatosLaborales.Controls.Add(lblCargo);
            groupDatosLaborales.Controls.Add(lblIngresosMensuales);
            groupDatosLaborales.Controls.Add(txtIngresosMensuales);
            groupDatosLaborales.Controls.Add(txtCargo);
            groupDatosLaborales.Controls.Add(txtDireccionEmpresa);
            groupDatosLaborales.Location = new Point(12, 410);
            groupDatosLaborales.Name = "groupDatosLaborales";
            groupDatosLaborales.Size = new Size(365, 193);
            groupDatosLaborales.TabIndex = 32;
            groupDatosLaborales.TabStop = false;
            groupDatosLaborales.Text = "Datos Laborales";
            // 
            // groupReferencia
            // 
            groupReferencia.Controls.Add(lblR1Nombre);
            groupReferencia.Controls.Add(txtR1Nombre);
            groupReferencia.Controls.Add(lblR1Direccion);
            groupReferencia.Controls.Add(lblR1Telefono);
            groupReferencia.Controls.Add(txtR1Telefono);
            groupReferencia.Controls.Add(txtR1Direccion);
            groupReferencia.Location = new Point(383, 24);
            groupReferencia.Name = "groupReferencia";
            groupReferencia.Size = new Size(354, 145);
            groupReferencia.TabIndex = 33;
            groupReferencia.TabStop = false;
            groupReferencia.Text = "Referencia 1";
            // 
            // groupReferencia2
            // 
            groupReferencia2.Controls.Add(lblR2Nombre);
            groupReferencia2.Controls.Add(txtR2Nombre);
            groupReferencia2.Controls.Add(lblR2Direccion);
            groupReferencia2.Controls.Add(lblR2Telefono);
            groupReferencia2.Controls.Add(txtR2Telefono);
            groupReferencia2.Controls.Add(txtR2Direccion);
            groupReferencia2.Location = new Point(383, 178);
            groupReferencia2.Name = "groupReferencia2";
            groupReferencia2.Size = new Size(354, 145);
            groupReferencia2.TabIndex = 34;
            groupReferencia2.TabStop = false;
            groupReferencia2.Text = "Referencia 2";
            // 
            // groupDocumentos
            // 
            groupDocumentos.Controls.Add(btnSeleccionarDocumento);
            groupDocumentos.Controls.Add(lblDocumentos);
            groupDocumentos.Controls.Add(txtDocumentos);
            groupDocumentos.Location = new Point(383, 329);
            groupDocumentos.Name = "groupDocumentos";
            groupDocumentos.Size = new Size(354, 61);
            groupDocumentos.TabIndex = 35;
            groupDocumentos.TabStop = false;
            groupDocumentos.Text = "Documentos";
            // 
            // groupBotones
            // 
            groupBotones.Controls.Add(btnGuardar);
            groupBotones.Controls.Add(btnActualizar);
            groupBotones.Controls.Add(btnEliminar);
            groupBotones.Controls.Add(btnBuscar);
            groupBotones.Location = new Point(745, 24);
            groupBotones.Name = "groupBotones";
            groupBotones.Size = new Size(246, 366);
            groupBotones.TabIndex = 34;
            groupBotones.TabStop = false;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(383, 410);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(579, 194);
            dgvClientes.TabIndex = 17;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 648);
            Controls.Add(groupBotones);
            Controls.Add(groupDocumentos);
            Controls.Add(groupReferencia2);
            Controls.Add(groupReferencia);
            Controls.Add(groupDatosLaborales);
            Controls.Add(groupDatosPersonales);
            Controls.Add(dgvClientes);
            Name = "FrmClientes";
            Text = "FrmClientes";
            groupDatosPersonales.ResumeLayout(false);
            groupDatosPersonales.PerformLayout();
            groupDatosLaborales.ResumeLayout(false);
            groupDatosLaborales.PerformLayout();
            groupReferencia.ResumeLayout(false);
            groupReferencia.PerformLayout();
            groupReferencia2.ResumeLayout(false);
            groupReferencia2.PerformLayout();
            groupDocumentos.ResumeLayout(false);
            groupDocumentos.PerformLayout();
            groupBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // ------------------- DATOS PERSONALES -------------------
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblCedula;
        private TextBox txtCedula;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblBarrio;
        private TextBox txtBarrio;
        private Label lblCiudad;
        private TextBox txtCiudad;
        private GroupBox groupDatosPersonales;

        // ------------------- DATOS LABORALES -------------------
        private GroupBox groupDatosLaborales;
        private Label lblEmpresa;
        private TextBox txtEmpresa;
        private Label lblDireccionDeLaEmpresa;
        private TextBox txtDireccionEmpresa;
        private Label lblCargo;
        private TextBox txtCargo;
        private Label lblIngresosMensuales;
        private TextBox txtIngresosMensuales;

        // ------------------- REFERENCIAS PERSONALES -------------------
        private GroupBox groupReferencia;
        private Label lblR1Nombre;
        private TextBox txtR1Nombre;
        private Label lblR1Direccion;
        private TextBox txtR1Direccion;
        private Label lblR1Telefono;
        private TextBox txtR1Telefono;

        private GroupBox groupReferencia2;
        private Label lblR2Nombre;
        private TextBox txtR2Nombre;
        private Label lblR2Direccion;
        private TextBox txtR2Direccion;
        private Label lblR2Telefono;
        private TextBox txtR2Telefono;

        // ------------------- DOCUMENTOS -------------------
        private GroupBox groupDocumentos;
        private Label lblDocumentos;
        private TextBox txtDocumentos; // mostrará la ruta o nombre del archivo PDF
        private Button btnSeleccionarDocumento;

        // ------------------- BOTONES CRUD -------------------
        private GroupBox groupBotones;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnBuscar;

        // ------------------- TABLA DE CLIENTES -------------------
        private DataGridView dgvClientes;
    }
}
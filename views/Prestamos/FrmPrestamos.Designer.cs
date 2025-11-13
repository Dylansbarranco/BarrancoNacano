namespace BarrancoNacano.Views.Clientes
{
    partial class FrmPrestamos
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
            groupCliente = new GroupBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnBuscarCliente = new Button();
            lblCedula = new Label();
            txtCedula = new TextBox();
            groupDatosPrestamo = new GroupBox();
            lblQuienPresta = new Label();
            txtQuienPresta = new TextBox();
            dtpFechaCobro = new DateTimePicker();
            dtpFechaPrestamo = new DateTimePicker();
            lblFechaPrestamo = new Label();
            lblFechaCobro = new Label();
            txtFormaPago = new TextBox();
            lblFormaDePago = new Label();
            txtNumeroDeCuotas = new TextBox();
            lblNumeroDeCuotas = new Label();
            txtInteres = new TextBox();
            lblInteres = new Label();
            lblMontoPrestamo = new Label();
            txtMontoPrestado = new TextBox();
            groupCliente = new GroupBox();
            lblEstado = new Label();
            chkActivo = new CheckBox();
            dgvPrestamos = new DataGridView();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            groupBotones = new GroupBox();
            groupCliente.SuspendLayout();
            groupDatosPrestamo.SuspendLayout();
            groupCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            groupBotones.SuspendLayout();
            SuspendLayout();
            // 
            // groupCliente
            // 
            groupCliente.Controls.Add(txtNombre);
            groupCliente.Controls.Add(lblNombre);
            groupCliente.Controls.Add(btnBuscarCliente);
            groupCliente.Controls.Add(lblCedula);
            groupCliente.Controls.Add(txtCedula);
            groupCliente.Location = new Point(26, 26);
            groupCliente.Name = "groupCliente";
            groupCliente.Size = new Size(285, 124);
            groupCliente.TabIndex = 0;
            groupCliente.TabStop = false;
            groupCliente.Text = "Datos cliente";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(83, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AllowDrop = true;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(182, 42);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(75, 23);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // lblCedula
            // 
            lblCedula.AllowDrop = true;
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(26, 45);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(44, 15);
            lblCedula.TabIndex = 1;
            lblCedula.Text = "Cedula";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(76, 42);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(100, 23);
            txtCedula.TabIndex = 0;
            // 
            // groupDatosPrestamo
            // 
            groupDatosPrestamo.Controls.Add(lblQuienPresta);
            groupDatosPrestamo.Controls.Add(txtQuienPresta);
            groupDatosPrestamo.Controls.Add(dtpFechaCobro);
            groupDatosPrestamo.Controls.Add(dtpFechaPrestamo);
            groupDatosPrestamo.Controls.Add(lblFechaPrestamo);
            groupDatosPrestamo.Controls.Add(lblFechaCobro);
            groupDatosPrestamo.Controls.Add(txtFormaPago);
            groupDatosPrestamo.Controls.Add(lblFormaDePago);
            groupDatosPrestamo.Controls.Add(txtNumeroDeCuotas);
            groupDatosPrestamo.Controls.Add(lblNumeroDeCuotas);
            groupDatosPrestamo.Controls.Add(txtInteres);
            groupDatosPrestamo.Controls.Add(lblInteres);
            groupDatosPrestamo.Controls.Add(lblMontoPrestamo);
            groupDatosPrestamo.Controls.Add(txtMontoPrestado);
            groupDatosPrestamo.Location = new Point(26, 156);
            groupDatosPrestamo.Name = "groupDatosPrestamo";
            groupDatosPrestamo.Size = new Size(285, 368);
            groupDatosPrestamo.TabIndex = 5;
            groupDatosPrestamo.TabStop = false;
            groupDatosPrestamo.Text = "Datos del préstamo";
            // 
            // lblQuienPresta
            // 
            lblQuienPresta.AllowDrop = true;
            lblQuienPresta.AutoSize = true;
            lblQuienPresta.Location = new Point(27, 314);
            lblQuienPresta.Name = "lblQuienPresta";
            lblQuienPresta.Size = new Size(74, 15);
            lblQuienPresta.TabIndex = 16;
            lblQuienPresta.Text = "Quien Presta";
            // 
            // txtQuienPresta
            // 
            txtQuienPresta.Location = new Point(145, 314);
            txtQuienPresta.Name = "txtQuienPresta";
            txtQuienPresta.Size = new Size(112, 23);
            txtQuienPresta.TabIndex = 15;
            // 
            // dtpFechaCobro
            // 
            dtpFechaCobro.Location = new Point(145, 269);
            dtpFechaCobro.Name = "dtpFechaCobro";
            dtpFechaCobro.Size = new Size(112, 23);
            dtpFechaCobro.TabIndex = 14;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(145, 222);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(112, 23);
            dtpFechaPrestamo.TabIndex = 13;
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AllowDrop = true;
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.Location = new Point(26, 222);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(60, 30);
            lblFechaPrestamo.TabIndex = 10;
            lblFechaPrestamo.Text = "Fecha del \r\npréstamo";
            // 
            // lblFechaCobro
            // 
            lblFechaCobro.AllowDrop = true;
            lblFechaCobro.AutoSize = true;
            lblFechaCobro.Location = new Point(27, 275);
            lblFechaCobro.Name = "lblFechaCobro";
            lblFechaCobro.Size = new Size(98, 30);
            lblFechaCobro.TabIndex = 9;
            lblFechaCobro.Text = "Fecha del primer \r\ncobro";
            // 
            // txtFormaPago
            // 
            txtFormaPago.Location = new Point(145, 177);
            txtFormaPago.Name = "txtFormaPago";
            txtFormaPago.Size = new Size(112, 23);
            txtFormaPago.TabIndex = 8;
            // 
            // lblFormaDePago
            // 
            lblFormaDePago.AllowDrop = true;
            lblFormaDePago.AutoSize = true;
            lblFormaDePago.Location = new Point(27, 185);
            lblFormaDePago.Name = "lblFormaDePago";
            lblFormaDePago.Size = new Size(88, 15);
            lblFormaDePago.TabIndex = 7;
            lblFormaDePago.Text = "Forma De Pago";
            // 
            // txtNumeroDeCuotas
            // 
            txtNumeroDeCuotas.Location = new Point(145, 130);
            txtNumeroDeCuotas.Name = "txtNumeroDeCuotas";
            txtNumeroDeCuotas.Size = new Size(112, 23);
            txtNumeroDeCuotas.TabIndex = 6;
            // 
            // lblNumeroDeCuotas
            // 
            lblNumeroDeCuotas.AllowDrop = true;
            lblNumeroDeCuotas.AutoSize = true;
            lblNumeroDeCuotas.Location = new Point(26, 133);
            lblNumeroDeCuotas.Name = "lblNumeroDeCuotas";
            lblNumeroDeCuotas.Size = new Size(67, 30);
            lblNumeroDeCuotas.TabIndex = 5;
            lblNumeroDeCuotas.Text = "Número de\r\n cuotas";
            // 
            // txtInteres
            // 
            txtInteres.Location = new Point(145, 81);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(112, 23);
            txtInteres.TabIndex = 4;
            // 
            // lblInteres
            // 
            lblInteres.AllowDrop = true;
            lblInteres.AutoSize = true;
            lblInteres.Location = new Point(26, 89);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(63, 15);
            lblInteres.TabIndex = 3;
            lblInteres.Text = "Interés (%)";
            // 
            // lblMontoPrestamo
            // 
            lblMontoPrestamo.AllowDrop = true;
            lblMontoPrestamo.AutoSize = true;
            lblMontoPrestamo.Location = new Point(26, 45);
            lblMontoPrestamo.Name = "lblMontoPrestamo";
            lblMontoPrestamo.Size = new Size(65, 30);
            lblMontoPrestamo.TabIndex = 1;
            lblMontoPrestamo.Text = "Monto del \r\npréstamo";
            // 
            // txtMontoPrestado
            // 
            txtMontoPrestado.Location = new Point(145, 42);
            txtMontoPrestado.Name = "txtMontoPrestado";
            txtMontoPrestado.Size = new Size(112, 23);
            txtMontoPrestado.TabIndex = 0;
            // 
            // groupBotones
            // 
            groupCliente.Controls.Add(lblEstado);
            groupCliente.Controls.Add(chkActivo);
            groupCliente.Location = new Point(317, 26);
            groupBotones.Name = "groupBotones";
            groupCliente.Size = new Size(285, 124);
            groupCliente.TabIndex = 5;
            groupCliente.TabStop = false;
            groupCliente.Text = "Estado del préstamo";
            // 
            // lblEstado
            // 
            lblEstado.AllowDrop = true;
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(23, 41);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(41, 15);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Activo";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(97, 41);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(83, 19);
            chkActivo.TabIndex = 0;
            chkActivo.Text = "checkBox1";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(317, 165);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.Size = new Size(471, 345);
            dgvPrestamos.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(6, 10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(154, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(6, 67);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(154, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(6, 96);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(154, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(6, 38);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(154, 23);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // groupBotones
            // 
            groupBotones.Controls.Add(btnGuardar);
            groupBotones.Controls.Add(btnBuscar);
            groupBotones.Controls.Add(btnActualizar);
            groupBotones.Controls.Add(btnEliminar);
            groupBotones.Location = new Point(608, 26);
            groupBotones.Name = "groupBotones";
            groupBotones.Size = new Size(166, 133);
            groupBotones.TabIndex = 6;
            groupBotones.TabStop = false;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 572);
            Controls.Add(groupBotones);
            Controls.Add(dgvPrestamos);
            Controls.Add(groupCliente);
            Controls.Add(groupDatosPrestamo);
            Controls.Add(groupCliente);
            Name = "FrmPrestamos";
            Text = "FrmPrestamos";
            Load += FrmPrestamos_Load;
            groupCliente.ResumeLayout(false);
            groupCliente.PerformLayout();
            groupDatosPrestamo.ResumeLayout(false);
            groupDatosPrestamo.PerformLayout();
            groupCliente    .ResumeLayout(false);
            groupCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            groupBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // ------------------- DATOS DEL CLIENTE -------------------
        private GroupBox groupCliente;
        private Label lblCedula;
        private TextBox txtCedula;
        private Button btnBuscarCliente;
        private TextBox txtNombre;
        private Label lblNombre;

        // ------------------- DATOS DEL PRÉSTAMO -------------------
        private GroupBox groupDatosPrestamo;
        private Label lblMontoPrestamo;
        private TextBox txtMontoPrestado;
        private Label lblInteres;
        private TextBox txtInteres;
        private Label lblNumeroDeCuotas;
        private TextBox txtNumeroDeCuotas;
        private Label lblFormaDePago;
        private TextBox txtFormaPago;
        private Label lblFechaPrestamo;
        private DateTimePicker dtpFechaPrestamo;
        private Label lblFechaCobro;
        private DateTimePicker dtpFechaCobro;
        private Label lblQuienPresta;
        private TextBox txtQuienPresta;

        // ------------------- ESTADO -------------------
        private GroupBox groupEstado;
        private Label lblEstado;
        private CheckBox chkActivo;

        // ------------------- TABLA DE PRÉSTAMOS -------------------
        private DataGridView dgvPrestamos;

        // ------------------- BOTONES -------------------
        private GroupBox groupBotones;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnBuscar;
    }
}
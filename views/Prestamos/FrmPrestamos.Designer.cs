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
            btnBuscarcliente = new Button();
            lblCedula = new Label();
            txtCedula = new TextBox();
            groupDatosPrestamo = new GroupBox();
            label2 = new Label();
            txtQuienPresta = new TextBox();
            ddtpFechaCobro = new DateTimePicker();
            dtpFechaPrestamo = new DateTimePicker();
            lblFechaPrestamo = new Label();
            label1 = new Label();
            txtFormaPago = new TextBox();
            lblFormaDePago = new Label();
            txtNumeroDeCuotas = new TextBox();
            lblNumeroDeCuotas = new Label();
            txtInteres = new TextBox();
            lblInteres = new Label();
            lblMontoPrestamo = new Label();
            txtMontoPrestado = new TextBox();
            groupBox1 = new GroupBox();
            chkActivo = new CheckBox();
            lblEstado = new Label();
            dgvPrestamos = new DataGridView();
            this.btnGuardar = new Button();
            this.btnEliminar = new Button();
            this.btnBuscar = new Button();
            btnActualizar = new Button();
            groupBox2 = new GroupBox();
            groupCliente.SuspendLayout();
            groupDatosPrestamo.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupCliente
            // 
            groupCliente.Controls.Add(txtNombre);
            groupCliente.Controls.Add(lblNombre);
            groupCliente.Controls.Add(btnBuscarcliente);
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
            // btnBuscarcliente
            // 
            btnBuscarcliente.Location = new Point(182, 42);
            btnBuscarcliente.Name = "btnBuscarcliente";
            btnBuscarcliente.Size = new Size(75, 23);
            btnBuscarcliente.TabIndex = 2;
            btnBuscarcliente.Text = "Buscar";
            btnBuscarcliente.UseVisualStyleBackColor = true;
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
            groupDatosPrestamo.Controls.Add(label2);
            groupDatosPrestamo.Controls.Add(txtQuienPresta);
            groupDatosPrestamo.Controls.Add(ddtpFechaCobro);
            groupDatosPrestamo.Controls.Add(dtpFechaPrestamo);
            groupDatosPrestamo.Controls.Add(lblFechaPrestamo);
            groupDatosPrestamo.Controls.Add(label1);
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
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Location = new Point(27, 314);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 16;
            label2.Text = "Quien Presta";
            // 
            // txtQuienPresta
            // 
            txtQuienPresta.Location = new Point(145, 314);
            txtQuienPresta.Name = "txtQuienPresta";
            txtQuienPresta.Size = new Size(112, 23);
            txtQuienPresta.TabIndex = 15;
            // 
            // ddtpFechaCobro
            // 
            ddtpFechaCobro.Location = new Point(145, 269);
            ddtpFechaCobro.Name = "ddtpFechaCobro";
            ddtpFechaCobro.Size = new Size(112, 23);
            ddtpFechaCobro.TabIndex = 14;
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
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Location = new Point(27, 275);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 9;
            label1.Text = "Fecha del primer \r\ncobro";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(chkActivo);
            groupBox1.Location = new Point(317, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 124);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado del préstamo";
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
            // lblEstado
            // 
            lblEstado.AllowDrop = true;
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(23, 41);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Estado";
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
            this.btnGuardar.Location = new Point(6, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new Size(154, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.btnEliminar.Location = new Point(6, 67);
            this.btnEliminar.Name = "BtnEliminar";
            this.btnEliminar.Size = new Size(154, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Elimiar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new Point(6, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new Size(154, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(this.btnGuardar);
            groupBox2.Controls.Add(this.btnBuscar);
            groupBox2.Controls.Add(btnActualizar);
            groupBox2.Controls.Add(this.btnEliminar);
            groupBox2.Location = new Point(608, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(166, 133);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 572);
            Controls.Add(groupBox2);
            Controls.Add(dgvPrestamos);
            Controls.Add(groupBox1);
            Controls.Add(groupDatosPrestamo);
            Controls.Add(groupCliente);
            Name = "FrmPrestamos";
            Text = "FrmPrestamos";
            Load += FrmPrestamos_Load;
            groupCliente.ResumeLayout(false);
            groupCliente.PerformLayout();
            groupDatosPrestamo.ResumeLayout(false);
            groupDatosPrestamo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupCliente;
        private Label lblCedula;
        private TextBox txtCedula;
        private Button btnBuscarcliente;
        private TextBox txtNombre;
        private Label lblNombre;
        private GroupBox groupDatosPrestamo;
        private TextBox txtQuienPresta;
        private Label lblNumeroDeCuotas;
        private TextBox txtNumeroDeCuotas;
        private Label lblInteres;
        private Label lblMontoPrestamo;
        private TextBox txtMontoPrestado;
        private Label lblFormaDePago;
        private Label lblFechaPrestamo;
        private Label label1;
        private TextBox txtFormaPago;
        private Label label2;
        private TextBox txtInteres;
        private DateTimePicker ddtpFechaCobro;
        private DateTimePicker dtpFechaPrestamo;
        private TextBox textBox6;
        private GroupBox groupBox1;
        private Label lblEstado;
        private CheckBox chkActivo;
        private DataGridView dgvPrestamos;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnGuardar;
        private Button btnActualizar;
        private GroupBox groupBox2;
    }
}
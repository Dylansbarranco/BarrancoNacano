using BarrancoNacano.Controllers;
using BarrancoNacano.Models;
using System;
using System.Windows.Forms;

namespace BarrancoNacano.Views.Clientes
{
    public partial class FrmClientes : Form
    {
        private ClienteController clienteController = new ClienteController();

        public FrmClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clienteController.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCedula.Text))
                {
                    MessageBox.Show("Debe ingresar la cédula del cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Cedula = txtCedula.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text
                };

                clienteController.Guardar(cliente);
                MessageBox.Show("Cliente guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);
            clienteController.Eliminar(id);
            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            var cliente = clienteController.BuscarPorCedula(cedula);

            if (cliente == null)
            {
                MessageBox.Show("No se encontró ningún cliente con esa cédula.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
            txtDireccion.Text = cliente.Direccion;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);

            var cliente = new Cliente
            {
                Id = id,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Cedula = txtCedula.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Direccion = txtDireccion.Text
            };

            clienteController.Actualizar(cliente);
            MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarClientes();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void lblCedula_Click(object sender, EventArgs e) { }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarDocumento_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                openFileDialog.Title = "Seleccionar archivo de documentos";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDocumentos.Text = openFileDialog.FileName;
                }
            }
        }
    }
}

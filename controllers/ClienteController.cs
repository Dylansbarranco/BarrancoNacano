using BarrancoNacano.Models;

using System.Collections.Generic;
using System.Linq;

namespace BarrancoNacano.Controllers
{
    public class ClienteController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public void Guardar(Cliente cliente)
        {
            cliente.Id = clientes.Count + 1;
            clientes.Add(cliente);
        }

        public List<Cliente> Listar()
        {
            return clientes;
        }

        public Cliente BuscarPorCedula(string cedula)
        {
            return clientes.FirstOrDefault(c => c.Cedula == cedula);
        }

        public void Actualizar(Cliente clienteActualizado)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == clienteActualizado.Id);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                clientes.Add(clienteActualizado);
            }
        }

        public void Eliminar(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
                clientes.Remove(cliente);
        }
    }
}

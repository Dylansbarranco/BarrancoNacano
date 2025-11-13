using BarrancoNacano.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BarrancoNacano.Controllers
{
    public class ClienteController
    {
        private readonly AppDbContext _context;

        public ClienteController()
        {
            _context = new AppDbContext(); // Tu clase de contexto
        }

        // ------------------- GUARDAR CLIENTE -------------------
        public void Guardar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        // ------------------- LISTAR CLIENTES -------------------
        public List<Cliente> Listar()
        {
            return _context.Clientes.ToList();
        }

        // ------------------- BUSCAR POR CÉDULA -------------------
        public Cliente BuscarPorCedula(string cedula)
        {
            return _context.Clientes.FirstOrDefault(c => c.Cedula == cedula);
        }

        // ------------------- ACTUALIZAR CLIENTE -------------------
        public void Actualizar(Cliente clienteActualizado)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == clienteActualizado.Id);
            if (cliente != null)
            {
                cliente.Nombre = clienteActualizado.Nombre;
                cliente.Apellido = clienteActualizado.Apellido;
                cliente.Cedula = clienteActualizado.Cedula;
                cliente.Telefono = clienteActualizado.Telefono;
                cliente.Correo = clienteActualizado.Correo;
                cliente.Direccion = clienteActualizado.Direccion;

                _context.SaveChanges();
            }
        }

        // ------------------- ELIMINAR CLIENTE -------------------
        public void Eliminar(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}

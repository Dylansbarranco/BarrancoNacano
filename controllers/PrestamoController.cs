using BarrancoNacano.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BarrancoNacano.Controllers
{
    // ------------------- CONTROLADOR DE PRÉSTAMOS -------------------
    public class PrestamoController
    {
        private readonly AppDbContext _context;

        // Constructor
        public PrestamoController()
        {
            _context = new AppDbContext();
        }

        // ------------------- GUARDAR NUEVO PRÉSTAMO -------------------
        public void Guardar(Prestamo prestamo)
        {
            try
            {
                // Validación: el cliente no debe tener un préstamo activo
                var prestamoActivo = _context.Prestamos
                    .FirstOrDefault(p => p.CedulaCliente == prestamo.CedulaCliente && p.Activo);

                if (prestamoActivo != null)
                    throw new Exception("El cliente ya tiene un préstamo activo.");

                prestamo.FechaPrestamo = DateTime.Now;
                prestamo.Activo = true;

                _context.Prestamos.Add(prestamo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el préstamo: " + ex.Message);
            }
        }

        // ------------------- LISTAR TODOS LOS PRÉSTAMOS -------------------
        public List<Prestamo> Listar()
        {
            return _context.Prestamos
                .OrderByDescending(p => p.FechaPrestamo)
                .ToList();
        }

        // ------------------- BUSCAR POR CÉDULA -------------------
        public List<Prestamo> BuscarPorCedula(string cedula)
        {
            return _context.Prestamos
                .Where(p => p.CedulaCliente.Trim().Equals(cedula.Trim(), StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(p => p.FechaPrestamo)
                .ToList();
        }

        // ------------------- BUSCAR POR ID -------------------
        public Prestamo BuscarPorId(int id)
        {
            return _context.Prestamos.FirstOrDefault(p => p.IdPrestamo == id);
        }

        // ------------------- ACTUALIZAR PRÉSTAMO -------------------
        public void Actualizar(Prestamo prestamoActualizado)
        {
            try
            {
                var prestamo = _context.Prestamos.FirstOrDefault(p => p.IdPrestamo == prestamoActualizado.IdPrestamo);
                if (prestamo == null)
                    throw new Exception("El préstamo no existe.");

                // Actualizamos los campos manualmente (para evitar sobrescribir todo)
                prestamo.Monto = prestamoActualizado.Monto;
                prestamo.Interes = prestamoActualizado.Interes;
                prestamo.NumeroCuotas = prestamoActualizado.NumeroCuotas;
                prestamo.FormaPago = prestamoActualizado.FormaPago;
                prestamo.FechaCobro = prestamoActualizado.FechaCobro;
                prestamo.Activo = prestamoActualizado.Activo;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el préstamo: " + ex.Message);
            }
        }

        // ------------------- ELIMINAR PRÉSTAMO -------------------
        public void Eliminar(int id)
        {
            try
            {
                var prestamo = _context.Prestamos.FirstOrDefault(p => p.IdPrestamo == id);
                if (prestamo == null)
                    throw new Exception("El préstamo no existe.");

                _context.Prestamos.Remove(prestamo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el préstamo: " + ex.Message);
            }
        }

        // ------------------- CERRAR PRÉSTAMO -------------------
        public void CerrarPrestamo(int id)
        {
            try
            {
                var prestamo = _context.Prestamos.FirstOrDefault(p => p.IdPrestamo == id);
                if (prestamo == null)
                    throw new Exception("El préstamo no existe.");

                prestamo.Activo = false;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar el préstamo: " + ex.Message);
            }
        }
    }
}

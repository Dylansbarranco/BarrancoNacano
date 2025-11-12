using System.Collections.Generic;
using System.Linq;
using BarrancoNacano.Models;

namespace BarrancoNacano.Controllers
{
    public class PrestamoController
    {
        private static List<Prestamo> prestamos = new List<Prestamo>();

        public void Guardar(Prestamo prestamo)
        {
            prestamo.Id = prestamos.Count + 1;
            prestamos.Add(prestamo);
        }

        public List<Prestamo> Listar()
        {
            return prestamos;
        }

        public Prestamo BuscarPorId(int id)
        {
            return prestamos.FirstOrDefault(p => p.Id == id);
        }

        public void Actualizar(Prestamo prestamoActualizado)
        {
            var prestamo = prestamos.FirstOrDefault(p => p.Id == prestamoActualizado.Id);
            if (prestamo != null)
            {
                prestamos.Remove(prestamo);
                prestamos.Add(prestamoActualizado);
            }
        }

        public void Eliminar(int id)
        {
            var prestamo = prestamos.FirstOrDefault(p => p.Id == id);
            if (prestamo != null)
                prestamos.Remove(prestamo);
        }
    }
}

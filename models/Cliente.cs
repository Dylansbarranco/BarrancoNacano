using System;

namespace BarrancoNacano.Models
{
    public class Cliente
    {
        // Datos personales
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Barrio { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        // Datos laborales
        public string Empresa { get; set; }
        public string DireccionEmpresa { get; set; }
        public string Cargo { get; set; }
        public decimal IngresoMensual { get; set; }

        // Referencias
        public string Ref1Nombre { get; set; }
        public string Ref1Telefono { get; set; }
        public string Ref2Nombre { get; set; }
        public string Ref2Telefono { get; set; }

        // Documentos
        public string DocumentoCedula { get; set; }
        public string DocumentoLaboral { get; set; }
        public string DocumentoLetraCambio { get; set; }
        public string Foto { get; set; }

        // Relación con préstamos
        public bool TienePrestamoActivo { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}

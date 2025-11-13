using System.ComponentModel.DataAnnotations;

namespace BarrancoNacano.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Barrio { get; set; }
        public string Empresa { get; set; }
        public string DireccionEmpresa { get; set; }
        public string Cargo { get; set; }
        public decimal IngresosMensuales { get; set; }
        public string R1Nombre { get; set; }
        public string R1Direccion { get; set; }
        public string R1Telefono { get; set; }
        public string R2Nombre { get; set; }
        public string R2Direccion { get; set; }
        public string R2Telefono { get; set; }
        public string RutaDocumentos { get; set; }
    }
}

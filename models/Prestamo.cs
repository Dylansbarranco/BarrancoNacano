using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarrancoNacano.Models
{
    [Table("Prestamos")]
    public class Prestamo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrestamo { get; set; }

        // 🔹 Llave foránea hacia Cliente.Id
        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Monto { get; set; }

        [Required]
        public decimal Interes { get; set; }

        [Required]
        public int NumeroCuotas { get; set; }

        [StringLength(50)]
        public string FormaPago { get; set; }

        [Required]
        public DateTime FechaPrestamo { get; set; }

        [Required]
        public DateTime FechaCobro { get; set; }

        [StringLength(100)]
        public string QuienPresta { get; set; }

        public bool Activo { get; set; }

        // Campo opcional, solo para guardar la cédula como dato adicional
        [StringLength(15)]
        public string CedulaCliente { get; set; }
    }
}

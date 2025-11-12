using System;
using System.ComponentModel.DataAnnotations;

namespace   BarrancoNacano.Models
{
    public class Pago
    {
        [Key]
        public int Id { get; set; }
        public int PrestamoId { get; set; }
        public decimal Valor { get; set; }
        public DateTime FechaPago { get; set; }
        public string Tipo { get; set; } // Abono, Pago total, etc.
    }
}

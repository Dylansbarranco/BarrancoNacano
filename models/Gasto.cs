using System;
using System.ComponentModel.DataAnnotations;

namespace   BarrancoNacano.Models
{
    public class Gasto
    {
        [Key]
        public int Id { get; set; }
        public string Motivo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
    }
}

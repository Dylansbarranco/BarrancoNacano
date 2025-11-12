public class Prestamo
{
    public int Id { get; set; }  // ID interno del préstamo (autoincremental)
    public string CedulaCliente { get; set; }  // ← Relación con Cliente.Cedula

    public decimal Monto { get; set; }
    public decimal Interes { get; set; }
    public int NumeroCuotas { get; set; }
    public string FormaPago { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaCobro { get; set; }
    public string QuienPresta { get; set; }

    public bool Activo { get; set; } = true;
}

using System;
using System.Collections.Generic;

namespace Prueba_Yefrin.Models;

public partial class HistorialSalario
{
    public long IdHistorial { get; set; }

    public int EmpleadoId { get; set; }

    public decimal SalarioAnterior { get; set; }

    public decimal SalarioNuevo { get; set; }

    public string? Motivo { get; set; }

    public DateOnly FechaCambio { get; set; }

    public int? UsuarioRegistroId { get; set; }

    public DateTime CreadoEn { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual Usuario? UsuarioRegistro { get; set; }
}

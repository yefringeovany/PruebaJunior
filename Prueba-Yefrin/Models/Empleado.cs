using System;
using System.Collections.Generic;

namespace Prueba_Yefrin.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string DocumentoCui { get; set; } = null!;

    public DateOnly FechaIngreso { get; set; }

    public decimal SalarioActual { get; set; }

    public DateOnly? FechaUltimoAumento { get; set; }

    public DateOnly? FechaBaja { get; set; }

    public string Puesto { get; set; } = null!;

    public string? Jerarquia { get; set; }

    public int DepartamentoId { get; set; }

    public int? UsuarioCreacionId { get; set; }

    public DateTime CreadoEn { get; set; }

    public DateTime ActualizadoEn { get; set; }

    public virtual Departamento Departamento { get; set; } = null!;

    public virtual ICollection<HistorialSalario> HistorialSalarios { get; set; } = new List<HistorialSalario>();

    public virtual Usuario? UsuarioCreacion { get; set; }
}

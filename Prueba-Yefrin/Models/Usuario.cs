using System;
using System.Collections.Generic;

namespace Prueba_Yefrin.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Username { get; set; } = null!;

    public byte[] HashPassword { get; set; } = null!;

    public string? Email { get; set; }

    public bool Activo { get; set; }

    public DateTime CreadoEn { get; set; }

    public DateTime ActualizadoEn { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<HistorialSalario> HistorialSalarios { get; set; } = new List<HistorialSalario>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();

    public virtual ICollection<Rol> IdRols { get; set; } = new List<Rol>();
}

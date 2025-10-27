using System;
using System.Collections.Generic;

namespace Prueba_Yefrin.Models;

public partial class Ventum
{
    public long IdVenta { get; set; }

    public int IdCliente { get; set; }

    public int UsuarioId { get; set; }

    public DateOnly Fecha { get; set; }

    public decimal Total { get; set; }

    public DateTime CreadoEn { get; set; }

    public DateTime ActualizadoEn { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}

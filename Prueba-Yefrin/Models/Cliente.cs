using System;
using System.Collections.Generic;

namespace Prueba_Yefrin.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nit { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime CreadoEn { get; set; }

    public DateTime ActualizadoEn { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}

using System;
using System.Collections.Generic;

namespace Prueba_Yefrin.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Sku { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Existencia { get; set; }

    public decimal Precio { get; set; }

    public decimal Costo { get; set; }

    public bool Activo { get; set; }

    public DateTime CreadoEn { get; set; }

    public DateTime ActualizadoEn { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();
}

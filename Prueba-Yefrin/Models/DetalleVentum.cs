using System;
using System.Collections.Generic;

namespace Prueba_Yefrin.Models;

public partial class DetalleVentum
{
    public long IdDetalle { get; set; }

    public long IdVenta { get; set; }

    public int IdProducto { get; set; }

    public string Sku { get; set; } = null!;

    public int Cantidad { get; set; }

    public decimal PrecioUnit { get; set; }

    public decimal CostoUnit { get; set; }

    public decimal Descuento { get; set; }

    public decimal? Subtotal { get; set; }

    public DateTime CreadoEn { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    public virtual Ventum IdVentaNavigation { get; set; } = null!;
}

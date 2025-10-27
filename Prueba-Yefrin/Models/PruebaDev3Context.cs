using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Prueba_Yefrin.Models;

public partial class PruebaDev3Context : DbContext
{
    public PruebaDev3Context()
    {
    }

    public PruebaDev3Context(DbContextOptions<PruebaDev3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DetalleVentum> DetalleVenta { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<HistorialSalario> HistorialSalarios { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local); DataBase=PruebaDev3;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__cliente__677F38F5C39D7BC3");

            entity.ToTable("cliente");

            entity.HasIndex(e => e.Nit, "UX_cliente_nit").IsUnique();

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.ActualizadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("actualizado_en");
            entity.Property(e => e.CreadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("creado_en");
            entity.Property(e => e.Nit)
                .HasMaxLength(20)
                .HasColumnName("nit");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.IdDepartamento).HasName("PK__departam__64F37A161A107C53");

            entity.ToTable("departamento");

            entity.HasIndex(e => e.Nombre, "UQ__departam__72AFBCC6D4D76885").IsUnique();

            entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");
            entity.Property(e => e.ActualizadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("actualizado_en");
            entity.Property(e => e.CreadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("creado_en");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Presupuesto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("presupuesto");
        });

        modelBuilder.Entity<DetalleVentum>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("PK__detalle___4F1332DE1701B0CF");

            entity.ToTable("detalle_venta");

            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.CostoUnit)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("costo_unit");
            entity.Property(e => e.CreadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("creado_en");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("descuento");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.PrecioUnit)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio_unit");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("sku");
            entity.Property(e => e.Subtotal)
                .HasComputedColumnSql("([cantidad]*[precio_unit]-[descuento])", true)
                .HasColumnType("decimal(24, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_detalle_producto");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdVenta)
                .HasConstraintName("FK_detalle_venta");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__empleado__88B51394F21BDA4B");

            entity.ToTable("empleado");

            entity.HasIndex(e => e.DocumentoCui, "UX_empleado_cui").IsUnique();

            entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");
            entity.Property(e => e.ActualizadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("actualizado_en");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(150)
                .HasColumnName("apellidos");
            entity.Property(e => e.CreadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("creado_en");
            entity.Property(e => e.DepartamentoId).HasColumnName("departamento_id");
            entity.Property(e => e.DocumentoCui)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("documento_cui");
            entity.Property(e => e.FechaBaja).HasColumnName("fecha_baja");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaUltimoAumento).HasColumnName("fecha_ultimo_aumento");
            entity.Property(e => e.Jerarquia)
                .HasMaxLength(80)
                .HasColumnName("jerarquia");
            entity.Property(e => e.Nombres)
                .HasMaxLength(120)
                .HasColumnName("nombres");
            entity.Property(e => e.Puesto)
                .HasMaxLength(120)
                .HasColumnName("puesto");
            entity.Property(e => e.SalarioActual)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("salario_actual");
            entity.Property(e => e.UsuarioCreacionId).HasColumnName("usuario_creacion_id");

            entity.HasOne(d => d.Departamento).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.DepartamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empleado_departamento");

            entity.HasOne(d => d.UsuarioCreacion).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.UsuarioCreacionId)
                .HasConstraintName("FK_empleado_usuario");
        });

        modelBuilder.Entity<HistorialSalario>(entity =>
        {
            entity.HasKey(e => e.IdHistorial).HasName("PK__historia__76E6C502A9D67241");

            entity.ToTable("historial_salario");

            entity.Property(e => e.IdHistorial).HasColumnName("id_historial");
            entity.Property(e => e.CreadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("creado_en");
            entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");
            entity.Property(e => e.FechaCambio)
                .HasDefaultValueSql("(CONVERT([date],sysutcdatetime()))")
                .HasColumnName("fecha_cambio");
            entity.Property(e => e.Motivo)
                .HasMaxLength(250)
                .HasColumnName("motivo");
            entity.Property(e => e.SalarioAnterior)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("salario_anterior");
            entity.Property(e => e.SalarioNuevo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("salario_nuevo");
            entity.Property(e => e.UsuarioRegistroId).HasColumnName("usuario_registro_id");

            entity.HasOne(d => d.Empleado).WithMany(p => p.HistorialSalarios)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_historial_empleado");

            entity.HasOne(d => d.UsuarioRegistro).WithMany(p => p.HistorialSalarios)
                .HasForeignKey(d => d.UsuarioRegistroId)
                .HasConstraintName("FK_historial_usuario");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__producto__FF341C0DFF65B321");

            entity.ToTable("producto");

            entity.HasIndex(e => e.Sku, "UQ__producto__DDDF4BE785BECA52").IsUnique();

            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.ActualizadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("actualizado_en");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("costo");
            entity.Property(e => e.CreadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("creado_en");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .HasColumnName("descripcion");
            entity.Property(e => e.Existencia).HasColumnName("existencia");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("sku");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__rol__6ABCB5E0D42418D7");

            entity.ToTable("rol");

            entity.HasIndex(e => e.Nombre, "UQ__rol__72AFBCC6D5AE7789").IsUnique();

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__usuario__4E3E04AD10AFD583");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.Username, "UQ__usuario__F3DBC572B45DB5FE").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.ActualizadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("actualizado_en");
            entity.Property(e => e.CreadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("creado_en");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");
            entity.Property(e => e.HashPassword)
                .HasMaxLength(256)
                .HasColumnName("hash_password");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");

            entity.HasMany(d => d.IdRols).WithMany(p => p.IdUsuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioRol",
                    r => r.HasOne<Rol>().WithMany()
                        .HasForeignKey("IdRol")
                        .HasConstraintName("FK_usuario_rol_rol"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK_usuario_rol_usuario"),
                    j =>
                    {
                        j.HasKey("IdUsuario", "IdRol").HasName("PK__usuario___5895CFF3BFF150B3");
                        j.ToTable("usuario_rol");
                        j.IndexerProperty<int>("IdUsuario").HasColumnName("id_usuario");
                        j.IndexerProperty<int>("IdRol").HasColumnName("id_rol");
                    });
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__venta__459533BFA5605255");

            entity.ToTable("venta");

            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.ActualizadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("actualizado_en");
            entity.Property(e => e.CreadoEn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("creado_en");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(CONVERT([date],sysutcdatetime()))")
                .HasColumnName("fecha");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_cliente");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Venta)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

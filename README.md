# Proyecto Prueba ASP.NET Core

## Descripción
Aplicación web para la gestión de empleados, ventas y usuarios, con control de acceso basado en roles.  
Permite administrar información de manera segura, con operaciones CRUD para empleados, clientes, ventas y productos.

---

## Arquitectura del proyecto
- **Patrón MVC (Model-View-Controller):**
  - **Models:** Representan las tablas de la base de datos y las entidades del dominio.
  - **Views:** Vistas Razor para la interacción con el usuario.
  - **Controllers:** Lógica de negocio, manejo de rutas y coordinación entre modelos y vistas.
- **Capa de datos:**
  - **Entity Framework Core** como ORM para acceso seguro a la base de datos.
  - Integridad referencial entre tablas: `Empleado`, `HistorialSalario`, `Departamento`, `Cliente`, `Venta`, `DetalleVenta`, `Producto`, `Usuario`, `Rol`, `Usuario_Rol`.
- **Seguridad y autenticación:**
  - ASP.NET Core Identity para manejo de usuarios y roles.
  - Autenticación basada en cookies.
  - Acceso controlado mediante `[Authorize]` en controladores y acciones críticas.
  - Validación de modelos y protección CSRF.

---

## Decisiones técnicas
- **Lenguaje y Framework:** C# con ASP.NET Core MVC por robustez y compatibilidad con SQL Server.
- **Base de datos:** SQL Server para manejo de transacciones, relaciones y soporte nativo con EF Core.
- **Manejo de errores:** 
  - `try/catch` en operaciones críticas.
  - Middleware global de manejo de errores.
- **Seguridad básica:** 
  - Validación de modelos (`[Required]`, `[StringLength]`, `[Range]`).
  - Hash de contraseñas mediante Identity.
  - Prevención de SQL Injection usando EF Core.
  - Control de acceso basado en roles (`Admin` y `Operador`).

---

## Requisitos
- .NET 7 SDK o superior  
- SQL Server  
- Visual Studio 2022 o VS Code  

---

## Instalación y ejecución

1. Clonar el repositorio:
```bash
git clone https://github.com/usuario/proyecto-prueba.git




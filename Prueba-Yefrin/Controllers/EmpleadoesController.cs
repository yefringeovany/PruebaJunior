using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prueba_Yefrin.Models;

namespace Prueba_Yefrin.Controllers
{
    public class EmpleadoesController : Controller
    {
        private readonly PruebaDev3Context _context;

        public EmpleadoesController(PruebaDev3Context context)
        {
            _context = context;
        }

        // GET: Empleadoes
        public async Task<IActionResult> Index()
        {
            var pruebaDev3Context = _context.Empleados.Include(e => e.Departamento).Include(e => e.UsuarioCreacion);
            return View(await pruebaDev3Context.ToListAsync());
        }

        // GET: Empleadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleados
                .Include(e => e.Departamento)
                .Include(e => e.UsuarioCreacion)
                .FirstOrDefaultAsync(m => m.IdEmpleado == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // GET: Empleadoes/Create
        public IActionResult Create()
        {
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "IdDepartamento", "IdDepartamento");
            ViewData["UsuarioCreacionId"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario");
            return View();
        }

        // POST: Empleadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmpleado,Nombres,Apellidos,DocumentoCui,FechaIngreso,SalarioActual,FechaUltimoAumento,FechaBaja,Puesto,Jerarquia,DepartamentoId,UsuarioCreacionId,CreadoEn,ActualizadoEn")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "IdDepartamento", "IdDepartamento", empleado.DepartamentoId);
            ViewData["UsuarioCreacionId"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", empleado.UsuarioCreacionId);
            return View(empleado);
        }

        // GET: Empleadoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "IdDepartamento", "IdDepartamento", empleado.DepartamentoId);
            ViewData["UsuarioCreacionId"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", empleado.UsuarioCreacionId);
            return View(empleado);
        }

        // POST: Empleadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEmpleado,Nombres,Apellidos,DocumentoCui,FechaIngreso,SalarioActual,FechaUltimoAumento,FechaBaja,Puesto,Jerarquia,DepartamentoId,UsuarioCreacionId,CreadoEn,ActualizadoEn")] Empleado empleado)
        {
            if (id != empleado.IdEmpleado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empleado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpleadoExists(empleado.IdEmpleado))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "IdDepartamento", "IdDepartamento", empleado.DepartamentoId);
            ViewData["UsuarioCreacionId"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", empleado.UsuarioCreacionId);
            return View(empleado);
        }

        // GET: Empleadoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleados
                .Include(e => e.Departamento)
                .Include(e => e.UsuarioCreacion)
                .FirstOrDefaultAsync(m => m.IdEmpleado == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // POST: Empleadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado != null)
            {
                _context.Empleados.Remove(empleado);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpleadoExists(int id)
        {
            return _context.Empleados.Any(e => e.IdEmpleado == id);
        }
    }
}

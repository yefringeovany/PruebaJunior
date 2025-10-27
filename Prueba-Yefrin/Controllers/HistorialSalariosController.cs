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
    public class HistorialSalariosController : Controller
    {
        private readonly PruebaDev3Context _context;

        public HistorialSalariosController(PruebaDev3Context context)
        {
            _context = context;
        }

        // GET: HistorialSalarios
        public async Task<IActionResult> Index()
        {
            var pruebaDev3Context = _context.HistorialSalarios.Include(h => h.Empleado).Include(h => h.UsuarioRegistro);
            return View(await pruebaDev3Context.ToListAsync());
        }

        // GET: HistorialSalarios/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialSalario = await _context.HistorialSalarios
                .Include(h => h.Empleado)
                .Include(h => h.UsuarioRegistro)
                .FirstOrDefaultAsync(m => m.IdHistorial == id);
            if (historialSalario == null)
            {
                return NotFound();
            }

            return View(historialSalario);
        }

        // GET: HistorialSalarios/Create
        public IActionResult Create()
        {
            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "IdEmpleado", "IdEmpleado");
            ViewData["UsuarioRegistroId"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario");
            return View();
        }

        // POST: HistorialSalarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdHistorial,EmpleadoId,SalarioAnterior,SalarioNuevo,Motivo,FechaCambio,UsuarioRegistroId,CreadoEn")] HistorialSalario historialSalario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(historialSalario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "IdEmpleado", "IdEmpleado", historialSalario.EmpleadoId);
            ViewData["UsuarioRegistroId"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", historialSalario.UsuarioRegistroId);
            return View(historialSalario);
        }

        // GET: HistorialSalarios/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialSalario = await _context.HistorialSalarios.FindAsync(id);
            if (historialSalario == null)
            {
                return NotFound();
            }
            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "IdEmpleado", "IdEmpleado", historialSalario.EmpleadoId);
            ViewData["UsuarioRegistroId"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", historialSalario.UsuarioRegistroId);
            return View(historialSalario);
        }

        // POST: HistorialSalarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("IdHistorial,EmpleadoId,SalarioAnterior,SalarioNuevo,Motivo,FechaCambio,UsuarioRegistroId,CreadoEn")] HistorialSalario historialSalario)
        {
            if (id != historialSalario.IdHistorial)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historialSalario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistorialSalarioExists(historialSalario.IdHistorial))
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
            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "IdEmpleado", "IdEmpleado", historialSalario.EmpleadoId);
            ViewData["UsuarioRegistroId"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", historialSalario.UsuarioRegistroId);
            return View(historialSalario);
        }

        // GET: HistorialSalarios/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialSalario = await _context.HistorialSalarios
                .Include(h => h.Empleado)
                .Include(h => h.UsuarioRegistro)
                .FirstOrDefaultAsync(m => m.IdHistorial == id);
            if (historialSalario == null)
            {
                return NotFound();
            }

            return View(historialSalario);
        }

        // POST: HistorialSalarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var historialSalario = await _context.HistorialSalarios.FindAsync(id);
            if (historialSalario != null)
            {
                _context.HistorialSalarios.Remove(historialSalario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistorialSalarioExists(long id)
        {
            return _context.HistorialSalarios.Any(e => e.IdHistorial == id);
        }
    }
}

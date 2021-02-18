using Finances.Domain;
using Finances.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finances.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RecordsController : Controller
    {
        private readonly AppDbContext _context;

        public RecordsController(AppDbContext context)
        {
            _context = context;
        }
        // GET: RecordsController
        public ActionResult Index()
        {
            var entityBase = _context.EntityBase.ToList();
            return View(entityBase);
        }

        // GET: RecordsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecordsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecordsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EntityBase entityBase)
        {
            _context.EntityBase.Add(entityBase);
            await _context.SaveChangesAsync();
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecordsController/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id != null)
            {
                EntityBase entityBase = await _context.EntityBase.FirstOrDefaultAsync(p => p.Id == id);
                if (entityBase != null)
                    return View(entityBase);
            }
            return NotFound();
        }

        // POST: RecordsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EntityBase entityBase)
        {
            _context.EntityBase.Update(entityBase);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: RecordsController/Delete/5
        [ActionName("Delete")]        
        public async Task<IActionResult> ConfirmDelete(Guid id)
        {
            if (id != null)
            {
                EntityBase entityBase = await _context.EntityBase.FirstOrDefaultAsync(p => p.Id == id);
                if (entityBase != null)
                    return View(entityBase);
            }
            return NotFound();
        }

        // POST: RecordsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id != null)
            {
                EntityBase entityBase = await _context.EntityBase.FirstOrDefaultAsync(p => p.Id == id);
                if (entityBase != null)
                {
                    _context.EntityBase.Remove(entityBase);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}

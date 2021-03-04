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
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;
        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }
        // GET: CategoriesController
        public ActionResult Index()
        {
            var catergories = _context.Categories.OrderByDescending(p => p.Direction).ToList();
            return View(catergories);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Categories categories)
        {
            _context.Categories.Add(categories);
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

        // GET: CategoriesController/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id != null)
            {
                Categories categories = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);
                if (categories != null)
                    return View(categories);
            }
            return NotFound();
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Categories categories)
        {
            _context.Categories.Update(categories);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: CategoriesController/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(Guid id)
        {
            if (id != null)
            {
                Categories categories = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);
                if (categories != null)
                    return View(categories);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id != null)
            {
                Categories categories = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);
                if (categories != null)
                {
                    _context.Categories.Remove(categories);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}

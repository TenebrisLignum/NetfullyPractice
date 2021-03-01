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

namespace Finances.Controllers
{
    public class FamilyController : Controller
    {
        private readonly AppDbContext _context;
        public FamilyController(AppDbContext context)
        {
            _context = context;
        }
        // GET: FamiliesController
        public ActionResult Index()
        {
            var family = _context.Family.OrderByDescending(p => p.Name).ToList();
            return View(family);
        }

        // GET: FamiliesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FamiliesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamiliesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Family family)
        {
            _context.Family.Add(family);
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

        // GET: FamiliesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FamiliesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FamiliesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FamiliesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

using Finances.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult Create(IFormCollection collection)
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

        // GET: RecordsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecordsController/Edit/5
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

        // GET: RecordsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecordsController/Delete/5
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

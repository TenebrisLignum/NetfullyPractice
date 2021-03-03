using Finances.Domain;
using Finances.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finances.Controllers
{
    public class FamilyRecordsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public FamilyRecordsController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: HomeController1
        public ActionResult Index(string familyId)
        {
            var entityBase = from m in _context.EntityBase select m;
            entityBase = entityBase.Where(s => s.Family.Contains(familyId));
            ViewBag.familyId = familyId;
            return View(entityBase.OrderByDescending(p => p.DateAdded).ToList());
        }

        // GET: HomeController1/Details/5
        public async Task<IActionResult> Details(Guid id, string familyId)
        {
            ViewBag.familyId = familyId;
            if (id != null)
            {
                EntityBase entityBase = await _context.EntityBase.FirstOrDefaultAsync(p => p.Id == id);
                if (entityBase != null)
                    return View(entityBase);
            }            
            return NotFound();
        }

        // GET: HomeController1/Create
        public ActionResult Create(string familyId)
        {
            ViewBag.familyId = familyId;
            var entityBase = new EntityBase();
            List<Categories> categories = _context.Categories.ToList();
            List<Categories> ctgModels = categories
                .Select(c => new Categories { Id = c.Id, Name = c.Name })
                .ToList();
            IndexViewModel ivm = new IndexViewModel { EntityBase = entityBase, Categories = ctgModels };
            ViewBag.CategoriesList = new SelectList(ctgModels, "Name", "Name");
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EntityBase entityBase, string familyId)
        {
            ViewBag.familyId = familyId;
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            entityBase.TheUser = Convert.ToString(user);
            _context.EntityBase.Add(entityBase);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { familyId = familyId });
        }

        // GET: HomeController1/Edit/5
        public async Task<IActionResult> Edit(Guid id, string familyId)
        {
            ViewBag.familyId = familyId;
            if (id != null)
            {
                EntityBase entityBase = await _context.EntityBase.FirstOrDefaultAsync(p => p.Id == id);
                List<Categories> categories = _context.Categories.ToList();
                List<Categories> ctgModels = categories
                    .Select(c => new Categories { Id = c.Id, Name = c.Name })
                    .ToList();
                IndexViewModel ivm = new IndexViewModel { EntityBase = entityBase, Categories = ctgModels };
                ViewBag.CategoriesList = new SelectList(ctgModels, "Name", "Name");
                if (entityBase != null)
                    return View(ivm);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EntityBase entityBase, string familyId)
        {
            ViewBag.familyId = familyId;
            _context.EntityBase.Update(entityBase);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { familyId = familyId });
        }

        // GET: HomeController1/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(Guid id, string familyId)
        {
            ViewBag.familyId = familyId;
            if (id != null)
            {
                EntityBase entityBase = await _context.EntityBase.FirstOrDefaultAsync(p => p.Id == id);
                if (entityBase != null)
                    return View(entityBase);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id, string familyId)
        {
            ViewBag.familyId = familyId;
            if (id != null)
            {
                EntityBase entityBase = await _context.EntityBase.FirstOrDefaultAsync(p => p.Id == id);
                if (entityBase != null)
                {
                    _context.EntityBase.Remove(entityBase);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", new { familyId = familyId }    );
                }
            }
            return NotFound();
        }
    }
}

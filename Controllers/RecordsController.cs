using Finances.Domain;
using Finances.Domain.Entities;
using Finances.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finances.Areas.Admin.Controllers
{
    public class RecordsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public RecordsController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 10;
            var entityBase = from m in _context.EntityBase select m;
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            entityBase = entityBase.Where(s => s.TheUser.Contains(user.UserName));
            entityBase = entityBase.Where(s => s.Family.Contains("noFamily")).OrderByDescending(p => p.DateAdded);

            var count = await entityBase.CountAsync();
            var items = await entityBase.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            PageIndexViewModel viewModel = new PageIndexViewModel
            {
                PageViewModel = pageViewModel,
                EntityBases = items
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> OrdersByDate(DateTime date, int page = 1)
        {
            int pageSize = 10;
            ViewBag.date = date;
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var entityBase = from m in _context.EntityBase select m;
            var allOrdersByDate = entityBase
                .Where(s => s.TheUser.Contains(user.UserName))
                .Where(s => s.Family.Contains("noFamily"))
                .Where(a => a.DateAdded.Year == date.Year)
                .Where(a => a.DateAdded.Month == date.Month)
                .Where(a => a.DateAdded.Day == date.Day)
                .OrderByDescending(p => p.DateAdded);

            var count = await allOrdersByDate.CountAsync();
            var items = await allOrdersByDate.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            PageIndexViewModel viewModel = new PageIndexViewModel
            {
                PageViewModel = pageViewModel,
                EntityBases = items
            };
            return View(viewModel);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            if (id != null)
            {
                EntityBase entityBase = await _context.EntityBase.FirstOrDefaultAsync(p => p.Id == id);
                if (entityBase != null)
                    return View(entityBase);
            }
            return NotFound();
        }

        public ActionResult Create()
        {
            var entityBase = new EntityBase();
            List<Categories> categories = _context.Categories.ToList();
            List<Categories> ctgModelsTrue = categories
                .Select(c => new Categories { Id = c.Id, Name = c.Name, Direction = c.Direction }).Where(c => c.Direction.Equals(true)).ToList();
            List<Categories> ctgModelsFalse = categories
                .Select(c => new Categories { Id = c.Id, Name = c.Name, Direction = c.Direction }).Where(c => c.Direction.Equals(false)).ToList();
            ViewBag.CategoriesList = new SelectList(categories, "Name", "Name");
            ViewBag.CategoriesListTrue = new SelectList(ctgModelsTrue, "Name", "Name");
            ViewBag.CategoriesListFalse = new SelectList(ctgModelsFalse, "Name", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EntityBase entityBase)
        {
            if (entityBase.DateAdded == DateTime.MinValue)
            {
                entityBase.DateAdded = DateTime.Now;
            }
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

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id != null)
            {
                List<Categories> categories = _context.Categories.ToList();
                ViewBag.CategoriesList = new SelectList(categories, "Name", "Name");
                EntityBase entityBase = await _context.EntityBase.FirstOrDefaultAsync(p => p.Id == id);
                IndexViewModel ivm = new IndexViewModel { EntityBase = entityBase, Categories = categories };
                if (entityBase != null)
                    return View(ivm);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EntityBase entityBase)
        {
            _context.EntityBase.Update(entityBase);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

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

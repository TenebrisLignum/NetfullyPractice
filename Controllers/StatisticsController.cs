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

namespace Finances.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public StatisticsController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: StatisticsController
        public async Task<IActionResult> Index(StatisticsViewModel svm)
        {
            svm.entityBase = from m in _context.EntityBase select m;
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            svm.entityBase = svm.entityBase
                .Where(s => s.TheUser.Contains(user.UserName))
                .Where(s => s.Family.Contains("noFamily"))
                .OrderBy(s => s.DateAdded);

            EntityBase FirstEB = svm.entityBase.First();
            DateTime dtStart = FirstEB.DateAdded;
            DateTime dtEnd = DateTime.Now.AddDays(1);
            int i = 0;
            svm.cash[0] = new float[8];
            svm.cash[1] = new float[8];
            while (dtStart < dtEnd)
            {               
                var entityBaseToday = svm.entityBase
                    .Where(a => a.DateAdded.Year == dtStart.Year)
                    .Where(a => a.DateAdded.Month == dtStart.Month)
                    .Where(a => a.DateAdded.Day == dtStart.Day);
                foreach(var item in entityBaseToday)
                {
                    if (item.Direction == true)
                    {
                        svm.cash[0][i] += item.Amount;
                    }
                    else
                    {
                        svm.cash[1][i] += item.Amount;
                    }
                }
                svm.dates[i] = dtStart.ToString("dd/MM/yyyy");
                dtStart = dtStart.AddDays(1);
                i++;
            }
            ViewData["Nums"] = svm.cash;
            ViewData["Labels"] = svm.dates;
            ViewBag.CategoriesListTrue = _context.Categories.Where(p => p.Direction == true).ToList();
            ViewBag.CategoriesListFalse = _context.Categories.Where(p => p.Direction == false).ToList();
            return View(svm);
        }

        // GET: StatisticsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatisticsController/Create
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

        // GET: StatisticsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StatisticsController/Edit/5
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

        // GET: StatisticsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StatisticsController/Delete/5
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

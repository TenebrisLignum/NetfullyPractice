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
            if (svm.DateSearch == "Тиждень")
            {
                svm.DateSearchDate = DateTime.Now.AddDays(-7);
            }
            if (svm.DateSearch == "Місяць")
            {
                svm.DateSearchDate = DateTime.Now.AddMonths(-1);
            }
            if (svm.DateSearch == "Рік")
            {
                svm.DateSearchDate = DateTime.Now.AddYears(-1);
            }
            svm.entityBase = from m in _context.EntityBase select m;
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);

            var familyUser = from m in _context.FamilyUser select m;
            familyUser = familyUser.Where(p => p.UserId.Contains(user.Id));
            var family = _context.Family
                .Where(p => familyUser
                .Select(p => p.FamilyId)
                .Contains(p.Id));
            ViewBag.FamiliesList = new SelectList(family, "Id", "Name");

            if (svm.FamilySearch != null && svm.FamilySearch != "noFamily")
            {
                svm.entityBase = svm.entityBase.Where(s => s.Family.Contains(svm.FamilySearch)).OrderBy(s => s.DateAdded);
            }
            else
            {
                svm.entityBase = svm.entityBase
                .Where(s => s.TheUser.Contains(user.UserName))
                .Where(s => s.Family.Contains("noFamily"))
                .OrderBy(s => s.DateAdded);
            }
             
            var CategoriesListTrue = _context.Categories.Where(p => p.Direction == true).ToList();
            var CategoriesListFalse = _context.Categories.Where(p => p.Direction == false).ToList();
            Dictionary<string, float> categoriesTrue = new Dictionary<string, float>(CategoriesListTrue.Count);
            Dictionary<string, float> categoriesFalse = new Dictionary<string, float>(CategoriesListFalse.Count);

            foreach (var j in CategoriesListTrue)
            {
                categoriesTrue.Add(j.Name, 0);
            }
            foreach (var j in CategoriesListFalse)
            {
                categoriesFalse.Add(j.Name, 0);
            }

            DateTime dtStart;
            if (svm.DateSearch == null || svm.DateSearch == "ВесьЧас")
            {
                EntityBase FirstEB = svm.entityBase.First();
                dtStart = FirstEB.DateAdded.Date;
            }
            else
            {
                dtStart = svm.DateSearchDate.Date;
            }
            
            DateTime dtEnd = DateTime.Now.Date;
            svm.arraylength = (int)(dtEnd - dtStart).TotalDays + 1;
            int i = 0;
            svm.cash[0] = new float[svm.arraylength];
            svm.cash[1] = new float[svm.arraylength];
            svm.dates = new string[svm.arraylength];
            while (dtStart <= dtEnd)
            {
                var entityBaseToday = svm.entityBase
                    .Where(a => a.DateAdded.Year == dtStart.Year)
                    .Where(a => a.DateAdded.Month == dtStart.Month)
                    .Where(a => a.DateAdded.Day == dtStart.Day);
                foreach (var item in entityBaseToday)
                {
                    if (item.Direction == true)
                    {
                        svm.cash[0][i] += item.Amount;
                        svm.earned += item.Amount;
                        categoriesTrue[item.Category] += item.Amount;
                    }
                    else
                    {
                        svm.cash[1][i] += item.Amount;
                        svm.spent += item.Amount;
                        categoriesFalse[item.Category] += item.Amount;
                    }
                }
                svm.dates[i] = dtStart.ToString("dd/MM/yyyy");
                dtStart = dtStart.AddDays(1);
                i++;
            }
            ViewData["Nums"] = svm.cash;
            ViewData["Labels"] = svm.dates;
            ViewBag.categoriesTrue = categoriesTrue.OrderByDescending(p => p.Value);
            ViewBag.categoriesFalse = categoriesFalse.OrderByDescending(p => p.Value);
            return View(svm);
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
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
    public class FamilyController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public FamilyController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: FamiliesController
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var familyUser = from m in _context.FamilyUser select m;
            familyUser = familyUser.Where(p => p.UserId.Contains(user.Id));
            var family = _context.Family.Where(p => familyUser.Select(p => p.FamilyId).Contains(p.Id));
            return View(family);
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
            family.Id = Guid.NewGuid().ToString();
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            _context.FamilyUser.Add(new FamilyUser { UserId = user.Id, FamilyId = family.Id });
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
        public async Task<IActionResult> Edit(string id)
        {
            if (id != null)
            {
                Family family = await _context.Family.Include(x => x.FamilyUser).ThenInclude(x => x.User).FirstOrDefaultAsync(p => p.Id == id);
                if (family != null)
                    return View(family);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Family family)
        {
            _context.Family.Update(family);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AddUser(string searchString, string familyId)
        {
            var users = from m in _context.User select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.UserName.Contains(searchString));
            }
            ViewBag.familyid = familyId;
            return View(await users.OrderBy(p => p.UserName).ToListAsync());
        }

        // POST: FamiliesController/AddUser
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddUserToFamily(string userId, string familyId)
        {
            _context.FamilyUser.Add(new FamilyUser { UserId = userId, FamilyId = familyId });
            _context.SaveChanges();            

            return RedirectToAction("Index");
        }

        // GET: FamiliesController/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id != null)
            {
                Family family = await _context.Family.Include(x => x.FamilyUser).ThenInclude(x => x.User).FirstOrDefaultAsync(p => p.Id == id);
                if (family != null)
                    return View(family);
            }
            return NotFound();
        }        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUserFromFamily(string familyId, string userId)
        {
            if (userId != null)
            {
                FamilyUser familyUser = await _context.FamilyUser.SingleAsync(p => p.FamilyId == familyId && p.User.Id == userId);
                if (userId != null)
                {
                    _context.FamilyUser.Remove(familyUser);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        // GET: FamiliesController/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(string id)
        {
            if (id != null)
            {
                Family family = await _context.Family.FirstOrDefaultAsync(p => p.Id == id);
                if (family != null)
                    return View(family);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            if (id != null)
            {
                Family family = await _context.Family.FirstOrDefaultAsync(p => p.Id == id);
                if (family != null)
                {
                    _context.Family.Remove(family);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}

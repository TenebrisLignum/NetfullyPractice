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
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            var user = _context.User.OrderByDescending(p => p.UserName).ToList();
            return View(user);
        }

        // GET: UserController/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id != null)
            {
                User user = await _context.User.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }

        // GET: UserController/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id != null)
            {
                User user = await _context.User.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(User user)
        {
            User userUpdate = await _context.User.FirstOrDefaultAsync(p => p.Id == user.Id);
            userUpdate.UserName = user.UserName;
            userUpdate.Email = user.Email;
            _context.User.Update(userUpdate);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(string id)
        {
            if (id != null)
            {
                User user = await _context.User.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            if (id != null)
            {
                User user = await _context.User.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                {
                    _context.User.Remove(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}

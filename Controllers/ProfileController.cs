using Finances.Domain;
using Finances.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Threading.Tasks;

namespace Finances.Controllers
{
    public class ProfileController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public ProfileController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: ProfileController
        public async Task<IActionResult> Index(string userName)
        {
            User user = (User)await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            if (userName != null)
            {
                user = await _context.User.FirstOrDefaultAsync(p => p.UserName == userName);
            }
            return View(user);
        }

        // GET: ProfileController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfileController/Create
        public ActionResult UploadPicture()
        {
            return View();
        }

        // POST: ProfileController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadPicture(PictureViewModel pvm)
        {
            pvm.user = (User)await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            if (pvm.Avatar != null)
            {
                byte[] imageData = null;
                using (var binaryReader = new BinaryReader(pvm.Avatar.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)pvm.Avatar.Length);
                }
                pvm.user.Avatar = imageData;
            }
            _context.User.Update(pvm.user);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: ProfileController/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id != null)
            {
                var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            User userUpdate = (User)await _userManager.FindByNameAsync(HttpContext.User.Identity.Name); ;
            userUpdate.UserName = user.UserName;
            userUpdate.FirstName = user.FirstName;
            userUpdate.LastName = user.LastName;
            userUpdate.Email = user.Email;
            userUpdate.DateAdded = user.DateAdded;
            userUpdate.PhoneNumber = user.PhoneNumber;
            _context.User.Update(userUpdate);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: ProfileController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfileController/Delete/5
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

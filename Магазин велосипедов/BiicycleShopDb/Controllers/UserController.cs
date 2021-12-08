using BiicycleShopDb.Models;
using BiicycleShopDb.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiicycleShopDb.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> userManager;
        public UserController(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(userManager.Users.ToList());
        }
        public IActionResult CreateNew()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> CreateNew(RegisterViewModel model)
        {
            User newUser = new User { Email = model.Email, UserName = model.Email, Year = model.Year };
            IdentityResult result = await userManager.CreateAsync(newUser);
           
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "User");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> DeleteUser(string Id)
        {
            User user =  userManager.Users.FirstOrDefault(x => x.Id == Id);

            IdentityResult result = await userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "User");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}

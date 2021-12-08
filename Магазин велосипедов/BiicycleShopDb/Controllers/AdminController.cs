using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BiicycleShopDb.Models;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Authorization;

namespace BiicycleShopDb.Controllers
{
   
    [Authorize]
    public class AdminController : Controller
    {
        BicycleContext context;
        UserContext contextUser;
        public AdminController(BicycleContext context, UserContext contextUser)
        {
            this.context = context;
            this.contextUser = contextUser;
        }

        public async Task< IActionResult> Index(int page = 1)
        {
            ViewBag.Page = page;
            var query = context.Bicycle.AsNoTracking().OrderBy(p => p.Prise);
            var model = await PagingList.CreateAsync(query, 6, page);
            return View(model);
        }
        public IActionResult Create(int? id)
        {
            var bicycleToEdit = context.Bicycle.Find(id);
            return View(bicycleToEdit);
        }

        [HttpPost]
        public IActionResult Create(Bicycle bicycle)
        {
            if (bicycle.Title == null && bicycle.Class == null && bicycle.Clolor == null && bicycle.Wheel_Diameter < 1 && bicycle.Number_Speeds < 1 && bicycle.Frame == null && bicycle.Frame_Material == null && bicycle.Img_Url == null && bicycle.Prise < 3000)
            {
                return View(bicycle);
                
            }
            else
            {
                if (bicycle.BicycleId == 0)
                {
                    context.Bicycle.Add(bicycle);
                }
                else
                {
                    var bicycleToEdit = context.Bicycle.FirstOrDefault(x => x.BicycleId == x.BicycleId);
                    bicycleToEdit.Title = bicycle.Title;
                    bicycleToEdit.Class = bicycle.Class;
                    bicycleToEdit.Clolor = bicycle.Clolor;
                    bicycleToEdit.Frame = bicycle.Frame;
                    bicycleToEdit.Frame_Material = bicycle.Frame_Material;
                    bicycleToEdit.Number_Speeds = bicycle.Number_Speeds;
                    bicycleToEdit.Prise = bicycle.Prise;
                    bicycleToEdit.Wheel_Diameter = bicycle.Wheel_Diameter;
                    bicycleToEdit.Img_Url = bicycle.Img_Url;
                }
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Remove(int BicycleId)
        {
            context.Bicycle.Remove(context.Bicycle.Find(BicycleId));
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        /*public IActionResult RoleAdmin(int UserId)
        {
            User userToChange = contextUser.Users.Find(UserId);
            Role userRole = contextUser.Roles.FirstOrDefault(x => x.Name == "admin");
            if (userRole != null)
            {
                userToChange.Role = userRole;
            }
            contextUser.SaveChanges();
            return RedirectToAction("Index");
        }*/

        public IActionResult ChangeRole()
        {
            return View(contextUser.Users.ToList());
        }

    }
}

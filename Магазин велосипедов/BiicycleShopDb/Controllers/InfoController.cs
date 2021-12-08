using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BiicycleShopDb.Models;
using Microsoft.AspNetCore.Authorization;

namespace BiicycleShopDb.Controllers
{
    [AllowAnonymous]
    public class InfoController : Controller
    {
        BicycleContext context;
        public InfoController(BicycleContext context)
        {
            this.context = context;
        }

        public IActionResult Index(int id)
        {
            Bicycle bicycleShow = context.Bicycle.Find(id);
            ViewBag.BicycleId = id;
            return View(bicycleShow);
        }

    }
}

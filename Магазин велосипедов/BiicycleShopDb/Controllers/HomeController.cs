using BiicycleShopDb.Extensions;
using BiicycleShopDb.Models;
using BiicycleShopDb.Serises;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ReflectionIT.Mvc.Paging;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BiicycleShopDb.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {

        BicycleContext context;
        public HomeController(BicycleContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index(string text, int page = 1)
        {
            ViewBag.Message_By = text;
            var query = context.Bicycle.AsNoTracking().OrderBy(p => p.Prise);
            var model = await PagingList.CreateAsync(query, 6, page);
            return View(model);
        }

        /*[HttpPost]
        public IActionResult Index(Order order)
        {

            return View(context.Bicycle.ToList());
        }*/

        public IActionResult Buy(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.BicycleId = id;
           
            return View();
        }
        

        [HttpPost]
        public  IActionResult Buy(Order order)
        {
            if (ModelState.IsValid)
            {
                string message_mail = "";

                context.Order.Add(order);
                context.SaveChanges();

                message_mail = $"Спасибо {order.Name} за заказ велосипеда!\nВаш номер заказа {order.OrderId}\nСпасибо что выбрали нас!";

                ServisMail.SendMessage(message_mail, order.Email);
               
               
                Bicycle bicycle = context.Bicycle.FirstOrDefault(x => x.BicycleId == order.BicycleId);
                Cart cart = GetCart();
                cart.RemoveLine(bicycle);
                HttpContext.Session.SetObjectAsJson("Cart", cart);

                return RedirectToAction("Index", new { text = $"Спасибо {order.Name} за заказ!" });
                
            }
            else
            {
                return View(order);
            }
        }
        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetObjectFromJson<Cart>("Cart");
            if (cart == null)
            {
                cart = new Cart();
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return cart;
        }

    }
}

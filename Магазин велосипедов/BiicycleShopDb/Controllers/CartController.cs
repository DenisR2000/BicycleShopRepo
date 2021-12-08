using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BiicycleShopDb.Models;
using BiicycleShopDb.Models.ViewModels;
using BiicycleShopDb.Extensions;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Authorization;

namespace BiicycleShopDb.Controllers
{
    
    [AllowAnonymous]
    public class CartController : Controller
    {
        BicycleContext context;
        public CartController(BicycleContext context)
        {
            this.context = context;
        }

        public IActionResult Index(string returnUrl)
        {
           
            return View(new CartIndexViewModel
            { 
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public IActionResult AddToCart(int BicycleId, string returnUrl)
        {
            Bicycle bicycle = context.Bicycle.FirstOrDefault(x => x.BicycleId == BicycleId);
            if(bicycle != null)
            {
                var cart = GetCart();
                cart.AddItem(bicycle, 1);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult RemoveFromCart(int BicycleId, string returnUrl)
        {
            Bicycle bicycle = context.Bicycle.FirstOrDefault(x => x.BicycleId == BicycleId);
            if(bicycle != null)
            {
                Cart cart = GetCart();
                cart.RemoveLine(bicycle);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult ClearCart(string returnUrl)
        {
            Cart cart = GetCart();

            cart.Clear();
            
            HttpContext.Session.SetObjectAsJson("Cart", cart);

            return RedirectToAction("Index", new { returnUrl });
        }
      

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetObjectFromJson<Cart>("Cart");
            if(cart == null)
            {
                cart = new Cart();
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return cart;
        }
    }
}

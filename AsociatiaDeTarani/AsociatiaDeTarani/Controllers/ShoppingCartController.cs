using AsociatiaDeTarani.Helpers;
using AsociatiaDeTarani.Models;
using AsociatiaDeTarani.Repositories;
using AsociatiaDeTarani.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IGenericRepository<Product> _repository;

        public ShoppingCartController(IGenericRepository<Product> repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/shoppingCartItems")]
        public IEnumerable<ShoppingCartItem> GetShoppingCartItems()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");

            return cart;
        }

        public RedirectToActionResult AddProduct(int productId)
        {
            Product productModel = _repository.GetByCondition(p => p.ProductId == productId).FirstOrDefault();

            if (SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart") == null)
            {
                List<ShoppingCartItem> cart = new List<ShoppingCartItem>();
                cart.Add(new ShoppingCartItem { Product = productModel, Amount = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
                int index = GetItemIndex(productId);
                if (index != -1)
                {
                    cart[index].Amount++;
                }
                else
                {
                    cart.Add(new ShoppingCartItem { Product = productModel, Amount = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }

            return RedirectToAction("Index", "Client");
        }

        [HttpDelete]
        [Route("/shoppingCartItems")]
        public void Remove(ShoppingCartItem item)
        {
            List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
            int index = GetItemIndex(item.Product.ProductId);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
        }

        [HttpPut]
        [Route("/shoppingCartItems")]
        public void UpdateAmount(ShoppingCartItem item)
        {
            List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
            int index = GetItemIndex(item.Product.ProductId);
            cart[index].Amount = item.Amount;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
        }

        private int GetItemIndex(int id)
        {
            List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

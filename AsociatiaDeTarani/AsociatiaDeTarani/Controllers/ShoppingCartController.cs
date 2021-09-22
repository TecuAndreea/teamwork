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
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<Producer> _producerRepository;

        public ShoppingCartController(IGenericRepository<Product> productRepository, IGenericRepository<Producer> producerRepository)
        {
            _productRepository = productRepository;
            _producerRepository = producerRepository;
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
            Product productModel = _productRepository.GetByCondition(p => p.ProductId == productId).FirstOrDefault();

            if (SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart") == null)
            {
                List<ShoppingCartItem> cart = new List<ShoppingCartItem>();
                cart.Add(new ShoppingCartItem { Product = productModel, Amount = 1, Price = productModel.Price });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
                int index = GetItemIndex(productId);
                if (index != -1)
                {
                    cart[index].Amount++;
                    cart[index].Price = cart[index].Product.Price * cart[index].Amount;
                }
                else
                {
                    cart.Add(new ShoppingCartItem { Product = productModel, Amount = 1, Price = productModel.Price });
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
            cart[index].Price = item.Amount * item.Product.Price;
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

        [HttpGet]
        [Route("/shoppingCartItems/total")]
        public double GetTotalCart()
        {
            double total = 0;

            if (SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart") != null)
            {
                List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
                total = cart.Select(i => i.Price).Sum();
            }

            return total;
        }

        private void AddProducer(int producerId)
        {
            Producer producerModel = _producerRepository.GetByCondition(p => p.ProducerId == producerId).FirstOrDefault();

            if (SessionHelper.GetObjectFromJson<List<Producer>>(HttpContext.Session, "producers") == null)
            {
                List<Producer> producers = new List<Producer>();
                producers.Add(producerModel);
                SessionHelper.SetObjectAsJson(HttpContext.Session, "producers", producers);
            }
            else
            {
                List<Producer> producers = SessionHelper.GetObjectFromJson<List<Producer>>(HttpContext.Session, "producers");
                if (!producers.Contains(producerModel))
                {
                    producers.Add(producerModel);
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "producers", producers);
            }
        }

        public bool IsValidForOrder()
        {

            return true;
        }
    }
}

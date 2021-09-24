using AsociatiaDeTarani.Helpers;
using AsociatiaDeTarani.Models;
using AsociatiaDeTarani.Repositories;
using AsociatiaDeTarani.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            TempData["totalShowed"] = GetTotalCart().ToString();
            TempData["total"] = GetTotalCart().ToString();
            ViewData["total"] = GetTotalCart().ToString();

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

            AddProducer(productModel.ProducerId,productModel.Price);

            return RedirectToAction("Index", "Client");
        }

        [HttpPut]
        [Route("/shoppingCartItems")]
        public ShoppingCartItem UpdateAmount(ShoppingCartItem item)
        {
            List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
            int index = GetItemIndex(item.Product.ProductId);
            double lastAmount = cart[index].Price;
            cart[index].Amount = item.Amount;
            cart[index].Price = item.Amount * item.Product.Price;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            UpdateProducerItemsCount(cart[index], lastAmount);
            return cart[index];
        }

        [HttpDelete]
        [Route("/shoppingCartItems")]
        public void Remove(ShoppingCartItem item)
        {
            List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
            int index = GetItemIndex(item.Product.ProductId);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            double lastAmount = item.Price;
            item.Amount = 0;
            item.Price = 0;
            UpdateProducerItemsCount(item, lastAmount);
            RemoveProducer(item.Product.ProducerId);
        }

        private void AddProducer(int producerId,double sum)
        {
            Producer producerModel = _producerRepository.GetByCondition(p => p.ProducerId == producerId).FirstOrDefault();

            if (SessionHelper.GetObjectFromJson<List<ProducerShoppingCartItemCount>>(HttpContext.Session, "producersItemsCount") == null)
            {
                List<ProducerShoppingCartItemCount> producersItemsCount = new List<ProducerShoppingCartItemCount>();
                producersItemsCount.Add(new ProducerShoppingCartItemCount { Producer = producerModel, ItemsTotalPrice = sum });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "producersItemsCount", producersItemsCount);
            }
            else
            {
                List<ProducerShoppingCartItemCount> producersItemsCount = SessionHelper.GetObjectFromJson<List<ProducerShoppingCartItemCount>>(HttpContext.Session, "producersItemsCount");
                int index = GetProducerItemsTotalPrice(producerId);
                if (index != -1)
                {
                    producersItemsCount[index].ItemsTotalPrice+=sum;
                }
                else
                {
                    producersItemsCount.Add(new ProducerShoppingCartItemCount { Producer = producerModel, ItemsTotalPrice = sum });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "producersItemsCount", producersItemsCount);
            }
        }

        private void UpdateProducerItemsCount(ShoppingCartItem item, double lastAmount)
        {
            List<ProducerShoppingCartItemCount> producersItemsCount = SessionHelper.GetObjectFromJson<List<ProducerShoppingCartItemCount>>(HttpContext.Session, "producersItemsCount");
            int index = GetProducerItemsTotalPrice(item.Product.ProducerId);
            producersItemsCount[index].ItemsTotalPrice = producersItemsCount[index].ItemsTotalPrice - lastAmount + item.Price;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "producersItemsCount", producersItemsCount);
        }

        private void RemoveProducer(int producerId)
        {
            List<ProducerShoppingCartItemCount> producersItemsCount = SessionHelper.GetObjectFromJson<List<ProducerShoppingCartItemCount>>(HttpContext.Session, "producersItemsCount");
            int index = GetProducerItemsTotalPrice(producerId);
            if (producersItemsCount[index].ItemsTotalPrice == 0)
            {
                producersItemsCount.RemoveAt(index);
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "producersItemsCount", producersItemsCount);
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

            total += GetTotalDelivery();


            return total;
        }

        [HttpGet]
        [Route("/shoppingCartItems/deliveryPerProducer")]
        public List<Producer> GetDeliveryPerProducer()
        {
            List<Producer> producers = new();
            List<ProducerShoppingCartItemCount> producersItemsCount = SessionHelper.GetObjectFromJson<List<ProducerShoppingCartItemCount>>(HttpContext.Session, "producersItemsCount");

            if (producersItemsCount != null)
            {
                foreach (var producerItemsCount in producersItemsCount)
                {
                    producers.Add(producerItemsCount.Producer);
                }
            }

            return producers;
        }

        [HttpGet]
        [Route("/shoppingCartItems/validOrder")]
        public bool IsValidForOrder()
        {
            List<ProducerShoppingCartItemCount> producersItemsCount = SessionHelper.GetObjectFromJson<List<ProducerShoppingCartItemCount>>(HttpContext.Session, "producersItemsCount");
            List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
            if (producersItemsCount != null && cart!=null)
            {
                foreach (var producerItemsCount in producersItemsCount)
                {
                    if (producerItemsCount.ItemsTotalPrice < producerItemsCount.Producer.MinimumOrder)
                    {
                        return false;
                    }
                }
                foreach(var item in cart)
                {
                    if(item.Amount>item.Product.AvailableStock)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
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

        private int GetProducerItemsTotalPrice(int id)
        {
            List<ProducerShoppingCartItemCount> producersItemsCount = SessionHelper.GetObjectFromJson<List<ProducerShoppingCartItemCount>>(HttpContext.Session, "producersItemsCount");
            for (int i = 0; i < producersItemsCount.Count; i++)
            {
                if (producersItemsCount[i].Producer.ProducerId == id)
                {
                    return i;
                }
            }
            return -1;
        }

        private double GetTotalDelivery()
        {
            double totalDelivery = 0;

            List<ProducerShoppingCartItemCount> producersItemsCount = SessionHelper.GetObjectFromJson<List<ProducerShoppingCartItemCount>>(HttpContext.Session, "producersItemsCount");
            if (producersItemsCount != null)
            {
                foreach (var producerItemsCount in producersItemsCount)
                {
                    totalDelivery += producerItemsCount.Producer.DeliveryCost;
                }
            }

            return totalDelivery;
        }
    }
}

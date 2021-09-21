using AsociatiaDeTarani.Models;
using AsociatiaDeTarani.Repositories;
using AsociatiaDeTarani.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Controllers
{
    public class ShoppingCartController: Controller
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
            return ShoppingCartViewModel.ShoppingCartItems;
        }

        public RedirectToActionResult AddProduct(int productId)
        {
            ShoppingCartViewModel.AddItemToCart(_repository.GetByCondition(p => p.ProductId == productId).FirstOrDefault());
            return RedirectToAction("Index","Client");
        }
    }
}

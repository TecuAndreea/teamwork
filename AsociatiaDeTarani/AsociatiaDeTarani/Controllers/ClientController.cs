using AsociatiaDeTarani.Models;
using AsociatiaDeTarani.Repositories;
using AsociatiaDeTarani.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AsociatiaDeTarani.Controllers
{
    public class ClientController : Controller
    {
        private readonly IGenericRepository<Product> _productRepository;

        public ClientController(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new ProductsListViewModel
            {
                Products = _productRepository.GetAll()
            };

            return View(homeViewModel);
        }
    }
}

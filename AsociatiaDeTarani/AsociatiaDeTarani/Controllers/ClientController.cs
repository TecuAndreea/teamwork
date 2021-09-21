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
        private readonly IGenericRepository<Producer> _producerRepository;

        public ClientController(IGenericRepository<Product> productRepository, IGenericRepository<Producer> producerRepository)
        {
            _productRepository = productRepository;
            _producerRepository = producerRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new ProductsAndProducersListViewModel
            {
                Products = _productRepository.GetAll(),
                Producers = _producerRepository.GetAll()
            };

            return View(homeViewModel);
        }
    }
}

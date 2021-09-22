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
        public IActionResult Index(string searchTerm, string filterTerm)
        {
            if (!string.IsNullOrEmpty(searchTerm))
            {
                if (!string.IsNullOrEmpty(filterTerm) && filterTerm != "default")
                {
                    var foundProducts = new ProductsAndProducersListViewModel
                    {
                        Products = _productRepository.GetByCondition(e => e.Name.Contains(searchTerm) && e.Producer.Name.Contains(filterTerm)),
                        Producers = _producerRepository.GetAll()
                    };
                    return View(foundProducts);
                }
                else
                {
                    var foundProducts = new ProductsAndProducersListViewModel
                    {
                        Products = _productRepository.GetByCondition(e => e.Name.Contains(searchTerm)),
                        Producers = _producerRepository.GetAll()
                    };
                    return View(foundProducts);
                }
            }

            if (!string.IsNullOrEmpty(filterTerm) && filterTerm != "default")
            {
                var foundProducts = new ProductsAndProducersListViewModel
                {
                    Products = _productRepository.GetByCondition(e => e.Producer.Name.Contains(filterTerm)),
                    Producers = _producerRepository.GetAll()
                };
                return View(foundProducts);
            }
            var homeViewModel = new ProductsAndProducersListViewModel
            {
                Products = _productRepository.GetAll(),
                Producers = _producerRepository.GetAll()
            };
            return View(homeViewModel);

        }
    }
}
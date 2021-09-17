using AsociatiaDeTarani.Models;
using AsociatiaDeTarani.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Controllers
{
    public class ProductController: Controller
    {
        private readonly IGenericRepository<Product> _productRepository;

        public ProductController(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/products/{id}")]
        public IEnumerable<Product> GetAllProducts([FromRoute]int id)
        {
            return _productRepository.GetByCondition(p => p.ProducerId == id);
        }

        [HttpPost]
        [Route("/products/{id}")]
        public void InsertProduct([FromRoute]int id,Product product)
        {
            product.ProducerId=id;
            _productRepository.Insert(product);
        }

        [HttpPut]
        [Route("/products")]
        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
        }
    }
}

using AsociatiaDeTarani.Models;
using AsociatiaDeTarani.Repositories;
using AsociatiaDeTarani.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<Producer> _producerRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IGenericRepository<Product> productRepository, IWebHostEnvironment webHostEnvironment, IGenericRepository<Producer> producerRepository)
        {
            _productRepository = productRepository;
            _webHostEnvironment = webHostEnvironment;
            _producerRepository = producerRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New()
        {
            return View();
        }

        [HttpGet]
        [Route("/products/{id}")]
        public IEnumerable<Product> GetAllProducts([FromRoute] int id)
        {
            return _productRepository.GetByCondition(p => p.ProducerId == id);
        }

        [HttpPost]
        [Route("/products/{id}")]
        public void InsertProduct([FromRoute] int id, Product product)
        {
            product.ProducerId = id;
            _productRepository.Insert(product);
        }

        [HttpDelete]
        [Route("/products")]
        public void DeleteProduct(Product product)
        {
            _productRepository.Delete(product);
        }

        [HttpPut]
        [Route("/products")]
        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Product/New/{producerId}")]
        public IActionResult New([FromRoute] int producerId, ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                string producerName = _producerRepository.GetByCondition(p => p.ProducerId == producerId).FirstOrDefault().Name.Replace(" ", "");
                string uniqueFileName = UploadedFile(model, producerName);

                Product product = new Product
                {
                    Name = model.Name,
                    AvailableStock = model.AvailableStock,
                    Price = model.Price,
                    Weight = model.Weight,
                    ProducerId = producerId,
                    PhotoUrl = "/Images/" + producerName + "/" + uniqueFileName,
                };
                _productRepository.Insert(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        private string UploadedFile(ProductViewModel model, string name)
        {
            string uniqueFileName = null;

            if (model.PhotoUrl != null)
            {

                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images" + @"\" + name);
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PhotoUrl.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.PhotoUrl.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}

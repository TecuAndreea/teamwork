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
    public class ProducerController : Controller
    {
        private readonly IGenericRepository<Producer> _producerRepository;

        public ProducerController(IGenericRepository<Producer> producerRepository)
        {
            _producerRepository = producerRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new ProductsAndProducersListViewModel
            {
                Producers = _producerRepository.GetAll()
            };

            return View(homeViewModel);
        }

        [HttpGet]
        [Route("/producers")]
        public IEnumerable<Producer> GetAllProducers()
        {
            return _producerRepository.GetAll();
        }

        [HttpPost]
        [Route("/producers")]
        public void InsertProducer(Producer producer)
        {
            _producerRepository.Insert(producer);
        }


        [HttpPut]
        [Route("/producers")]
        public void UpdateProducer(Producer producer)
        {
            _producerRepository.Update(producer);
        }
    }


}

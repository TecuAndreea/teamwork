using AsociatiaDeTarani.Models;
using AsociatiaDeTarani.Repositories;
using AsociatiaDeTarani.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Controllers
{
    public class OrderController : Controller
    {
        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IGenericRepository<Client> _clientRepository;

        public OrderController(IGenericRepository<Order> orderRepository, IGenericRepository<Client> clientRepository)
        {
            _orderRepository = orderRepository;
            _clientRepository = clientRepository;
        }

        public IActionResult ShoppingCart()
        {
            return View();
        }

        public IActionResult OrderForm()
        {
            return View();
        }

        public IActionResult OrderHistory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OrderForm(OrderDetailsViewModel modelee)
        {
            if(ModelState.IsValid)
            {
            
            Order order = new Order();
            Client client = new Client();

            Client clientAlreadyInDb = _clientRepository.GetAll().Where(x => x.PhoneNumber == modelee.PhoneNumber).FirstOrDefault();
            if (clientAlreadyInDb != null)
            {
                order.ClientId = clientAlreadyInDb.ClientId;
            }
            else
            {
                client.Name = modelee.Name;
                client.Adress = modelee.Adress;
                client.PhoneNumber = modelee.PhoneNumber;
                _clientRepository.Insert(client);
            }

            order.PlacementDate = DateTime.Now;
            order.TotalPrice = 1;


            _orderRepository.Insert(order);



            return RedirectToAction("OrderHistory");
        }
            return View();
        }

    }


}

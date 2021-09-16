using AsociatiaDeTarani.Models;
using AsociatiaDeTarani.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Controllers
{
    public class OrderController: Controller
    {
        private readonly IGenericRepository<Order> _orderRepository;

        public OrderController(IGenericRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IActionResult ShoppingCart()
        {
            return View();
        }
        
        public IActionResult OrderHistory()
        {
            return View();
        }
    }
}

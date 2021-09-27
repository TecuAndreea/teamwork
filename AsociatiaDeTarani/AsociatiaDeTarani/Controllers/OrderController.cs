using AsociatiaDeTarani.Helpers;
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
        private readonly IGenericRepository<OrderProduct> _orderProductRepository;
        private readonly IGenericRepository<Product> _productRepository;

        public OrderController(IGenericRepository<Order> orderRepository, IGenericRepository<Client> clientRepository, IGenericRepository<OrderProduct> orderProductRepository, IGenericRepository<Product> productRepository)
        {
            _orderRepository = orderRepository;
            _clientRepository = clientRepository;
            _orderProductRepository = orderProductRepository;
            _productRepository = productRepository;
        }

        public IActionResult OrderForm()
        {
            List<ProducerShoppingCartItemCount> producersItemsCount = SessionHelper.GetObjectFromJson<List<ProducerShoppingCartItemCount>>(HttpContext.Session, "producersItemsCount");
            var cart = GetShoppingCartItems();

            OrderDetailsViewModel modele = new OrderDetailsViewModel();

            var total = cart.Select(x => x.Price).Sum();
            modele.TotalPrice = total;
            var totalTransport = producersItemsCount.Select(x => x.Producer.DeliveryCost).Sum();
            modele.TotalPrice += totalTransport;
            ViewBag.total = modele.TotalPrice;

            return View();
        }

        public IActionResult OrderHistory()
        {
            return View();
        }

        public IActionResult OrderHistoryForClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OrderForm(OrderDetailsViewModel modelee)
        {

            if (ModelState.IsValid)
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
                    order.ClientId = client.ClientId;

                }


                order.PlacementDate = DateTime.Now;
                List<ProducerShoppingCartItemCount> producersItemsCount = SessionHelper.GetObjectFromJson<List<ProducerShoppingCartItemCount>>(HttpContext.Session, "producersItemsCount");
                var cart = GetShoppingCartItems();



                var total = cart.Select(x => x.Price).Sum();
                order.TotalPrice = total;
                var totalTransport = producersItemsCount.Select(x => x.Producer.DeliveryCost).Sum();
                order.TotalPrice += totalTransport;

                _orderRepository.Insert(order);

                ViewData["total"] = order.TotalPrice;

                foreach (var item in cart)
                {
                    _orderProductRepository.Insert(
                        new OrderProduct
                        {
                            OrderId = order.OrderId,
                            ProductId = item.Product.ProductId,
                            Quantity = item.Amount,
                            TotalPriceProducts = item.Price
                        });
                }
                HttpContext.Session.Clear();
                UpdateStock(cart);
                return RedirectToAction("OrderHistoryForClient");
            }
            return View();
        }

        [HttpGet]
        [Route("/ordersAndClientName")]
        public IEnumerable<JoinOrdersClients> GetAllOrdersAndClientName()
        {
            var result = from orders in _orderRepository.GetAll()
                         join clients in _clientRepository.GetAll() on orders.ClientId equals clients.ClientId
                         select new JoinOrdersClients
                         {
                             OrderId = orders.OrderId,
                             ClientName = clients.Name,
                             PlacementDate = orders.PlacementDate,
                             TotalPrice = orders.TotalPrice
                         };

            return result;
        }

        public IEnumerable<ShoppingCartItem> GetShoppingCartItems()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");

            return cart;
        }

        void UpdateStock(IEnumerable<ShoppingCartItem> shoppingCartItems)
        {
            foreach (var item in shoppingCartItems)
            {
                Product product = _productRepository.GetByCondition(x => x.ProductId == item.Product.ProductId).FirstOrDefault();
                product.AvailableStock -= item.Amount;
                _productRepository.Update(product);
            }
        }
    }
}

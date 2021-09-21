using AsociatiaDeTarani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.ViewModels
{
    public static class ShoppingCartViewModel
    {
        public static List<ShoppingCartItem> ShoppingCartItems { get; set; } = new();

        public static double ShoppingCartTotal { get; set; }

        public static void AddItemToCart(Product product)
        {
            var shoppingCartItem = ShoppingCartItems.SingleOrDefault(i => i.Product.ProductId == product.ProductId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    Product = product,
                    Amount = 1
                };

                ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
        }

        public static void EditAmount(ShoppingCartItem shoppingCartItem, int amount)
        {
            // TO DO
        }

        public static void DeleteItemFromCart(Product product)
        {
            var shoppingCartItem = ShoppingCartItems.SingleOrDefault(i => i.Product.ProductId == product.ProductId);

            if (shoppingCartItem != null)
            {
                ShoppingCartItems.Remove(shoppingCartItem);
            }
        }

        public static double GetShoppingCartTotal()
        {
            return ShoppingCartItems.Select(p => p.Product.Price * p.Amount).Sum();
        }
    }
}

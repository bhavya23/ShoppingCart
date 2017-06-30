using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Service.Model;
namespace ShoppingCart.Service.Cart
{
    public interface ICartService
    {
        void AddToCart(CartItems item);
        IEnumerable<CartItems> GetAll();
        void DeleteCartItem(CartItems item);
        CartItems GetById(int id);
        CartDetail GetCart(string cardNumber);
    }
}

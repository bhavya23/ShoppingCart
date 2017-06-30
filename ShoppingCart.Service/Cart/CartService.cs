using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Service.Model;
using ShoppingCart.Data.Entity;
using ShoppingCart.Service.Inventory;
using ShoppingCart.Data.Repository;
namespace ShoppingCart.Service.Cart
{
    public class CartService : ICartService
    {
        CartDetail detail;
        IInventoryService inventoryService;
        List<CartItems> lst = new List<CartItems>();


        public CartService()
        {
            detail = new CartDetail();
            inventoryService = new InventoryService();
        }

        
        public void AddToCart(CartItems item)
        {
            if (inventoryService.CheckInventory(item.ProductId, item.Qty))
                lst.Add(item);

        }

        public void DeleteCartItem(CartItems item)
        {
            lst.Remove(item);


        }

        public IEnumerable<CartItems> GetAll()
        {
            detail.Items = lst;
            return lst;
        }

        public CartItems GetById(int id)
        {
            return lst.Where(x => x.Id == id).FirstOrDefault();
        }

        public CartDetail GetCart(string cardNumber)
        {
            detail.CreditCardNumber = cardNumber;
            detail.Items = lst;
            lst.ForEach(x => detail.Total += x.Qty * (new ProductRepository().FindById(x.ProductId).Price));

            return detail;
        }
    }
}

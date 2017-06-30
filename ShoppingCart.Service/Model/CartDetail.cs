using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingCart.Data.Entity;

namespace ShoppingCart.Service.Model
{
    public class CartDetail
    {
        public int Id { get; set; }
        public string CreditCardNumber { get; set; }
        public string EmailId { get; set; }
        public List<CartItems> Items { get; set; }
        public decimal Total { get; set; }
    }
}

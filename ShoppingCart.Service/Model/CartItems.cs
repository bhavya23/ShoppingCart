using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Data.Entity;
namespace ShoppingCart.Service.Model
{
    public class CartItems
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
    }
}

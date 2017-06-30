using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string CreditCardNumber { get; set; }

        public string EmailId { get; set; }
        public string NameOnCard { get; set; }
    }
}

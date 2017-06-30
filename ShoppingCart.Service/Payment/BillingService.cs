using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service.Payment
{
    class BillingService : IBillingService
    {
        public bool ChargePayment(string creditCardNumber, decimal amount)
        {
            if (!string.IsNullOrEmpty(creditCardNumber) && amount > 0)
            {
                // call the payment services
                return true;
            }
            throw new FormatException("Invalid Card Number");
        }
    }
}

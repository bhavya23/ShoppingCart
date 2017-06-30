using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service.Payment
{
    public interface IBillingService
    {
        bool ChargePayment(string creditCardNumber, decimal amount);
    }
}

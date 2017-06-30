
using ShoppingCart.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service.CheckOut
{
    public interface ICheckOutService
    {
        bool CheckOut(CartDetail details);
    }
}

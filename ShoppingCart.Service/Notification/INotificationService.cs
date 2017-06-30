using ShoppingCart.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service.Notification
{
    interface INotificationService
    {

        void SendEmail(CartDetail details);
    }
}

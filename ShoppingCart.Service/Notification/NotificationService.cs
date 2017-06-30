using ShoppingCart.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service.Notification
{
    class NotificationService : INotificationService
    {
        public void SendEmail(CartDetail details)
        {
            //notify the user by sending  an email 
        }
    }
}

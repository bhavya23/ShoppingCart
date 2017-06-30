using ShoppingCart.Data.Entity;
using ShoppingCart.Service.Cart;
using ShoppingCart.Service.Inventory;
using ShoppingCart.Service.Model;
using ShoppingCart.Service.Notification;
using ShoppingCart.Service.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;


namespace ShoppingCart.Service.CheckOut
{
    public class CheckOutService : ICheckOutService
    {
        IBillingService billingService;
        INotificationService notificationService;
        public CheckOutService()
        {
            billingService = new BillingService();
            notificationService = new NotificationService();
        }

        public bool CheckOut(CartDetail details)
        {
            using (TransactionScope scope = new TransactionScope())
            {

                billingService.ChargePayment(details.CreditCardNumber, details.Total);
                notificationService.SendEmail(details);
                return true;
            }

        }
    }
}

using System;
using ShoppingCart.Data.Entity;
using ShoppingCart.Service.Payment;
using ShoppingCart.Service.Cart;
using ShoppingCart.Service.CheckOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart.Service.Model;
using ShoppingCart.Data.Repository;

namespace ShoppingCart.Test
{
    [TestClass]
    public class UnitTest1
    {

        ICheckOutService service;

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException), "Invalid Card Number")]
        public void TestCaseForInvalidCardNumber()
        {
            ICartService cartService = new CartService();
            service = new CheckOutService();
            cartService.AddToCart(new Service.Model.CartItems() { Id = 1, ProductId = 1, Qty = 1 });
            cartService.AddToCart(new Service.Model.CartItems() { Id = 2, ProductId = 2, Qty = 1 });
            CartDetail details = cartService.GetCart("");
            bool result = service.CheckOut(details);
        }




        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException), "Product Doesn't Exist")]
        public void TestCaseForNonExistingProduct()
        {

            ICartService cartService = new CartService();
            service = new CheckOutService();
            cartService.AddToCart(new Service.Model.CartItems() { Id = 1, ProductId = 7, Qty = 1 });
            cartService.AddToCart(new Service.Model.CartItems() { Id = 2, ProductId = 2, Qty = 1 });
            CartDetail details = cartService.GetCart("");
            bool result = service.CheckOut(details);
        }

        [TestMethod]
        public void TestCaseForValidCardNumberAndProducts()
        {
            ICartService cartService = new CartService();
            service = new CheckOutService();
            cartService.AddToCart(new Service.Model.CartItems() { Id = 1, ProductId = 1, Qty = 1 });
            cartService.AddToCart(new Service.Model.CartItems() { Id = 2, ProductId = 2, Qty = 1 });
            CartDetail details = cartService.GetCart("4647-2319-5625-4321");
            bool result = service.CheckOut(details);
            Assert.IsTrue(result);
        }

        
    }
}

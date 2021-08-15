using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class OrderServiceFacadeImpl : IOrderServiceFacade
    {
        public bool placeOrder(int pId)
        {
            bool orderFulfilled = false;
            Product product = new Product();
            product.productId = pId;
            if (InventoryService.isAvailable(product))
            {
                Console.WriteLine("Product with ID: " + product.productId + " is available.");
                bool paymentConfirmed = PaymentService.makePayment();
                if (paymentConfirmed)
                {
                    Console.WriteLine("Payment confirmed...");
                    ShippingService.shipProduct(product);
                    Console.WriteLine("Product shipped...");
                    orderFulfilled = true;
                }
            }
            return orderFulfilled;
        }
    }
    public class OrderFulfillmentController
    {
        public IOrderServiceFacade facade;
        public bool orderFulfilled = false;
        public void orderProduct(int productId)
        {
            orderFulfilled = facade.placeOrder(productId);
            Console.WriteLine("OrderFulfillmentController: Order fulfillment completed. ");
        }
    }
}

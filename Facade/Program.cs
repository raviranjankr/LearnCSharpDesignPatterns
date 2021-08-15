using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderFulfillmentController controller = new OrderFulfillmentController();
            controller.facade = new OrderServiceFacadeImpl();
            controller.orderProduct(9);
            bool result = controller.orderFulfilled;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

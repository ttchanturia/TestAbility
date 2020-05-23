using System;

namespace TestAbility
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ShippingCalculator());
            Order order = new Order { DatePlaced = DateTime.Today, TotalPrice = 100f};
            orderProcessor.Process(order);
        }
    }
}

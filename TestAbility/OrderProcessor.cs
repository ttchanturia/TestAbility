using System;
using System.Collections.Generic;
using System.Text;

namespace TestAbility
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("Order Already Processed");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }

    }
}

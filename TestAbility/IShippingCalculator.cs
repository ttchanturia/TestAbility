using System;
using System.Collections.Generic;
using System.Text;

namespace TestAbility
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}

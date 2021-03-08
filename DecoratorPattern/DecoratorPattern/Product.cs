using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Product
    {
        public double TotalPrice(Price price)
        {
            return price.Cost();
        }

    }
}

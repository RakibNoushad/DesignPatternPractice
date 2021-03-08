using System;
using System.Collections.Generic;
using System.Text;


namespace DecoratorPattern
{
    public abstract class Price
    {
        public int weight;
        public abstract double Cost();
    }
}

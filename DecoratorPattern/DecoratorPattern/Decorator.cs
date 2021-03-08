using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    abstract class Decorator : Price
    {
        protected Price _price;

        public Decorator(Price price)
        {
            this._price = price;
        }

        public void setPrice(Price price)
        {
            this._price = price;
        }

        public override double Cost()
        {
            if (this._price != null)
            {
                return this._price.Cost();
            }
            else
            {
                return 0;
            }

        }
    }
}

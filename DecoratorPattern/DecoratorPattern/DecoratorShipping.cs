using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class DecoratorShipping : Decorator
    {
        public DecoratorShipping(Price price) : base(price)
        {
            Console.WriteLine("Enter Product Weight");
            int X;
            String _result = Console.ReadLine();

            while (!int.TryParse(_result, out X))
            {
                Console.WriteLine("Please Enter a number");

                _result = Console.ReadLine();
            }

            var wght = Int32.Parse(_result);
            base.weight = wght;
        }

        public override double Cost()
        {
            var _shipping = weight*10;
            Console.WriteLine("Shipping Cost: {0}", _shipping);
            return base.Cost() + _shipping;
        }
    }
}

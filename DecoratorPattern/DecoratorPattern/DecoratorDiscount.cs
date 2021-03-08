using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class DecoratorDiscount : Decorator
    {
        public DecoratorDiscount(Price price) : base(price)
        {

        }

        public override double Cost()
        {
            Console.WriteLine("Enter Product Discount Percentage");

            double X;
            String _result = Console.ReadLine();

            while (!double.TryParse(_result, out X))
            {
                Console.WriteLine("Please Enter a number");

                _result = Console.ReadLine();
            }

            var _discount = Convert.ToDouble(_result);
            return base.Cost() * (_discount/100);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class DecoratorTax : Decorator
    {
        public DecoratorTax(Price price) : base(price)
        {

        }

        public override double Cost()
        {
            Console.WriteLine("Enter Product Tax Percentage");

            double X;
            String _result = Console.ReadLine();

            while (!double.TryParse(_result, out X))
            {
                Console.WriteLine("Please Enter a number");

                _result = Console.ReadLine();
            }

            var _tax = Convert.ToDouble(_result);

            var basePrice = base.Cost();
            return basePrice + (basePrice * (_tax/100));
        }
    }
}

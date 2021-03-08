using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class DecoratorVat : Decorator
    {
        public DecoratorVat(Price price) : base(price)
        {

        }

        public override double Cost()
        {
            Console.WriteLine("Enter Product VAT amount");
            double X;
            String _result = Console.ReadLine();

            while (!double.TryParse(_result, out X))
            {
                Console.WriteLine("Please Enter a number");

                _result = Console.ReadLine();
            }

            var _vat = Convert.ToDouble(_result);
            return base.Cost() + _vat;
        }
    }
}

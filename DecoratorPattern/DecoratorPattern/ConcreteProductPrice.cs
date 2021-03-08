using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteProductPrice : Price
    {
        public override double Cost()
        {
            Console.WriteLine("Enter Product Base Price");
            double X;
            String _result = Console.ReadLine();

            while (!double.TryParse(_result, out X))
            {
                Console.WriteLine("Please Enter a number");

                _result = Console.ReadLine();
            }

            var _basePrice = Convert.ToDouble(_result);
            return _basePrice;
        }

    }
}

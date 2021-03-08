using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            var basePrice = new ConcreteProductPrice();

            Price discountPrice = new DecoratorDiscount(basePrice);
            Price taxPrice = new DecoratorTax(discountPrice);
            Price vatPrice = new DecoratorVat(taxPrice);
            Price shippingPrice = new DecoratorShipping(vatPrice);

            var finalPrice = product.TotalPrice(shippingPrice);

            Console.WriteLine("Final Price of the Product is");
            Console.WriteLine(finalPrice);
        }
    }
}

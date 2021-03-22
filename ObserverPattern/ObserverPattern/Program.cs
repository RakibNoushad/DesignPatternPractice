using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 'exit' for close your tab or press any key");
            var _status = Console.ReadLine();

            var stock = new Stock();

            var _optimistic = new Optimistic();
            stock.Attach(_optimistic);

            var _pessimistic = new Pessimistic();
            stock.Attach(_pessimistic);

            Console.WriteLine("Enter Initial Stock Price");
            var _initPrice = Int32.Parse(Console.ReadLine());
            stock.prevPrice = _initPrice;

            while (_status!= "exit")
            {
                stock.getCurrPrice();

                Console.WriteLine("Type 'exit' for close your tab or press any key");
                _status = Console.ReadLine();
            }
        }
    }
}

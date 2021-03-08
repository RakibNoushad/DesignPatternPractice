using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataPresentation = new DataPresentation();

            Console.WriteLine("Method set as Line Graph");
            dataPresentation.SetMethod(new ConcreteLineGraph());


            Console.WriteLine("Method set as Bar Chart");
            dataPresentation.SetMethod(new ConcreteBarChart());
        }
    }
}

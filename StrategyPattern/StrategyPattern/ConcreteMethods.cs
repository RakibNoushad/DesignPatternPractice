using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class ConcreteLineGraph : IMethod
    {
        public object graphMethod(object data)
        {
            var text = "This is Line Graph";

            return text;
        }
    }

    class ConcreteBarChart : IMethod
    {
        public object graphMethod(object data)
        {
            var text = "This is Bar Chart";

            return text;
        }
    }
}

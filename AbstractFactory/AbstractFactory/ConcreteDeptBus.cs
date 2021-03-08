using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConcreteDeptBus : IDeptFactory
    {
        public IDegree CreateDegreeBs()
        {
            Console.WriteLine("Bs for Business is BBA");
            return new CreateDegreeBBA();
        }

        public IDegree CreateDegreeMs()
        {
            Console.WriteLine("Ms for Business is MBA");
            return new CreateDegreeMBA();
        }
    }
}

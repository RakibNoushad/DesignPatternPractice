using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConcreteDeptEng : IDeptFactory
    {
        public IDegree CreateDegreeBs()
        {
            Console.WriteLine("Bs for Engineering is B.Sc");
            return new CreateDegreeBSc();
        }

        public IDegree CreateDegreeMs()
        {
            Console.WriteLine("Ms for Engineering is M.Sc");
            return new CreateDegreeMSc();
        }
    }
}

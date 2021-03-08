using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CreateDegreeBSc : IDegree
    {
        public ICourse CreateCourse()
        {
            return new BscCourse();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CreateDegreeMSc : IDegree
    {
        public ICourse CreateCourse()
        {
            return new MscCourse();
        }
    }
}

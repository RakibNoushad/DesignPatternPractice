using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CreateDegreeMBA : IDegree
    {
        public ICourse CreateCourse()
        {
            return new MbaCourse();
        }
    }
}

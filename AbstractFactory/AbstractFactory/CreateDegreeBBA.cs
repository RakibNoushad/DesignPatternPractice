using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CreateDegreeBBA : IDegree
    {
        public ICourse CreateCourse()
        {
            return new BbaCourse();
        }
    }
}

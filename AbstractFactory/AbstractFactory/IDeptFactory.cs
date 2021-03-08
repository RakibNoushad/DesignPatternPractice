using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface IDeptFactory
    {
        IDegree CreateDegreeBs();
        IDegree CreateDegreeMs();
    }
}

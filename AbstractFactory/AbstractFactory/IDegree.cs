﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface IDegree
    {
        ICourse CreateCourse();
    }
}

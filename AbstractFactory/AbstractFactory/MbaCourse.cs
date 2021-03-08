using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class MbaCourse : ICourse
    {
        public string CourseName()
        {
            Console.WriteLine("Courses for MBA is-");
            return "Business Ethics";
        }
    }
}

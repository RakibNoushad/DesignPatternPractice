using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class MscCourse : ICourse
    {
        public string CourseName()
        {
            Console.WriteLine("Courses for MSc is-");
            return "Engineering Ethics";
        }
    }
}

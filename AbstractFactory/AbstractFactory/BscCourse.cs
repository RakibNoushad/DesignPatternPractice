using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class BscCourse : ICourse
    {
        public string CourseName()
        {
            Console.WriteLine("Courses for BSc are-");
            return "Engineering 101, Engineering 102";
        }
    }
}

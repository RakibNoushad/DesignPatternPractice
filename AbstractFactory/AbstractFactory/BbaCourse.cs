using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class BbaCourse : ICourse
    {
        public string CourseName()
        {
            Console.WriteLine("Courses for BBA are-");
            return "Business 101, Business 102";
        }
    }
}

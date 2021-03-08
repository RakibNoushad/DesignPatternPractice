using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Student
    {
        public void Main()
        {
            Console.WriteLine("Engineering");
            CreateInfo(new ConcreteDeptEng());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Business");
            CreateInfo(new ConcreteDeptBus());

        }

        private void CreateInfo(IDeptFactory factory)
        {
            Console.WriteLine("Bs Degree");
            var degree = factory.CreateDegreeBs();
            var course = degree.CreateCourse();
            var courseName = course.CourseName();

            Console.WriteLine(courseName);

            Console.WriteLine();
            Console.WriteLine("Ms Degree");
            var degree2 = factory.CreateDegreeMs();
            var course2 = degree2.CreateCourse();
            var courseName2 = course2.CourseName();

            Console.WriteLine(courseName2);
        }
    }
}

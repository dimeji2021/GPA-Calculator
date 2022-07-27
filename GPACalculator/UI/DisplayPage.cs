using System;
using System.Collections.Generic;
using System.Text;
using GPACalculator.Core;

namespace GPACalculator.UI
{
    public static class DisplayPage
    {



        public static void Print(GPA gpa)
        {
            Console.WriteLine("|-------------------|---------------|----------------|---------------|--------------|-------------|");
            Console.WriteLine("|COURSE NAME & CODE |  COURSE UNIT  |    GRADE       |  GRADE UNIT   |  WEIGHT Pt.  |  REMARKS    |");
            Console.WriteLine("|-------------------|---------------|----------------|---------------|--------------|-------------|");
            for (int i = 0; i < gpa.numberOfCourseOffered; i++)
            {
                Console.WriteLine($"|{gpa.courseNameCode[i]}            |{gpa.courseUnit[i]}              |{gpa.grades[i]}               |{gpa.gradeUnit[i]}              |{gpa.weightPt[i]}            |{gpa.remarks[i]}           ");
            }
            Console.WriteLine("|--------------------------------------------------------------------|--------------|-------------|");

            Console.WriteLine($"{gpa.totalCourseUnitRegistered}");
            Console.WriteLine($"{gpa.totalCourseUnitPassed}");

            Console.WriteLine($"{gpa.totalWeightPoint}");
            Console.WriteLine($"{gpa.gpa}");
        }

    }
}

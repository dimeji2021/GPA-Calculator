using System;
using System.Collections.Generic;
using System.Text;
using GPACalculator.UI;


namespace GPACalculator.Core
{
    public class GPA
    {


        //public GPA(List<string> courseNameCode, List<int> courseUnit, List<double> courseScore)
        //{
        //    this.courseNameCode = courseNameCode;
        //    this.courseUnit = courseUnit;
        //    this.courseScore = courseScore;
        //}



        //public List<string> CourseNameCode
        //{
        //    get { return courseNameCode; }
        //    set { courseNameCode = value; }
        //}

        //public List<int> CourseUnit
        //{
        //    get { return courseUnit; }
        //    set { courseUnit = value; }
        //}
        //public List<double> CourseScore
        //{
        //    get { return courseScore; }
        //    set { courseScore = value; }
        //}



        public int numberOfCourseOffered;
        public List<string> courseNameCode = new List<string> { };
        public List<int> courseUnit = new List<int> { };
        public List<double> courseScore = new List<double> { };



       internal List<string> remarks = new List<string> { };
       internal List<GRADE> grades = new List<GRADE> { };
       internal List<int> gradeUnit = new List<int> { };
       internal List<int> weightPt = new List<int> { };
       internal int totalCourseUnitRegistered = 0;
       internal int totalCourseUnitPassed = 0;
       internal int totalWeightPoint = 0;
       internal double gpa = 0;


        //1 % 2 % 3
        public void Remarks()
        {
            foreach (var score in courseScore)
            {
                if (score >= 70 && score <= 100)
                {
                    remarks.Add("Excellent");
                    grades.Add(GRADE.A);
                    gradeUnit.Add((int)GRADE.A);

                }
                else if (score >= 60 && score <= 69)
                {
                    remarks.Add("Very Good");
                    grades.Add(GRADE.B);
                    gradeUnit.Add((int)GRADE.B);


                }
                else if (score >= 50 && score <= 59)
                {
                    remarks.Add("Good");
                    grades.Add(GRADE.C);
                    gradeUnit.Add((int)GRADE.C);


                }
                else if (score >= 45 && score <= 50)
                {
                    remarks.Add("Fair");
                    grades.Add(GRADE.D);
                    gradeUnit.Add((int)GRADE.D);


                }
                else if (score >= 40 && score <= 44)
                {
                    remarks.Add("Pass");
                    grades.Add(GRADE.E);
                    gradeUnit.Add((int)GRADE.E);


                }
                else
                {
                    remarks.Add("Fail");
                    grades.Add(GRADE.F);
                    gradeUnit.Add((int)GRADE.F);


                }
            }
        }


        //4
        public void WeightPoint()
        {
            for (int i = 0; i < numberOfCourseOffered; i++)
            {
                weightPt.Add(courseUnit[i] * gradeUnit[i]);

            }
        }

        //5
        public void SumCourseUnit()
        {
            foreach (int unit in courseUnit)
            {
                totalCourseUnitRegistered += unit;
            }
        }

        //6
        public void SumCourseUnitPassed()
        {
            for (int i = 0; i < numberOfCourseOffered; i++)
            {
                if (gradeUnit[i] != 0)
                    totalCourseUnitPassed += courseUnit[i];
            }
        }
        //7
        public void SumWeightPt()
        {
            foreach (int weight in weightPt)
            {
                totalWeightPoint += weight;
            }
        }
        //8
        public void CalGPA()
        {
            gpa =Math.Round((double)totalWeightPoint / totalCourseUnitPassed,2);

        }
    }

}
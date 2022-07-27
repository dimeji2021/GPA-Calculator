using System;
using System.Collections.Generic;
using GPACalculator.UI;
using GPACalculator.Core;


namespace GPACalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello; you are welcome to my GPA Calculator");
            Console.ResetColor();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Type help to continue");
            Console.Write(">");

            string input = Console.ReadLine().Trim();
            while (!input.Equals("") || input.Equals("exit"))
            {



                int numberOfCourseOffered;
                bool validNumber;
                int Index = 0;

                GPA gpa = new GPA();

                do
                {
                    Console.Clear();
                    Console.Write("Enter a valid Number of Course Offered: ");
                    validNumber = int.TryParse(Console.ReadLine(), out numberOfCourseOffered);
                } while (validNumber != true);
                Console.WriteLine();

                do
                {
                    Console.Clear();
                    Console.Write("Enter the course name and code: ");
                    gpa.courseNameCode.Add(Console.ReadLine().ToUpper());
                    Console.WriteLine();

                    int unit; double score; bool validateCourseUnit;
                    do
                    {
                        Console.WriteLine("Enter your course unit");
                        Console.Write("Unit must not be greater than 5: ");
                        validateCourseUnit = int.TryParse(Console.ReadLine(), out unit);
                        if (!validateCourseUnit)
                        {
                            Console.WriteLine("Please enter a valid Number");
                        }
                        Console.WriteLine();

                    } while (unit > 5 || validateCourseUnit != true);
                    gpa.courseUnit.Add(unit);
                    Console.WriteLine();


                    do
                    {
                        Console.WriteLine("Enter your score");
                        Console.Write("Score must be Greater than 0 and Lesser or Equal to 100:  ");
                        validateCourseUnit = double.TryParse(Console.ReadLine(), out score);
                        if (!validateCourseUnit)
                        {
                            Console.WriteLine("Please enter a valid Number");
                        }
                        Console.WriteLine();

                    } while (score < 0 || score > 100 || validateCourseUnit != true);
                    gpa.courseScore.Add(score);

                    Index++;
                } while (Index < numberOfCourseOffered);
                Console.Clear();


                gpa.numberOfCourseOffered = numberOfCourseOffered;
                gpa.Remarks();
                gpa.WeightPoint();
                gpa.SumCourseUnit();
                gpa.SumCourseUnitPassed();
                gpa.SumWeightPt();
                gpa.CalGPA();
                DisplayPage.Print(gpa);


                Console.ReadLine();
            }

        }
    }
}

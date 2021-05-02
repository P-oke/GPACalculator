using System;


namespace CGPA_Calculator
{
    public class GPACalculate
    {

        public static void displayGradeinfo()
        {
            Console.WriteLine("Note the following A = 70 and above, B = 60-69, C = 50-59, D = 45-49, E = 40-44, F = 0-39");

        }

        public static double getScoreGrade(Course course)
        {
            double grade = 0;

            double score = course.CourseScore;
            if (score >= 70)
            {
                grade = 5;

            }

            else if (score >= 60 && score <= 69)
            {
                grade = 4;

            }

            else if (score >= 50 && score <= 59)
            {
                grade = 3;

            }

            else if (score >= 45 && score <= 49)
            {
                grade = 2;

            }

            else if (score >= 40 && score <= 44)
            {
                grade = 1;

            }

            else if (score >= 0 && score <= 39)
            {
                grade = 0;

            }

            return grade;
        }

        public static double gpaverage(Db course)
        {

            double totalscores = 0;
            double gpaverage = 0;
            int unit = 0;
            int totalunit = 0;


            foreach (var eachcourse in course.getAllCourses())
            {
                string coursecode = eachcourse.CourseCode;
                unit = eachcourse.NumberOfUnits;
                totalunit += unit;

                double grade = getScoreGrade(eachcourse) * unit;
                totalscores += grade;

                Console.WriteLine("----------------------------------------------------");

                Console.WriteLine($"Your Grade Point for Coursecode {coursecode} is: {grade}");


            }

            gpaverage = totalscores / totalunit;
            return gpaverage;




        }




    }
}
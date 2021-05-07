using System.Collections.Generic;
using System;



namespace CGPA_Calculator
{

    public class GPACalculate
    {
        //    
        Db mydb = Db.Initialize();




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

        public static double gpaverage(IEnumerable<Course> course)
        {

            double totalscores = 0;
            double gpaverage = 0;
            int unit = 0;
            int totalunit = 0;


            foreach (var eachcourse in course)
            {

                string coursecode = eachcourse.CourseCode;
                double score = eachcourse.CourseScore;

                unit = eachcourse.NumberOfUnits;
                totalunit += unit;

                double grade = getScoreGrade(eachcourse) * unit;
                totalscores += grade;

                string gradeType;
                gradeType = getGrade(eachcourse);

                Console.WriteLine("-----------------------------------------------------------------------------");

                Console.WriteLine($"Coursecode      |     Courseunit       |     Score        |        Grade      |   GradePoint ");
                Console.WriteLine($" {coursecode.ToUpper()}                        {unit}                  {score}                    {gradeType}           {grade} ");


            }

            gpaverage = totalscores / totalunit;
            return gpaverage;


        }

        public static string getGrade(Course course)
        {

            string mygrade = null;
            Grade gradetype = new Grade();

            double score = course.CourseScore;
            if (score >= 70)
            {
                mygrade = gradetype.A = "A";

            }

            else if (score >= 60 && score <= 69)
            {
                mygrade = gradetype.B = "B";

            }

            else if (score >= 50 && score <= 59)
            {
                mygrade = gradetype.C = "C";


            }

            else if (score >= 45 && score <= 49)
            {
                mygrade = gradetype.D = "D";

            }

            else if (score >= 40 && score <= 44)
            {
                mygrade = gradetype.E = "E";

            }

            else if (score >= 0 && score <= 39)
            {
                mygrade = gradetype.F = "F";

            }

            return mygrade;

        }




    }
}
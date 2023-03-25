using System;

namespace MidtermPractice
{
    public class Grades
    {
        public static string GradeConverter(decimal gradeNumber)
        {
            if (gradeNumber > 100)
            {
                return ("It is a invalid input, please retry");
            }
            else if (gradeNumber >= 80 && gradeNumber <= 100)
            {
                return ("Grade is A");
            }
            else if (gradeNumber < 80 && gradeNumber >= 70)
            {
                return ("Grade is B");
            }
            else if (gradeNumber < 70 && gradeNumber >= 60)
            {
                return ("Grade is C");
            }
            else if (gradeNumber < 60 && gradeNumber >= 55)
            {
                return ("Grade is D");
            }
            else if (gradeNumber >= 0 && gradeNumber < 55)
            {
                return ("Grade is Fail");
            }
            else
            {
                return ("It is a invalid input, please retry");
            }
        }
    }
}

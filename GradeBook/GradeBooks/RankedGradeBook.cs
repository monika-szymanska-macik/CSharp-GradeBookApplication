using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }
            return 'F';
            if (averageGrade > 80)
            {
                return 'A';
            }
            else if (averageGrade > 60)
            { 
                return 'B'; 
            }
            else if (averageGrade > 40)
            {
                return 'C';
            }
            else if(averageGrade > 20)
            {
                return 'D';
            }
        }
    }
}

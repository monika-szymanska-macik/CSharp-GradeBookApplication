using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

            var best20Students = (int)Math.Ceiling(Students.Count * 0.2);
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();
            if (grades[best20Students - 1] <= averageGrade)
                return 'A';
            else if
                (grades[best20Students * 2 - 1] <= averageGrade)
                return 'B';
            else if
                (grades[best20Students * 3 - 1] <= averageGrade)
                return 'C';
            else if
                (grades[best20Students * 4 - 1] <= averageGrade)
                return 'D';
            else
                return 'F';

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject5
{
    class Grade
    {
        private double qpoints;
        private String letterGrade;

        public Grade(String LetterGrade)
        {
            letterGrade = LetterGrade;
            if (letterGrade == "A+")
                qpoints = 4.3;

            else if (letterGrade == "A")
                qpoints = 4;

            else if (letterGrade == "A-")
                qpoints = 3.7;

            else if (letterGrade == "B+")
                qpoints = 3.3;

            else if (letterGrade == "B")
                qpoints = 3;

            else if (letterGrade == "B-")
                qpoints = 2.7;

            else if (letterGrade == "C+")
                qpoints = 2.3;

            else if (letterGrade == "C")
                qpoints = 2;

            else
                qpoints = 2;
        }

        public double getQpoints()
        {
            return qpoints;
        }

        public override String ToString()
        {
            return letterGrade;
        }

    }
}

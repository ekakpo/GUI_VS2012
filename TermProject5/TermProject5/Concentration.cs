using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject5
{
    class Concentration
    {
        private List<Course> requirements;
        Boolean threeClassesTaken;

        public Concentration(List<Course> Requirements)
        {
            threeClassesTaken = false;
            requirements = Requirements;
        }

        public Concentration()
        {
            threeClassesTaken = false;
        }

        public void addRequirement(Course coursetoAdd)
        {
            Course.insertInOrder(requirements, coursetoAdd);
        }


    }
}

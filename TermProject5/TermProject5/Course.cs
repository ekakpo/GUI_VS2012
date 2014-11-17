using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace TermProject5
{
    class Course
    {
        private String name;
        private double hours;
        private Boolean alreadyDisplayed;

        public Course(String Name, Double Hours)
        {
            this.name = Name;
            this.hours = Hours;
            alreadyDisplayed = false;
        }

        public String getName()
        {
            return this.name;
        }

        public Double getHours()
        {
            return this.hours;
        }

        public override String ToString()
        {
            return this.name;
        }

        public void setStatus(Boolean b)
        {
            alreadyDisplayed = b;
        }

        public static ObservableCollection<Course> insertInOrder(ObservableCollection<Course> targetList, Course courseToInsert)
        {
            Boolean itemWasNotInserted = true;
            for (int i = 0; i <= targetList.Count - 1; i++)
            {
                if (String.Compare(courseToInsert.getName(), targetList[i].getName()) == -1)
                {
                    targetList.Insert(i, courseToInsert);
                    itemWasNotInserted = false;
                    break;
                }
            }

            if (itemWasNotInserted)
                targetList.Add(courseToInsert);

            return targetList;
        }

        public static List<Course> insertInOrder(List<Course> targetList, Course courseToInsert)
        {
            Boolean itemWasNotInserted = true;
            for (int i = 0; i <= targetList.Count - 1; i++)
            {
                if (String.Compare(courseToInsert.getName(), targetList[i].getName()) == -1)
                {
                    targetList.Insert(i, courseToInsert);
                    itemWasNotInserted = false;
                    break;
                }
            }

            if (itemWasNotInserted)
                targetList.Add(courseToInsert);

            return targetList;
        }

        public static ObservableCollection<Course> removeItem(ObservableCollection<Course> targetList, Course courseToRemove)
        {
            for (int i = 0; i <= targetList.Count - 1; i++)
            {
                Console.WriteLine("Scanned index " + i);
                if (courseToRemove.getName() == targetList[i].getName())
                {
                    targetList.RemoveAt(i);
                    Console.WriteLine("Removed at index " + i);
                    break;
                }
            }

            return targetList;
        }

        public static List<Course> removeItem(List<Course> targetList, Course courseToRemove)
        {
            for (int i = 0; i <= targetList.Count - 1; i++)
            {
                Console.WriteLine("Scanned index " + i);
                if (courseToRemove.getName() == targetList[i].getName())
                {
                    targetList.RemoveAt(i);
                    Console.WriteLine("Removed at index " + i);
                    break;
                }
            }

            return targetList;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructHomeWork
{
    static public class ListOfHousing
    {
        static public List<Student> SortBySalary(List<Student> student)
        {
            Student studentTwo = new Student();

            for (int i = 1; i < student.Count; i++) 
            {
                if (student[i - 1].FamilyIncome > student[i].FamilyIncome)
                {
                    studentTwo = student[i - 1];
                    student[i - 1] = student[i];
                    student[i] = studentTwo;
                }
            }

            return student;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructHomeWork
{
    public class Student
    {
        public string FIO { get; set; }

        public string GroupName { get; set; }

        public double AverageMark { get; set; }

        public int FamilyIncome { set; get; }

        public Gender Gender { set; get; }

        public TypeOfTraining typeOfTraining { set; get; }
    }
}

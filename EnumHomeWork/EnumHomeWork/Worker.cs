using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumHomeWork
{
    class Worker
    {
        public string FirstName { get; set; }

        public string MidleName { get; set; }

        public string LastName { get; set; }

        public int Salary { get; set; }

        public int DayAdmissionToEmployment { get; set; }
        public int WeekAdmissionToEmployment { get; set; }
        public int YearAdmissionToEmployment { get; set; }

        public TypeWorker TypeWorker { get; set; }

        public Worker(string firstName,string midleName,string lastName,int salary, int year, int week, int day, TypeWorker type)
        {
            FirstName = firstName;
            MidleName = midleName;
            LastName = lastName;
            Salary = salary;
            DayAdmissionToEmployment = day;
            WeekAdmissionToEmployment = week;
            YearAdmissionToEmployment = year;
            TypeWorker = type;
        }

        public Worker()
        {

        }
    }
}

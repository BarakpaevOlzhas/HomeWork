using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumHomeWork
{
    public class WorkerInterface
    {
        private List<Worker> employee;

        public WorkerInterface()
        {
            employee = new List<Worker>();
        }

        public void SortForMidleName()
        {
            Worker bufWorker = new Worker();

            for (int i = 0;i < employee.Count - 1;i++)
            {
                if (employee[i].MidleName[0] < employee[i + 1].MidleName[0])
                {
                    bufWorker = employee[i];
                    employee[i] = employee[i + 1];
                    employee[i + 1] = bufWorker;
                }
            }
        }

        public void AddWorker(string firstName, string midleName, string lastName, int salary, int year, int week, int day, TypeWorker type)
        {
            employee.Add(new Worker{ FirstName = firstName, MidleName = midleName, LastName = lastName, Salary = salary, YearAdmissionToEmployment = year, WeekAdmissionToEmployment = week, DayAdmissionToEmployment = day, TypeWorker = type });
        }

        public void ShowAllEmployee()
        {
            foreach (var person in employee)
            {
                Console.WriteLine($"FIO: {person.MidleName} {person.FirstName} {person.LastName} \n Salary: {person.Salary} \n DateAdmissionToEmployment: {person.DayAdmissionToEmployment}-{person.WeekAdmissionToEmployment}-{person.YearAdmissionToEmployment} \n Type {person.TypeWorker} \n\n");
            }
        }

        public void ShowAllNewEmployee()
        {
            int index = 0;

            for (int i = 0; i < employee.Count; i++) 
            {
                if (employee[i].TypeWorker == TypeWorker.boss)
                {
                    index = i;
                }
            }

            for (int i = 0; i < employee.Count; i++) 
            {
                if (employee[index].YearAdmissionToEmployment < employee[i].YearAdmissionToEmployment)
                {
                    Console.WriteLine($"FIO: {employee[i].MidleName} {employee[i].FirstName} {employee[i].LastName} \n Salary: {employee[i].Salary} \n DateAdmissionToEmployment: {employee[i].DayAdmissionToEmployment}-{employee[i].WeekAdmissionToEmployment}-{employee[i].YearAdmissionToEmployment} \n Type {employee[i].TypeWorker} \n\n");
                }
                else if (employee[index].YearAdmissionToEmployment == employee[i].YearAdmissionToEmployment)
                {
                    if (employee[index].WeekAdmissionToEmployment< employee[i].WeekAdmissionToEmployment)
                    {
                    Console.WriteLine($"FIO: {employee[i].MidleName} {employee[i].FirstName} {employee[i].LastName} \n Salary: {employee[i].Salary} \n DateAdmissionToEmployment: {employee[i].DayAdmissionToEmployment}-{employee[i].WeekAdmissionToEmployment}-{employee[i].YearAdmissionToEmployment} \n Type {employee[i].TypeWorker} \n\n");
                    }
                }
            }
        }

        public void ShowAllManagerWithHighSalary()
        {
            int mediumSalary = 0;

            foreach (var person in employee)
            {
                mediumSalary += person.Salary;
            }

            mediumSalary = mediumSalary / employee.Count;

            foreach (var person in employee)
            {
                if (person.TypeWorker == TypeWorker.manager)
                {
                    if (mediumSalary < person.Salary)
                    {
                    Console.WriteLine($"FIO: {person.MidleName} {person.FirstName} {person.LastName} \n Salary: {person.Salary} \n DateAdmissionToEmployment: {person.DayAdmissionToEmployment}-{person.WeekAdmissionToEmployment}-{person.YearAdmissionToEmployment} \n Type {person.TypeWorker} \n\n");
                    }
                }
            }
        }

    }
}

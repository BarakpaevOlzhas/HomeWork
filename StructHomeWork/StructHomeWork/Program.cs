using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            List<Student> sortList = new List<Student>();
            int size;

            Console.WriteLine("Введите кол-во студентов");

            int.TryParse(Console.ReadLine(),out size);

            for (int i = 0; i < size; i++) 
            {
                string fio;
                double averageMark;
                int familyIncome;
                string groupName;
                int choise;
                int choiseTwo;

                Console.WriteLine("Введите FIO");

                fio = Console.ReadLine();

                Console.WriteLine("Введите средний балл");

                double.TryParse(Console.ReadLine(), out averageMark);

                Console.WriteLine("Введите доход");

                int.TryParse(Console.ReadLine(),out familyIncome);

                Console.WriteLine("Введите название группы");

                groupName = Console.ReadLine();

                Console.WriteLine("1)Мужской");
                Console.WriteLine("2)Женский");

                Gender gender = new Gender();
                
                int.TryParse(Console.ReadLine(), out choise);

                if (choise == 1)
                {
                    gender = Gender.male;
                }
                else
                {
                    gender = Gender.woman;
                }

                Console.WriteLine("1)Очный");
                Console.WriteLine("2)Заочный");

                TypeOfTraining typeOfTraining = new TypeOfTraining();

                int.TryParse(Console.ReadLine(), out choiseTwo);

                if (choise == 1)
                {
                    typeOfTraining = TypeOfTraining.intramural;
                }
                else
                {
                    typeOfTraining = TypeOfTraining.correspondence;
                }

                list.Add(new Student { FIO = fio, AverageMark = averageMark, FamilyIncome = familyIncome, typeOfTraining = typeOfTraining, Gender = gender, GroupName = groupName });
            }

            sortList = ListOfHousing.SortBySalary(list);

            foreach (var student in sortList)
            {
                Console.WriteLine($" FIO: {student.FIO} \n Доход:{student.FamilyIncome}");
            }

            Console.ReadLine();

        }
    }
}

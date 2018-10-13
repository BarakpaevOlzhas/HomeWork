using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            WorkerInterface worker = new WorkerInterface();

            Console.WriteLine("Введите кол-во сотрудников:");

            int.TryParse(Console.ReadLine(),out size);

            for (int i = 0; i < size; i++) 
            {
                int zero = 0, one = 1, two = 2;
                string firstName;
                string midleName;
                string lastName;
                int salary;                
                int year;
                int week;
                int day;
                int type;
                int choise;

                Console.WriteLine("Введите имя");

                firstName = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                midleName = Console.ReadLine();

                Console.WriteLine("Введите отчество");

                lastName = Console.ReadLine();

                Console.WriteLine("Введите зарплату");

                int.TryParse(Console.ReadLine(), out salary);

                Console.WriteLine("Введите дату прибытия");
                Console.WriteLine("Год:");

                int.TryParse(Console.ReadLine(),out year);

                Console.WriteLine("Месяц:");

                int.TryParse(Console.ReadLine(), out week);

                Console.WriteLine("День:");

                int.TryParse(Console.ReadLine(), out day);
                
                Console.WriteLine("Кем он является");
                Console.WriteLine("0)Клерк");
                Console.WriteLine("1)Менеджер");
                Console.WriteLine("2)Босс");

                int.TryParse(Console.ReadLine(),out choise);

                if (choise == zero)
                {
                    type = choise;
                }
                else if (choise == one)
                {
                    type = choise;
                }
                else if (choise == two)
                {
                    type = choise;
                }
                else
                {
                    type = zero;
                }

                worker.AddWorker(firstName, midleName, lastName, salary,year,week,day,type == 0? TypeWorker.clerk : type == 1? TypeWorker.manager : TypeWorker.boss);

            }
            Console.WriteLine("Все работники");
            worker.ShowAllEmployee();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("всех менеджеров, зарплата которых больше средней зарплаты ");
            worker.ShowAllManagerWithHighSalary();
            
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("всех сотрудниках, принятых на работу позже босса");
            worker.ShowAllNewEmployee();

        }
    }
}

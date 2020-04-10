using System;

namespace DZ_2020_04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  • Задание 3
             *      A. Создайте проект по шаблону Console Application.
             *      B. Создать класс Employee.
             *          1. В теле класса создать пользовательский конструктор, который принимает два
             *              строковых аргумента, и инициализирует поля, соответствующие фамилии и
             *              имени сотрудника. Создать метод рассчитывающий оклад сотрудника (в
             *              зависимости от должности и стажа) и налоговый сбор.
             *              
             *              Написать программу, которая выводит на экран информацию о
             *              сотруднике (фамилия, имя, должность), оклад (заработная плата) и
             *              налоговый сбор (13 % налог + 1% пенсионный фонд) от заработной платы.
             */
             
                System.Console.Write("Введите имя: ");
            string name = Console.ReadLine();

                System.Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Employee emp = new Employee(name, surname);

                System.Console.Write("Выберите категорию должности:\n3Category если стаж <= 1 года\n2Category если стаж <= 3 лет\n1Category если стаж <= 5 лет\nВведите категорию должности: ");
            string pos = emp.Position = Console.ReadLine();
                
                System.Console.Write("Введите стаж: ");
            int exp = emp.Experience = int.Parse(Console.ReadLine());

                System.Console.Write("Введите зарплату: ");
            decimal sal = emp.Salary = decimal.Parse(Console.ReadLine());
                
                System.Console.WriteLine();
                emp.showEmployee();

            Console.ReadKey();
        }
        class Employee
        {
            private string Name {get;set;}
            private string Surname {get;set;}
            public string Position;
            public decimal Salary;
            public int Experience;
            public Employee(string name, string surname)
            {
                this.Name = name;
                this.Surname = surname;
            }
            public Employee(){}
            public void showEmployee()
            {   
                decimal TaxPensFund;
                decimal FinalSalary = 0;

                if((Position == "3Category") && (Experience <= 1))
                {
                    FinalSalary = (Salary + ((Salary * 5) / 100)); // прибавляется к зарплате 5% работнику категории 3 и стажем не менее 1 года   
                }
                if((Position == "2Category") && (Experience <= 3))
                {
                    FinalSalary = (Salary + ((Salary * 15) / 100));  // прибавляется к зарплате 15% работнику категории 2 и стажем не менее 3 лет
                }
                if((Position == "1Category") && (Experience <= 5))
                {
                    FinalSalary = (Salary + ((Salary * 25) / 100));  // прибавляется к зарплате 25% работнику категории 1 и стажем не менее 5 лет  
                }
                TaxPensFund = (FinalSalary * 14) / 100;  // расчет налога 13% + пенсионный фонд 1% = 14%  

                System.Console.WriteLine($"Name: {this.Name}");
                System.Console.WriteLine($"Surname: {this.Surname}");
                System.Console.WriteLine($"Position: {Position}");
                System.Console.WriteLine($"Experience: {Experience}");
                System.Console.WriteLine($"TaxPensFund: {TaxPensFund}");
                System.Console.WriteLine($"FinalSalary: {FinalSalary - TaxPensFund}");
            }
        }
    }
}
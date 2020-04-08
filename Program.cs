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


            Console.ReadKey();
        }
        class Employee
        {
            private string Name;
            private string Surname;
            public Employee(string name, string surname)
            {
                this.Name = name;
                this.Surname = surname;
            }
            public Employee(){}
            public decimal Salary(string position, int experience, decimal salary)
            {   
            }
            public void showEmployee()
            {
                System.Console.WriteLine($"Name: {this.Name}");
                System.Console.WriteLine($"Surname: {this.Surname}");
            }
        }
    }
}
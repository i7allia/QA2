﻿using System;

namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет дружок! Это бета версия приложения СОТРУДНИК ");

            int Work_experience;
            Console.WriteLine("Введите стаж работы (в годах)");
            Work_experience = Convert.ToInt32(Console.ReadLine());

            int Skill_level;
            Console.WriteLine("Введите уровень квалификации (число от 1 до 5)");
            Skill_level = Convert.ToInt32(Console.ReadLine());

            string Last_name;
            Console.WriteLine("Введите Фамилию");
            Last_name = Convert.ToString(Console.ReadLine());

            string Name;
            Console.WriteLine("Введите Имя");
            Name = Convert.ToString(Console.ReadLine());

            Employee Employee = new Employee(Work_experience, Skill_level, Last_name, Name);

           

            int w = Employee.getWork_experience();
            int s = Employee.getSkill_level();
            string l = Employee.getLast_name();
            string n = Employee.getName();


            Console.WriteLine("Cотрудник:");
            Console.WriteLine($"Имя - " + n);
            Console.WriteLine($"Фамилия - " + l);
            Console.WriteLine($"Cтаж работы - " + w);
            Console.WriteLine($"Уровень квалификации - " + s);
            Console.WriteLine($"Процент бонусов - этого я пока тебе не скажу. ");



        }
    }
}

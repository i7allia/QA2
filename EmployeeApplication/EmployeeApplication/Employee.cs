﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApplication
{
    class Employee
    {
        int Work_experience;
        int Skill_level;
        string Last_name;
        string Name;

        public Employee(int Work_experience, int Skill_level, string Last_name, string Name)
        {
            if ((Work_experience >= 0) & (Skill_level > 0) & (Skill_level < 6))
            {
                this.Work_experience = Work_experience;
                this.Skill_level = Skill_level;
                this.Last_name = Last_name;
                this.Name = Name;
            }
            else
            {
                Console.WriteLine("Сотрудник не создан по одной из причин: Проверьте поле 1. Опыт работы - не может быть отрицательным числом. Поле 2. Уровень квалификации - может быть чило только от 1-5. Все поля обязательны для заполнения");
                       

            }
        }
            public int getWork_experience()
            {
                return this.Work_experience;
            }
        public int getSkill_level()
        {
            return this.Skill_level;
        }


        public string getLast_name()
        {
            return this.Last_name;
        }
        public string getName()
        {
            return this.Name;
        }

    }
}

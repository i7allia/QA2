using System;
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
        int BonusPercent;

        public Employee(int Work_experience, int Skill_level, string Last_name, string Name)
        {
            this.Work_experience = Work_experience;
            this.Skill_level = Skill_level;
            this.Last_name = Last_name;
            this.Name = Name;
            /* while (true)
             {

                 if ((Work_experience >= 0) & (Skill_level > 0) & (Skill_level < 6))
             {
                 this.Work_experience = Work_experience;
                 this.Skill_level = Skill_level;
                 this.Last_name = Last_name;
                 this.Name = Name;
                     break;
                 }
             else
             {
                 Console.WriteLine("Сотрудник не создан по одной из причин: Проверьте поле 1. Опыт работы - не может быть отрицательным числом. Поле 2. Уровень квалификации - может быть чило только от 1-5. Все поля обязательны для заполнения");

                 Console.WriteLine("Повторить? y/n");
                 if (Console.ReadKey(true).Key != ConsoleKey.Y)

                     Environment.Exit(0);
                 }

             } */





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

        public int getBonusPercent()
       {
            if ((Work_experience) < 5 & (Work_experience > 0))
            {
                this.BonusPercent = 5;
            }


            else
            {
                if ((Work_experience >= 5) & (Skill_level < 3))
                {
                    this.BonusPercent = 10;
                }
                else

                {
                    if ((Work_experience > 5) & (Skill_level >= 3) & (Skill_level < 5))

                    { this.BonusPercent = 15; }

                    else
                  if ((Work_experience > 5) & (Skill_level > 4))

                    {
                        this.BonusPercent = 20;

                    }


                }

            }
            return this.BonusPercent;
        }

    }
}

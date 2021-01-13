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
                Console.WriteLine("Check the Field 1. Work experience - cannot be a negative number. Field 2. Skill level - can be chilo only from 1-5.!");
                this.Work_experience = -1;
                this.Skill_level = -1;

            }
        }
            public int getWork_experience()
            {
                return this.Work_experience;
            }

    }
}

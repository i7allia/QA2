using System;

namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee Employee = new Employee(1, 5, "Farrukhovich", "Dzhamshut");
            int w = Employee.getWork_experience();
            int s = Employee.getSkill_level();
            string l = Employee.getLast_name();
            string n = Employee.getName();

            Console.WriteLine(w);
            Console.WriteLine(s);
            Console.WriteLine(l);
            Console.WriteLine(n);


        }
    }
}

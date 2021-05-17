using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApplication
{
    class TestClass
    {
          


        [Test]
        public void checkExperienceLessThan0()
        {
          Employee empl = new Employee(0, 0, "Jhon", "Golt");
            Assert.IsTrue(empl.getBonusPercent() == 0);
         
        }

        [Test]
        public void checkExperienceLessThan4()
        {
            Employee empl = new Employee(4, 0, "Jhon", "Golt");
            Assert.IsTrue(empl.getBonusPercent() == 5);

        }

        [Test]
        public void checkExperienceLessThan5()
        {
            Employee empl = new Employee(5, 2, "Jhon", "Golt");
            Assert.IsTrue(empl.getBonusPercent() == 10);

        }

        [Test]
        public void checkExperienceLessThan6()
        {
            Employee empl = new Employee(6, 3, "Jhon", "Golt");
            Assert.IsTrue(empl.getBonusPercent() == 15);

        }

        [Test]
        public void checkExperienceLessThan7()
        {
            Employee empl = new Employee(6, 5, "Jhon", "Golt");
            Assert.IsTrue(empl.getBonusPercent() == 20);

        }

        [Test]
        public void checkExperienceLessThan8()
        {
            Employee empl = new Employee(-1, 5, "1", "Golt");
            Assert.IsTrue(empl.getBonusPercent() == 20);

        }

    }
}

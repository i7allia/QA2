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
    



}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MultileveInheritence
{
    public class Employee : Person
    {
        // Implementing Default constructor
        public Employee()
        {
            Console.WriteLine("This is the Employee class Constructor");
         }
       public void GetEmpId(int EmpId)
        {
            Console.WriteLine("Employee Id is: " + EmpId);
        }
    }
}

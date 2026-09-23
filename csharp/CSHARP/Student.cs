using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP
{
    internal class Student
    {
        private int roll;
        private String name;

        void accept(int roll, String name)
        {
            this.roll = roll;
            this.name = name;

        }
        void display()
        {
            Console.WriteLine("Roll Number is:{0} and name is {1}", roll, name);
        }
        public static void main(String[] args)
        {
            Student student1 = new Student();
            student1.accept(1001, "Aaditya");
            student1.display();


        }
    }
}

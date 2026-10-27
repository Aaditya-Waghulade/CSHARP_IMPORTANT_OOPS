using System;
using System.Collections.Generic;
using System.Text;

namespace MultileveInheritence
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("This is the person class Constructor");
        }
        public void Display(String name)
        {
            Console.WriteLine("Person Name: " + name);

        }
    }
}

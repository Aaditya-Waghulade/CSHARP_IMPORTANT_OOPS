using System;
using System.Collections.Generic;
using System.Text;

namespace MultileveInheritence
{
    internal class Developer : Employee
    {

        public Developer()
        {
            Console.WriteLine("This is the Developers class Constructor");
        }
        public void WriteCode()
        {
            Console.WriteLine("Developer writes code");
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSHARP
{
    internal class Arralist
    {
        public static void Main(string[] Args)
        {
            ArrayList arl = new ArrayList();
            //This are all methods available in the class ArrayList
            arl.Add(1); 
            arl.Add("JAVA");
            arl.Add(12.34);



            foreach(object i in arl) // Here Object is datatype which is helping to store comman datatype.
            {
                Console.WriteLine("The Data you have added is: " + i);
            }
        }
    }
}

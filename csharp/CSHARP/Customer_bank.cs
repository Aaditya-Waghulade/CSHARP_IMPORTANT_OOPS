using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP
{
    internal class Customer_bank

    {
        public static void Main(string[] args)
        {
            Bank obj = new BankImplementation();  // Hiding the Actual implementation by giving Address "Bank" which has the classes but the implementation is different
            obj.Credit(12000);
            obj.Debit(1000);



        }
    }

}
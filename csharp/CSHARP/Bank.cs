using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP
{
    abstract class Bank  //This is the Abstract Class but we have the abstract method "BankInfo" in here. 
    {
        internal int balance = 5000;

//Methods debit,credit,login

        abstract public void Credit(int amnt);
        abstract public void Debit(int amnt);

        abstract public bool Login(int code);


        abstract public void CheckBalance();
        void BankInfo()
        {
            Console.WriteLine("SBI Life Bank");
        }

    }
}

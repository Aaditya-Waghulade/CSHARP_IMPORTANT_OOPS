using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP
{

    internal class BankImplementation : Bank
    {
        public override void CheckBalance()

        {
            if (this.Login(1234))
            {
                Console.WriteLine("Balance:{0}", balance);
            }
            else
            {
                Console.WriteLine("Invalid Code");
            }
        }


        public override void Credit(int amnt)
        {
            if (this.Login(1234)) {
                balance += amnt;
            }
        else
            {
                Console.WriteLine("Invalid code");
            }
        }



        public override void Debit(int amnt)
        {
            if (this.Login(1234))
            {
                balance -= amnt;
            }
            else
            {
                Console.WriteLine("Invalid code");
            }
        }

        public override bool Login(int code)
        {
            if (code == 1234)
            {
                this.Credit(12000);
                this.Debit(1000);
                this.CheckBalance();
                return true;
            }
            else
            {
               return false;
            }

        }
    }
}
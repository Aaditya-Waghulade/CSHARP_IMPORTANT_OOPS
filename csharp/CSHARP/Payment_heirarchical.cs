using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Programmes
{
    internal class Payment_heirarchical
    {

        public static void Main(String[] Args)
        {
            // For the Paytm
            Payments payment = new Payments();
            Console.WriteLine(payment.Paytm());
            payment.Paytm();

            //For the Phonepay

            Phonepay phonepay = new Phonepay();
            Console.WriteLine(phonepay.PhonePay());

            // For the GooglePay

            Googlepay googlepay = new Googlepay();
            Console.WriteLine(googlepay.GooglePay());



        }
    }
}

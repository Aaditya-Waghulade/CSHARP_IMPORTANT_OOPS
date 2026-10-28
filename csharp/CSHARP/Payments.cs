using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Programmes
{
    public class Payments: Upi
    {
        public String Paytm()
        {
            return "Payment is made through PayTM";
        }
        
    }

    public class Phonepay():Upi
    {
        public String PhonePay()
        {
            return "Payment is made through Phonepay";
        }
    }
    public class Googlepay():Upi
    {
        public String GooglePay()
        {
            return "Payment is made through GooglePay";
        }
    }
}

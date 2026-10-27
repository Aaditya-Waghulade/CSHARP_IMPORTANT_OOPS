using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSHARP
{
    internal class Hash_table
    {
        public static void Main(String[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("s1", 10);
            ht.Add("s2", 11);
            ht.Add("s3", 12);


            foreach(DictionaryEntry entry in ht)
            {
                Console.WriteLine(entry.Key + "," + entry.Value);
            }

        }
    }
}

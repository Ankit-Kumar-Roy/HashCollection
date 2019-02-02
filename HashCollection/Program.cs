using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var ht = new Hashtable();
            ht.Add("EId", 1010);
            ht.Add("Ename", "Scott");
            ht.Add("Job", "Manager");
            ht.Add("Salary", 25000.00);
            ht.Add("MngId", 1002);
            ht.Add("Phone", "6203725170");
            ht.Add("Email", "royankit2011@gmail.com");
            ht.Add("Dname", "Sales");
            ht.Add("Location", "Mumbai");
            ht.Add("Did", 30);

            foreach (var key in ht.Keys)
            {                
                Console.WriteLine("{0}:  {1}", key, ht[key]);
            }
        }
    }
}

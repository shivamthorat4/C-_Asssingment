using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class addemployee
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("Aman");
            list.Add("Rinku");
            list.Add("Shivam");
            list.Add("Sanket");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("List of employees" + ':' + list[i]);
            }
            Console.WriteLine("Total Employess" + ':' + list.Count);
            Console.ReadLine();
        }
    }
}

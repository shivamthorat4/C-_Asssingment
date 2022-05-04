   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Search
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("Shivam");
            list.Add("Sanket");
            list.Add("Rinku");
            list.Add("Sagar");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("List of employees" + ':' + list[i]);
            }
            Console.WriteLine("total number of employess" + ':' + list.Count);
            
            Console.WriteLine("enter person name:");
            string search = Console.ReadLine();
            
            if (list.Contains(search))
            {
                Console.WriteLine("Yes " + search + " is an employee of the company");
            }
            else
            {
                Console.WriteLine(search + " not an employee of the company");
            }



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal { get; set; }
        public string EmpLoc { get; set; }


    }

    internal class ArrayListSample
    {
        static void Main(string[] args)
        {
            //object initilizer or collection initilizer
            //ArrayList e = new ArrayList();//non generic

            ArrayList e = new ArrayList()
            {
                    new Employee{EmpId=1,EmpName="saekumaar",EmpSal=20000,EmpLoc="Hyd"},
                    new Employee{EmpId=2,EmpName="Rama",EmpSal=25000,EmpLoc="Hyd"},
                    new Employee{EmpId=3,EmpName="Krishna",EmpSal=32000,EmpLoc="Hyd"},
                    new Employee{EmpId=3,EmpName="Shiva",EmpSal=40000,EmpLoc="Hyd"},
                    new Employee{ EmpId=4, EmpName="Vignesh"},
            };
            foreach (Employee i in e)
            {
                    Console.WriteLine(i.EmpId + " " + i.EmpName + " " + i.EmpSal + " " + i.EmpLoc);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Calc
    {
        internal class Calculation
        {
            static void Main(string[] args)
            {
                Console.Write("Enter No1: ");
                int a = Convert.ToInt16(Console.ReadLine());
                //Reading Second Number  
                Console.Write("Enter No2: ");
                int b = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Divsion");
                Console.WriteLine("4.Multiplication");
                //Reading a Choice  
                int c = Convert.ToInt16(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("Addition is: " + (a + b));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction is: " + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("Division is: " + (a / b));
                        break;
                    case 4:
                        Console.WriteLine("Multiplicaion is : " + (a * b));
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                Console.ReadLine();

            }
        }
    }
}

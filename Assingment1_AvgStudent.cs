using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator

    
    {
        static void getStudList(string[] file)
        {
            int avgScore;
            int maxAvgScore = Int32.MinValue;
            List<string> names = new List<string>();
            for (int i = 0; i < file.Length; i += 4)
            {
                avgScore = (Int32.Parse(file[i + 1]) +
                            Int32.Parse(file[i + 2]) +
                        Int32.Parse(file[i + 3])) / 3;

                if (avgScore > maxAvgScore)
                {
                    maxAvgScore = avgScore;
                    names.Clear();
                    names.Add(file[i]);
                }

                else if (avgScore == maxAvgScore)
                    names.Add(file[i]);
            }


            for (int i = 0; i < names.Count; i++)
            {
                Console.Write(names[i] + " ");
            }

            Console.WriteLine(maxAvgScore);
        }

        public static void Main()s
        {
            string[] file = { "Shivam", "87", "70", "45", "Sanjay", "52", "78", "87", "Rinku", "43", "65", "65", "Sagar", "37", "43", "53" };
            getStudList(file);
        }
    }



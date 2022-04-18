using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace fileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir = @"C:\Shivm\FileIO";
            string subdir1 = @"C:\Shivam\FileIO\Write";
            string subdir2 = @"C:\Shivam\FileIO\Read";
            string srcFilepath = @"C:\Shivam\FileIO\Write\myFile.txt";
            string desFilepath = @"C:\Shivam\FileIO\Read\myFile.txt";
            Directory.CreateDirectory(dir);
            Directory.CreateDirectory(subdir1);
            Directory.CreateDirectory(subdir2);

            DirectoryInfo ds = new DirectoryInfo(subdir2);
            //create file and write
            FileStream fs = File.Create(srcFilepath);
            string[] lines = { "Shivam", "shivam@gmail.com", "Pune" };
            StreamWriter sw = new StreamWriter(fs);
            foreach (string s in lines)
            {
                sw.WriteLine(s);
            }
            sw.Close();
            // read and write on console
            string[] line = File.ReadAllLines(srcFilepath);
            foreach (string s in line)
            {
                Console.WriteLine(s);
            }
            File.Copy(srcFilepath, desFilepath, true);
            Console.ReadLine();
        }
    }
}




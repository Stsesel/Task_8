using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\sergkwork\OneDrive\Autodesk_ITMO_2021";
            string[] dirs = Directory.GetDirectories(path);
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }

            string[] files = Directory.GetFiles(path);

            Console.WriteLine();

            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

        }

    }


}

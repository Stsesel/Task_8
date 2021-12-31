using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }



            string path2 = "Logs/Number.txt";
            if (!File.Exists(path2))
            {
                File.Create(path2);
            }


            int sum = 0;
            int num = 0;

            string path3 = "Logs/Number.txt";
            using (StreamWriter sw = new StreamWriter(path3))
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    num = rnd.Next(-100, 101);
                    Console.WriteLine("{0,4}", num);
                    sw.WriteLine("{0,4}", num);
                    sum = sum + num;
                }

            }
            Console.WriteLine("Cумма десяти случайных чисел равна = {0}", sum);
            Console.ReadKey();
        }




    }
}

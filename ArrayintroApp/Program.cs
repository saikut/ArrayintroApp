using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayintroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            number [0]= 15;
            number[1] = 95;
            number[2] = 85;
           Array.Sort(number);

            Console.WriteLine("length : " +number.Length);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.WriteLine();
            foreach (int num in number)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}

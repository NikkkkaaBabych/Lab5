using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; int[] veight, growth;
            Console.WriteLine("Enten number of staff");
            n = Convert.ToInt32(Console.ReadLine());
            veight = new int[n];
            growth = new int[n];
            Random rnd = new Random();
            for (int i=0; i < n; i++)
            {
                veight[i] = rnd.Next(50, 120);
                growth[i] = rnd.Next(150, 200);
            }
            Array.Sort(growth, veight);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("employee #{0}: growth {1}, veight {2}", i + 1, growth[i], veight[i]);
            }
            Console.ReadKey();
        }
    }
}

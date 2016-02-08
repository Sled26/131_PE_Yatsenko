using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131_PE_Yatsenko
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Double b;
            Console.Write("Выручка за сегодня:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a <= 10000)
                Console.WriteLine(b = a * 0.01 * 5);
            else
                Console.WriteLine(b = 10000 * 0.01 * 5 + (a - 10000) * 0.01 * 10);
            if (b <= 300)
                Console.WriteLine(b = 300);
            Console.ReadLine();
        }
    }
}

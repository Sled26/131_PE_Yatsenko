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
            int c;
            Console.Write("Какой день недели? 1 - будний день. 2 - выходные ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выручка за сегодня:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a <= 10000)
                Console.WriteLine(b = a * 0.01 * 5 * c);
            if (a >= 100000)
                Console.WriteLine(b = a * 0.15 * c);
            else
                Console.WriteLine(b = 10000 * 0.01 * 5 * c + (a - 10000) * 0.01 * 10 * c);
            if (b <= 300)
                Console.WriteLine(b = 300);
            Console.ReadLine();
        }
    }
}

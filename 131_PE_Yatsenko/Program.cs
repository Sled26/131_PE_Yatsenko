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
            int q;
            int w;
            int e;
            int r;
            int t;
            int y;
            int u;
            Double summ1;
            Double summ2;
            Double summ3;
            Double summ4;
            Double summ5;
            Double summ6;
            Double summ7;
            int pon;
            int vtor;
            int sreda;
            int chetverg;
            int pyatnizza;
            int subbota;
            int voskresenie;
            Console.Write("Выручка за первый день:");
            pon = Convert.ToInt32(Console.ReadLine());
            if (pon > 0)
                Console.WriteLine(q = 1);
            else
            {
                Console.WriteLine(q = 0);
            }
            if (pon <= 10000)
                Console.WriteLine(summ1 = pon * 0.01 * 5);
            if (pon >= 100000)
                Console.WriteLine(summ1 = pon * 0.15);
            else
                Console.WriteLine(summ1 = 10000 * 0.01 * 5 + (pon - 10000) * 0.01 * 10);
            if (summ1 <= 300)
                Console.WriteLine(summ1 = 300);
            if (pon <= 0)
            Console.WriteLine(summ1 = 0);
            Console.Write("Выручка за второй день:");
            vtor = Convert.ToInt32(Console.ReadLine());
            if (vtor > 0)
                Console.WriteLine(w = 1);
            else
            {
                Console.WriteLine(w = 0);
            }
            if (vtor <= 10000)
                Console.WriteLine(summ2 = vtor * 0.01 * 5 );
            if (vtor >= 100000)
                Console.WriteLine(summ2 = vtor * 0.15 );
            else
                Console.WriteLine(summ2 = 10000 * 0.01 * 5 + (vtor - 10000) * 0.01 * 10);
            if (summ2 <= 300)
                Console.WriteLine(summ2 = 300);
            if (vtor <= 0)
            Console.WriteLine(summ2 = 0);
            Console.Write("Выручка за третий день:");
            sreda = Convert.ToInt32(Console.ReadLine());
            if (sreda > 0)
                Console.WriteLine(e = 1);
            else
            {
                Console.WriteLine(e = 0);
            }
            if (sreda <= 10000)
                Console.WriteLine(summ3 = sreda * 0.01 * 5);
            if (sreda >= 100000)
                Console.WriteLine(summ3 = sreda * 0.15);
            else
                Console.WriteLine(summ3 = 10000 * 0.01 * 5 + (sreda - 10000) * 0.01 * 10);
            if (summ3 <= 300)
                Console.WriteLine(summ3 = 300);
            if (sreda <= 0)
            Console.WriteLine(summ3 = 0);
            Console.Write("Выручка за четвертый день:");
            chetverg = Convert.ToInt32(Console.ReadLine());
            if (chetverg > 0)
                Console.WriteLine(r = 1);
            else
            {
                Console.WriteLine(r = 0);
            }
            if (chetverg <= 10000)
                Console.WriteLine(summ4 = chetverg * 0.01 * 5);
            if (chetverg >= 100000)
                Console.WriteLine(summ4 = chetverg * 0.15);
            else
                Console.WriteLine(summ4 = 10000 * 0.01 * 5 + (chetverg - 10000) * 0.01 * 10);
            if (summ4 <= 300)
                Console.WriteLine(summ4 = 300);
            if (chetverg <= 0)
            Console.WriteLine(summ4 = 0);
            Console.Write("Выручка за пятый день:");
            pyatnizza = Convert.ToInt32(Console.ReadLine());
            if (pyatnizza > 0)
                Console.WriteLine(t = 1);
            else
            {
                Console.WriteLine(t = 0);
            }
            if (pyatnizza <= 10000)
                Console.WriteLine(summ5 = pyatnizza * 0.01 * 5);
            if (pyatnizza >= 100000)
                Console.WriteLine(summ5 = pyatnizza * 0.15);
            else
                Console.WriteLine(summ5 = 10000 * 0.01 * 5 + (pyatnizza - 10000) * 0.01 * 10);
            if (summ5 <= 300)
                Console.WriteLine(summ5 = 300);
            if (pyatnizza <= 0)
            Console.WriteLine(summ5 = 0);
            Console.Write("Выручка за шестой день:");
            subbota = Convert.ToInt32(Console.ReadLine());
            if (subbota > 0)
                Console.WriteLine(y = 1);
            else
            {
                Console.WriteLine(y = 0);
            }
            if (subbota <= 10000)
                Console.WriteLine(summ6 = subbota * 0.01 * 5);
            if (subbota >= 100000)
                Console.WriteLine(summ6 = subbota * 0.15);
            else
                Console.WriteLine(summ6 = 10000 * 0.01 * 5 + (subbota - 10000) * 0.01 * 10);
            if (summ6 <= 300)
                Console.WriteLine(summ6 = 300);
            if (subbota <= 0)
            Console.WriteLine(summ6 = 0);
            Console.Write("Выручка за седьмой день:");
            voskresenie = Convert.ToInt32(Console.ReadLine());
            if (voskresenie > 0)
                Console.WriteLine(u = 1);
            else
            {
                Console.WriteLine(u = 0);
            }
            if (voskresenie <= 10000)
                Console.WriteLine(summ7 = voskresenie * 0.01 * 5);
            if (voskresenie >= 100000)
                Console.WriteLine(summ7 = voskresenie * 0.15);
            else
                Console.WriteLine(summ7 = 10000 * 0.01 * 5 + (voskresenie - 10000) * 0.01 * 10);
            if (summ7 <= 300)
                Console.WriteLine(summ7 = 300);
            if (voskresenie <= 0)
            Console.WriteLine(summ7 = 0);
            if (q+w+e+r+t+y+u >= 6)
                Console.WriteLine (summ6 = summ6*2);
            else
            {
                Console.WriteLine (summ6 = summ6*1);
            }
            if (q + w + e + r + t + y + u >= 6)
                Console.WriteLine(summ7 = summ7 * 2);
            else
            {
                Console.WriteLine(summ7 = summ7 * 1);
            }
            Console.Write("Зарплата сотрудника составляет:");
            Console.WriteLine(summ1 + summ2 + summ3 + summ4 + summ5 + summ6 + summ7);

            Console.ReadLine();
        }
    }
}

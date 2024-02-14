using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int n = 5;
            int i;
            double factor;
            double eps = 0.0001;
            double F = eps + 1.0; //модуль
            double Sum = 0;
            while (eps <= F)
            {
                for (i = 2, factor = 1; i <= n; i++)
                    factor *= i;
                F = (Math.Pow(-1, n) * Math.Pow(x, n)) / Fact(factor);
                Sum += F;
                if (F < 0)//Узнаем модуль
                    F *= -1;
                n++;
            }
            Console.WriteLine(Sum);
        }
        public static double Fact(double n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
    }
}

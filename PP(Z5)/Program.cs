using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Z5_
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                //если х не попадает в область определения, то генерируется исключение 
                if (x == 1 || x == 0.25) throw new Exception();
                else return 1 / (x-1) + 2/(1-4*x);
            }
            catch
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите начало интервала (а): ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите конец интервала (b): ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Введите шаг (h): ");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine();
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0}) = {1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0}) = ERROR", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных!");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка!");
            }
            Console.ReadKey();
        }

    }
}

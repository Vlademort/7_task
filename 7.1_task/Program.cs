using System;

namespace _7._1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону 1-го треугольника a1 = ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону 1-го треугольника b1 = ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону 1-го треугольника c1 = ");
            double c1 = Convert.ToDouble(Console.ReadLine());

            double S1 = AreaTriangle(a1, b1, c1);
            Console.WriteLine("Площадь 1-го треугольника S1 = {0}", S1);
            Console.WriteLine();

            Console.Write("Введите сторону 2-го треугольника a2 = ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону 2-го треугольника b2 = ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону 2-го треугольника c2 = ");
            double c2 = Convert.ToDouble(Console.ReadLine());

            double S2 = AreaTriangle(a2, b2, c2);
            Console.WriteLine("Площадь 2-го треугольника S2 = {0}", S2);
            Console.WriteLine();

            if (S1 == S2)
            {
                Console.WriteLine("Треугольники равны");
            }
            else if (S1 > S2)
            {
                Console.WriteLine("Площадь 1-го треугольники больше площади 2-го треугольника");
            }
            else
            {
                Console.WriteLine("Площадь 2-го треугольники больше площади 1-го треугольника");
            }
            Console.ReadKey();
        }

        static double AreaTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
}

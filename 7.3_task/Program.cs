using System;

namespace _7._3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            double square, volume;
            Console.Write("Введите длину ребра куба: ");
            double cube_edge = Convert.ToDouble(Console.ReadLine());
            СubeVolumeSquare(cube_edge, out square, out volume);

            Console.ReadKey();
        }

        static void СubeVolumeSquare(double E, out double S, out double V)
        {
            S = Math.Pow(E, 2) * 6;
            V = Math.Pow(E, 3);
            Console.WriteLine("Площадь куба S = {0}", S);
            Console.WriteLine("Объем куба V = {0}", V);            
        }

    }
    
}

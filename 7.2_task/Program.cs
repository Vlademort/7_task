using System;

namespace _7._2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба: ");
            double cube_edge = Convert.ToDouble(Console.ReadLine());
            СubeVolumeSquare(cube_edge);

            Console.ReadKey();
        }

        static void СubeVolumeSquare(double cube_edge)
        {
            double volume = cube_edge * cube_edge * cube_edge;
            double square = cube_edge * cube_edge * 6;
            Console.WriteLine("Объем куба V = {0}", volume);
            Console.WriteLine("Площадь куба S = {0}", square);
        }
    }
}

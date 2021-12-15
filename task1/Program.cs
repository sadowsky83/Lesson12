using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Статический класс. Окружность
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности (число > 0)");
            double r = input();
            Console.WriteLine("Введите координату X центра окружности");
            double x0 = input();
            Console.WriteLine("Введите координату Y центра окружности");
            double y0 = input();
            Console.WriteLine("Введите координату X точки A");
            double x1 = input();
            Console.WriteLine("Введите координату Y точки A");
            double y1 = input();
            Circle.length(r);
            Circle.Area(r);
            Circle.PointAffiliation(r, x0, y0, x1, y1);
            Console.ReadLine();
        }
        public static double input()
        {
            double x = 0;
            try
            {
                x = (Convert.ToDouble(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return x;
        }

        public static class Circle
        {
            static public void length(double r)
            {
                Console.WriteLine("Длинна окружности с радиусом {0} = " + Math.Round(2 * r * Math.PI, 2), r);
            }

            static public void Area(double r)
            {
                Console.WriteLine("Площадь окружности с радиусом {0} = " + Math.Round(Math.Pow(r * Math.PI, 2), 2), r);
            }

            static public void PointAffiliation(double r, double x0, double y0, double x1, double y1)
            {
                double d = Math.Sqrt(Math.Pow(x0 - x1, 2) + Math.Pow(y0 - y1, 2));
                if (d <= r)
                {
                    Console.WriteLine("Точка A лежит в круге.");
                }
                else
                {
                    Console.WriteLine("Точка A лежит вне круга.");
                }
            }
        }
    }
}

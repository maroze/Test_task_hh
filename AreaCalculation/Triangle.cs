using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Triangle : Geometry
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Метод вычисления площади треугольника по трем сторонам (формула Герона)
        /// </summary>
        /// <returns>площадь треугольника</returns>
        public override double Calculate()
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if ((a + b > c) && (a + c > b) && (b + c > a))
                {
                    double p = (a + b + c) / 2;
                    double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                    if (area != 0)
                    {
                        return Math.Round(area, 2);
                    }
                    else
                        throw new Exception("Треугольник с нулевой площадью не существует");
                }
                else
                    throw new Exception("Треугольник не существует, т.к сумма любых двух его сторон меньше третьей стороны");
            }
            else
                throw new Exception("Введите число больше 0");
        }

        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        /// <param name="a">первая сторона</param>
        /// <param name="b">вторая сторона</param>
        /// <param name="c">третяя сторона</param>
        /// <returns>true если треугольник прямоугольный</returns>
        public bool RightTriangle()
        {
            double[] numbers = new double[] { a, b, c };
            Array.Sort(numbers);

            if ((Math.Pow(numbers[0], 2) + Math.Pow(numbers[1], 2)) == Math.Pow(numbers[2], 2))
            {
                return true;
            }
            else
                return false;
        }
    }
}

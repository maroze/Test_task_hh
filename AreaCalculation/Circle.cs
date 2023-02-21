using System;

namespace AreaCalculation
{
    public class Circle : Geometry
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Метод вычисления площади круга по радиусу
        /// </summary>
        /// <returns>площадь круга</returns>
        public override double Calculate()
        {
            if (radius > 0)
            {
                double area = Math.PI * Math.Pow(radius, 2);

                return Math.Round(area,2);
            }
            else
                throw new Exception("Введите число больше 0"); ;
            
        }
    }
}

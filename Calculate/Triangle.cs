using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Triangle
    {
        double OneSide, TwoSide, ThreeSide, catheterOne, catheterTwo, hypotenuse;

        public Triangle(double OneSide, double TwoSide, double ThreeSide)
        {
            this.OneSide = OneSide;
            this.TwoSide = TwoSide;
            this.ThreeSide = ThreeSide;
        }

        public double PerimetrCalculate() // подсчет периметра треугольника
        {
            return OneSide + TwoSide + ThreeSide;
        }

        public double Perimetr 
        {
            get { return this.PerimetrCalculate(); }
        }

        public double SquartCalculate() // подсчет площади треугольника
        {
            var HalfMeterTriangle = (OneSide + TwoSide + ThreeSide) / 2; // вычисление полупериметра
            var pTriangle = HalfMeterTriangle * (HalfMeterTriangle - OneSide) * (HalfMeterTriangle - TwoSide) * (HalfMeterTriangle - ThreeSide); // умножение полупериметра на разности полуперитметра с тремя сторонами треугольника
            var sqrtTriangle = Math.Sqrt(pTriangle);

            return HalfMeterTriangle;
        }

        public double Squart
        {
            get { return this.SquartCalculate(); }
        }

        public double FindHypotenuse() // нахождение гипотенузы
        {
            catheterOne = 0;
            catheterTwo = 0;
            hypotenuse = 0;

            if (OneSide > TwoSide && OneSide > ThreeSide)
            {
                hypotenuse = OneSide; catheterOne = TwoSide; catheterTwo = ThreeSide;
            }

            else if (TwoSide > OneSide && TwoSide > ThreeSide)
            {
                hypotenuse = TwoSide; catheterOne = OneSide; catheterTwo = ThreeSide;
            }

            else if(ThreeSide > OneSide && ThreeSide > TwoSide)
            {
                hypotenuse = ThreeSide; catheterOne = OneSide; catheterTwo = TwoSide;
            }

            return hypotenuse;
        }

        public string RectangularTriangle
        {
            get
            {
                FindHypotenuse();
                if (Math.Pow(hypotenuse, 2) == Math.Pow(catheterOne, 2) + Math.Pow(catheterTwo, 2))
                {
                    return "Треугольник прямоугольный.";
                }

                else return "Извините, но треугольник не прямоугольный.";
            }
        }
    }
}

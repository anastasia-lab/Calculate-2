using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Curcle
    {
        double radius, degree;

        public Curcle(double radius, double degree)
        {
            this.radius = radius;
            this.degree = degree;
        }

        public double Length() //нахождение длины дуги
        {
            var length = (Math.PI * radius * degree) / 180;
            return length;
        }

        public double ArcLength //длина дуги
        {
            get { return Length(); }
        }

        public double Circle() //нахождение длины окружности
        {
            var circle = 2 * Math.PI * radius;
            return circle;
        }

        public double ArcCircle //длина окружности
        {
            get { return Circle(); }
        }

        public double Sector() // нахождение площади сектора
        {
            var sector = (Math.PI * Math.Pow(radius, 2) * degree) / 360;
            return sector;
        }

        public double SqrtSector // площадь сектора
        {
            get { return Sector(); }
        }

        public double Sqrt() // нахождение площаи круга
        {
            var sqrt = Math.PI * Math.Pow(radius,2);
            return sqrt;
        }

        public double SqrtCircle // площадь круга
        {
            get { return Sqrt(); }
        }

        public double Sphere() // нахождение площади сферической поверхности
        {
            var sphere = 4 * Math.PI * Math.Pow(radius,2);
            return sphere;
        }

        public double SqrtSphere // площадь сферической поверхности
        {
            get { return Sphere(); }
        }

        public double Ball() // нахождение объёма шара
        {
            var ball = ((4 / 3)*(Math.PI * Math.Pow(radius, 3)));
            return ball;
        }

        public double VolumeBall // объем шара
        {
            get { return Ball(); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте. Пожалуйста, выберите фигуру. \n");
            Console.Write("1 - круг/сфера/шар;  2 - треугольник\n\n");
            Console.Write("Ваш выбор: ");

            try
            { 
                double choose = Convert.ToDouble(Console.ReadLine());

                if (choose == 1)
                {
                    Console.Write("\nВведите радиус круга: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите градус угла: ");
                    double degree = Convert.ToDouble(Console.ReadLine());

                    if (radius <= 0 && degree <= 0)
                        Console.Write("Извените, но радиус и градус должны быть больше 0.");
                    else if (radius > 0 && degree > 0)
                    {
                        Curcle Circle = new Curcle(radius, degree);

                        Console.Write("\nЧто Вы хотите найти: 1 - длину дуги; 2 - длину окружности; 3 - площадь сектора; 4 - площадь круга, 5 - площадь сферической поверхности, 6 - объем шара.\n");
                        Console.Write("Ваш выбор: ");
                        try
                        {
                            var YourChooseCircle = Convert.ToDouble(Console.ReadLine());

                            if (YourChooseCircle == 1)
                                Console.WriteLine("\nДлина дуги равна = {0}", Circle.ArcLength);
                            if (YourChooseCircle == 2)
                                Console.WriteLine("\nДлина окружности равна = {0}", Circle.ArcCircle);
                            if (YourChooseCircle == 3)
                                Console.WriteLine("\nПлощадь сектора равна = {0}", Circle.SqrtSector);
                            if (YourChooseCircle == 4)
                                Console.WriteLine("\nПлощадь круга равна = {0}", Circle.SqrtCircle);
                            if (YourChooseCircle == 5)
                                Console.WriteLine("\nПлощадь сферической поверхности равна = {0}", Circle.SqrtSphere);
                            if (YourChooseCircle == 6)
                                Console.WriteLine("\nОбъем шара равен = {0}", Circle.VolumeBall);
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex.Message);
                        }
                    }
                }

                if (choose == 2)
                {

                    Console.Write("Пожалуйста, введите стороны треугольника. \n");
                    Console.Write("Сторона один: ");
                    double OneSide = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Сторона два: ");
                    double TwoSide = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Сторона три: ");
                    double ThreeSide = Convert.ToDouble(Console.ReadLine());

                    if (OneSide <= 0 && TwoSide <= 0 && ThreeSide <= 0)
                        Console.Write("Извените, но стороны треугольника должны быть долше 0.");
                    else if (OneSide > 0 && TwoSide > 0 && ThreeSide > 0)
                    {
                        var Triangle = new Triangle(OneSide, TwoSide, ThreeSide);

                        Console.Write("\nВыбирите, что вы хотите сделать: 1 - вычислить периметр треугольника, 2 - вычислить площадь треугольника, 3 - определить, является ли Ваш треугольник прямоугольным. ");
                        Console.Write("\nВаш выбор: ");
                        try
                        {
                            var YourChoice = Convert.ToInt32(Console.ReadLine());

                            if (YourChoice == 1)
                                Console.WriteLine("\nПериметр Вашего треугольника равен = {0}.", Triangle.Perimetr);
                            if (YourChoice == 2)
                                Console.WriteLine("\nПлощадь Вашего треугольника равна = {0}.", Triangle.Squart);
                            if (YourChoice == 3)
                                Console.WriteLine(Triangle.RectangularTriangle);
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write("\nВнимание!!!\n");
                Console.Write(ex.Message);
            }
                Console.ReadKey();
        }
    }
}

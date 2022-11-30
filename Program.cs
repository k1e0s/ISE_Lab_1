using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jla6a_TTporpammupoBaHue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эксперимент номер 111");

            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Point p1 = new Point(a, b);
            Point p2 = new Point(20, 40);
            Point p3 = new Point(p1);
            Point p4 = p2.Clone();


            Console.WriteLine(p1.Position);
            Console.WriteLine(p2.Position);
            Console.WriteLine(p3.Position);
            Console.WriteLine(p4.Position);





            Console.WriteLine('\n');
            Console.WriteLine("Эксперимент номер 222");


            List<int> numbers = new List<int>();
            for (int i = 1; i < 6; i++)
            {
                numbers.Add(i);
            }
            foreach (int el in numbers)
                Console.WriteLine(el);
            numbers.RemoveAt(1);
            numbers.RemoveAt(2);
            Console.WriteLine("--");
            foreach (int el1 in numbers)
                Console.WriteLine(el1);





            Console.WriteLine('\n');
            Console.WriteLine("Эксперимент номер 333");

            Rectangle r1 = new Rectangle(0, 10, 5, 0);

            Console.WriteLine(r1.Position);
            Console.WriteLine("Периметр прямоугольника = " + r1.Perimeter);
            Console.WriteLine("Площадь прямоугольника = " + r1.Area);
        }
    }
}
namespace Jla6a_TTporpammupoBaHue
{

    class Rectangle
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }

        public Rectangle()
        {
            X1 = 0;
            Y1 = 0;
            X2 = 0;
            Y2 = 0;
        }

        public Rectangle(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public string Position
        {
            get { return "X1 = " + X1 + ", Y1 = " + Y1 + ", X2 = " + X2 + ", Y2 = " + Y2; }
        }

        public double Perimeter
        {
            get { return (X2 - X1) * 2 + (Y1 - Y2) * 2; }
        }

        public double Area
        {
            get { return (X2 - X1) * (Y1 - Y2); }
        }
    }


    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
        }

        public Point Clone()
        {
            return new Point(X, Y);
        }

        public string Position
        {
            get { return "X = " + X + ", Y = " + Y; }
        }
    }

}
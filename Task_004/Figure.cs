using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Figure
    {
        private Point[] coordList;
        private string name;
        
        public string Name { get => name; }

        public Figure(Point p1, Point p2, Point p3)
        {
            coordList = new Point[3];

            coordList[0] = p1;
            coordList[1] = p2;
            coordList[2] = p3;
            name = "треугольник";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            coordList = new Point[4];

            coordList[0] = p1;
            coordList[1] = p2;
            coordList[2] = p3;
            coordList[3] = p4;
            name = "прямоугольник";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            coordList = new Point[5];

            coordList[0] = p1;
            coordList[1] = p2;
            coordList[2] = p3;
            coordList[3] = p4;
            coordList[4] = p5;  
            name = "пятиугольник";
        }

        public double LengthSide(Point A, Point B) => Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.Y), 2));

        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < coordList.Length - 1; i++)
            {
                sum += LengthSide(coordList[i], coordList[i + 1]);
            }

            sum += LengthSide(coordList[coordList.Length - 1], coordList[0]);
            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Rectangle
    {
        private double side1;
        private double side2;
        private double area;
        private double perimeter;

        public Rectangle(double side1, double side2)
        {
            this.side1=side1;
            this.side2=side2;
        }

        public double Area { get => area; }

        public double Perimeter { get => perimeter; }

        public double AreaCalculator()
        {
            area = side1 * side2;
            return Area; 
        }

        public double PerimtereCalculator()
        {
            perimeter = 2 * (side1 + side2);
            return Perimeter;
        }
    }
}

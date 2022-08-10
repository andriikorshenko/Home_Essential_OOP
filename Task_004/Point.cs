using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Point
    {
        private int x;
        private int y;
        private string name; 

        public int X { get => x; }

        public int Y { get => y; }

        public string Name { get => name; }

        public Point(string name, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_namespace
{
    class Triangle
    {
        int x1, y1, x2, y2, x3, y3;

        public Triangle()
        {
            x1 = 0;
            x2 = 0;
            x3 = 0;
            y1 = 0;
            y2 = 0;
            y3 = 0;
        }
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
        }
        public override string ToString()
        {
            return $"Triangle.\ncoordinates - ({x1}, {y1}), ({x2}, {y2}), ({x3}, {y3})\n";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_namespace
{
    class Square
    {
        int x, y, w;

        public Square()
        {
            x = 0;
            y = 0;
            w = 0;
        }
        public Square(int x, int y, int w)
        {
            this.x = x;
            this.y = y;
            this.w = w;
        }
        public override string ToString()
        {
            return $"Square.\nx,y - ({x}, {y})\nwidth - {w}\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_namespace
{
    class Rectangle
    {
        int x, y, w, h;

        public Rectangle()
        {
            x = 0;
            y = 0;
            w = 0;
            h = 0;
        }
        public Rectangle(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }
        public override string ToString()
        {
            return $"Rectangle.\nx,y - ({x}, {y})\nwidth - {w}\nheight{h}\n";
        }
    }
}
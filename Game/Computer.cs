using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_namespace
{
    class Computer
    {
        Random r;
        public Computer()
        {
            r = new Random(DateTime.Now.Millisecond);
        }
        public int Guess(int a, int b)
        {
            return r.Next(a, b);
        }
    }
}

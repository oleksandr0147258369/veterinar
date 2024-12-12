using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Field_namespace;

namespace ComputerI_namespace
{
    class Computer
    {
        Random r;
        public Computer()
        {
            r = new Random(DateTime.Now.Millisecond);
        }
        public int[] Guess(Field f)
        {
            int[] k = new int[2];
            do 
            {
                k[0] = r.Next(0, 3);
                k[1] = r.Next(0, 3); 
            }
            while (!f.IsEmpty(k[0], k[1]));
            return k;
        }
    }
}

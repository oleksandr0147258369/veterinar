using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_namespace
{
    public class Odd
    {
        int[] arr;
        int size;

        public Odd()
        {
            size = 0;
            arr = new int[size];
        }
        public Odd(int size)
        {
            this.size = size;
            arr = new int[size];
            for (int i = 0; i < this.size; i++) arr[i] = i * 2 + 1;
        }
        public override string ToString()
        {
            string res = "";
            foreach (int a in arr)
            {
                res += a.ToString() + " ";
            }
            res += "\n";
            return res;
        }
    }
}
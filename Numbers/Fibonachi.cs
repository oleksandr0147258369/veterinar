using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi_namespace
{
    public class Fibonachi
    {
        int[] arr;
        int size;

        public Fibonachi()
        {
            size = 0;
            arr = new int[size];
        }
        public Fibonachi(int size)
        {
            this.size = size;
            arr = new int[size];
            arr[0] = 0;

            if (this.size > 1)
            {
                arr[1] = 1;

                for (int i = 2; i < this.size; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }
            }
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
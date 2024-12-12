using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_namespace
{
    public class Even
    {
        int[] arr;
        int size;

        public Even()
        {
            size = 0;
            arr = new int[size];
        }
        public Even(int size)
        {
            this.size = size;
            arr = new int[size];
            for (int i = 0; i < this.size; i++) arr[i] = i * 2;
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
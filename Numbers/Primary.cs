using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary_namespace
{
    public class Primary
    {
        int[] arr;
        int size;

        public Primary()
        {
            size = 0;
            arr = new int[size];
        }
        public Primary(int size)
        {
            this.size = size;
            arr = new int[size];
            int count = 0;
            int num = 2;
            while (count < this.size)
            {
                if (IsPrime(num))
                {
                    arr[count] = num;
                    count++;
                }
                num++;
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

        bool IsPrime(int num)
        {
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
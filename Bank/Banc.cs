using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Banc_namespace
{
    class Banc
    {
        List<int[]> arr;
        public Banc() { arr = new List<int[]>(); }
        public void AddAccount(int num) { arr.Add(new int[2]{ num, 0}); }
        public void AddAccount(int num, int money) { arr.Add(new int[2] { num, money }); }
        public void AddMoney(int num, int money) { foreach (int[] a in arr) if (a[0] == num) a[1] += money; }
        public bool MinusMoney(int num, int money) 
        { 
            foreach (int[] a in arr) 
            { 
                if (a[0] == num) 
                {
                    if (a[1] >= money)
                    {
                        a[1] -= money;
                        return true;
                    }
                    else return false; 
                } 
            }
            return false;
        }
        public int GetMoney(int num)
        {
            foreach(int[] a in arr)
            {
                if (a[0] == num) return a[1];
            }
            return -1;
        }
    }
}

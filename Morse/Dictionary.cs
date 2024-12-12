using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_namespace
{
    class Dict
    {
        string[,] arr;
        public Dict()
        {
            arr = new string[37, 2] {{ "A", ".-" }, { "B", "-..." }, { "C", "-.-." }, { "D", "-.." },
            { "E", "." }, { "F", "..-." }, { "G", "--." }, { "H", "...." },
            { "I", ".." }, { "J", ".---" }, { "K", "-.-" }, { "L", ".-.." },
            { "M", "--" }, { "N", "-." }, { "O", "---" }, { "P", ".--." },
            { "Q", "--.-" }, { "R", ".-." }, { "S", "..." }, { "T", "-" },
            { "U", "..-" }, { "V", "...-" }, { "W", ".--" }, { "X", "-..-" },
            { "Y", "-.--" }, { "Z", "--.." }, { "1", ".----" }, { "2", "..---" },
            { "3", "...--" }, { "4", "....-" }, { "5", "....." }, { "6", "-...." },
            { "7", "--..." }, { "8", "---.." }, { "9", "----." }, { "0", "-----" },
            { " ", " " } };
        }
        public string GetLat(string m)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                if (m == arr[i, 1]) return arr[i, 0];
            }
            return "";
        }
        public string GetMorse(string l)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (l == arr[i, 0]) return arr[i, 1];
            }
            return "";
        }
    }
}

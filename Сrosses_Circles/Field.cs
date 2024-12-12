using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_namespace
{
    class Field
    {
        char[,] arr;
        public Field()
        {
            arr = new char[3, 3];
        }
        public override string ToString()
        {
            string res = "";
            for(int k = 0; k < arr.GetLength(0); k++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) res += arr[k, j] + "| ";
                res += "\n________\n";
            }
            return res;
        }
        public void Set(int x, int y, char c)
        {
            if (arr[y, x] != 'o' && arr[y, x] != 'x') arr[y, x] = c;
        }
        public bool IsEmpty(int x, int y) { return arr[y, x] != 'o' && arr[y, x] != 'x'; }
        public int IsEnd()
        {
            for (int i = 0; i < 3; i++)
            {
                if (arr[i, 0] != '\0' && arr[i, 0] == arr[i, 1] && arr[i, 1] == arr[i, 2])
                {
                    return arr[i, 0] == 'x' ? 1 : 2;
                }

                if (arr[0, i] != '\0' && arr[0, i] == arr[1, i] && arr[1, i] == arr[2, i])
                {
                    return arr[0, i] == 'x' ? 1 : 2;
                }
            }

            if (arr[0, 0] != '\0' && arr[0, 0] == arr[1, 1] && arr[1, 1] == arr[2, 2])
            {
                return arr[0, 0] == 'x' ? 1 : 2;
            }

            if (arr[0, 2] != '\0' && arr[0, 2] == arr[1, 1] && arr[1, 1] == arr[2, 0])
            {
                return arr[0, 2] == 'x' ? 1 : 2;
            }

            bool isDraw = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i, j] == '\0')
                    {
                        isDraw = false;
                    }
                }
            }

            if (isDraw) return 3;
            return 0;
        }
    }
}

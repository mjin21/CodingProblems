using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    public class DotProduct
    {
        public int[,] CalculateDotProduct(int[,] a, int[,] b)
        {
            int[,] ret = new int[b.GetLength(1), a.GetLength(0)];

            for(int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    ret[i, j] = CalculateOneSpot(a, b, i, j);
                }
            }

            return ret;
        }

        public int CalculateOneSpot(int[,] a, int[,] b, int x, int y)
        {
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[x,i] * b[i,y]; 
            }

            return sum;
        }
    }
}

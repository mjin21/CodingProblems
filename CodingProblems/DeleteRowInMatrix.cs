using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class DeleteRowInMatrix
    {
        public void DeleteRow(int[,] a)
        {
            for(int i = 0; i< a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    a[i,j] = a[i + 1,j];
                }
            }
        }
    }
}

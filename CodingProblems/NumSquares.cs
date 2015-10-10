using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class NumSquares
    {
        public int SumNumSquares(int n)
        {
            int count = 0;
            double square = 1;

            if (n == 0)
                return 0;
            for (int i = 1; i < n; i++)
            {
                square = Math.Pow(i, 2);

                if (square <= n)
                    count += 1;
                else
                    break;
            }

            return count;
        }
    }
}

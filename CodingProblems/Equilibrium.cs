using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class Equilibrium
    {
        public int Find(int[] a)
        {
            int left = 0;
            int right = 0;
            int equilibrium = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    left += a[j];
                }
                for (int k = i + 1; k < a.Length; k++)
                {
                    right += a[k];
                }
                if (left == right)
                    return equilibrium;
                else
                    equilibrium = i;
            }

            return equilibrium;
        }
    }
}

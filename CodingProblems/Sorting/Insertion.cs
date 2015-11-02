using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Sorting
{
    public class Insertion
    {
        public int[] InsertionSort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (a[j - 1] > a[j])
                    {
                        int tmp = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = tmp;
                    }
                }
            }

            return a;
        }
    }
}

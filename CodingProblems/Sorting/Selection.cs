using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Sorting
{
    public class Selection
    {
        public int[] SelectionSort(int[] a)
        {
            int min = 0;

            for(int i = 0; i < a.Length; i++)
            {
                min = i;

                //find smallest to swap with a[i]
                for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                        min = j;
                }

                //swap if necessary
                if (min != i)
                {
                    int temp = a[i];
                    a[i] = a[min];
                    a[min] = temp;
                }
            }
            return a;
        }
    }
}

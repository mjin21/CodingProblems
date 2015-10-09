using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class ShiftList
    {
        public void Shift(List<int> a, int shift)
        {
            for(int i = 0; i < a.Count; i++)
            {
                if (a[i] < shift)
                    break;
                else
                {
                    for(int j = i + 1; j < a.Count; j++)
                    {
                        if (a[i] < a[j])
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                            continue;
                        }
                    }
                }
            }
        }
    }
}

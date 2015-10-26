using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class CompressWords
    {
        public string Compress(string a)
        {
            string ret = "";
            for(int i = 0; i < a.Length; i++)
            {
                int j = i + 1;
                int count = 1;
                while(a[i] == a[j])
                {
                    count++;
                    j++;
                }

                if (count > 1)
                    ret += a[i] + count;
                else
                    ret += a[i];
            }

            return a;
        }

        public string CompressAlt(string a)
        {
            string ret = "";
            char last = a[0];

            int count = 1;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == last)
                   count++;
                else
                {
                    ret += last + count;
                    last = a[i];
                    count = 1;
                }
            }

            return a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingProblems
{
    class TicTacToe
    {
        public bool Won(int[] results)
        {
            bool won = false;

            //Check 3 rows
            //Check 3 columns
            //Check 2 diaganols


            int n = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            Console.WriteLine('a');
            return won;
        }

        //static int count_runs(string target)
        //{
        //    Dictionary<char, int> counts = new Dictionary<char, int>();
        //    foreach(char c in target)
        //    {
        //        var toLower = char.ToLower(c);

        //        if (counts.ContainsKey(c))
        //            counts[c] = counts[c] + 1;
        //        else
        //            counts.Add(c, 1);
        //    }
        //    int total = counts.Where(c => c.Value > 1).Count();

        //    return total;
        //}

        static int count_runs(string target)
        {
            target.Replace(" ", string.Empty);

            int total = 0;

            for(int i = 0; i < target.Length; i++)
            {
                for (int j = i + 1; j < target.Length; j++)
                {
                    bool same = false;
                    if (!same && char.ToLower(target[i]) == char.ToLower(target[j]))
                    {
                        total++;
                        same = true;
                    }
                    else if (!same && char.ToLower(target[i]) != char.ToLower(target[j]))
                        break;
                    else if (same && char.ToLower(target[i]) == char.ToLower(target[j]))
                        continue;
                    else if (same && char.ToLower(target[i]) != char.ToLower(target[j]))
                        break;
                    else
                    {
                        i = j;
                        break;
                    }
                }
            }
        
            return total;
        }
    }
}
//using System;
//namespace Solution
//{
//    class Solution
//    {
//        static void Main(string[] args)
//        {
//            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
//            int n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    if (j >= n - i - 1)
//                        Console.Write('#');
//                    else
//                        Console.Write(' ');
//                }

//                Console.WriteLine();
//            }
//        }
//    }
//}
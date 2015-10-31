using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    public class StockTrading
    {
        public int FindBestTrade(int[] prices)
        {
            int diff = 0;
            int min = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                    min = prices[i];

                if (prices[i] - min > diff)
                    diff = prices[i] - min;
            }

            return diff;
        }
    }
}

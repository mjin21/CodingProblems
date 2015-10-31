using CodingProblems;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 21,26,28,34,11,17,48}, 37)]
        public void TradingTest(int[] prices, int best)
        {
            StockTrading tradingClass = new StockTrading();
            int bestPrice = tradingClass.FindBestTrade(prices);

            Assert.AreEqual(bestPrice, best);
        }
    }
}

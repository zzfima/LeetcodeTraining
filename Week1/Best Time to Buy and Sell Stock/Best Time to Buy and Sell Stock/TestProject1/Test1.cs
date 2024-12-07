using Best_Time_to_Buy_and_Sell_Stock;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethodBruteForce1()
        {
            StocksBuy stocksBuy = new StocksBuy();

            int[] prices = [7, 1, 5, 3, 6, 4];
            int expected = 5;
            int actual = stocksBuy.BruteForceAlgo(prices);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBruteForce2()
        {
            StocksBuy stocksBuy = new StocksBuy();

            int[] prices = [7, 6, 4, 3, 1];
            int expected = 0;
            int actual = stocksBuy.BruteForceAlgo(prices);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestwoPointersFromEdges1()
        {
            StocksBuy stocksBuy = new StocksBuy();

            int[] prices = [7, 1, 5, 3, 6, 4];
            int expected = 5;
            int actual = stocksBuy.TwoPointersFromEdgesAlgo(prices);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestwoPointersFromEdges2()
        {
            StocksBuy stocksBuy = new StocksBuy();

            int[] prices = [7, 6, 4, 3, 1];
            int expected = 0;
            int actual = stocksBuy.TwoPointersFromEdgesAlgo(prices);

            Assert.AreEqual(expected, actual);
        }

        /*
         * Fail
        [TestMethod]
        public void TestwoPointersFromEdges3()
        {
            StocksBuy stocksBuy = new StocksBuy();

            int[] prices = [2, 1, 2, 1, 0, 2, 1];
            int expected = 0;
            int actual = stocksBuy.TwoPointersFromEdgesAlgo(prices);

            Assert.AreEqual(expected, actual);
        }
        */

        [TestMethod]
        public void TestTwoPointersEachAfter1()
        {
            StocksBuy stocksBuy = new StocksBuy();

            int[] prices = [7, 1, 5, 3, 6, 4];
            int expected = 5;
            int actual = stocksBuy.TwoPointersEachAfterAlgo(prices);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTwoPointersEachAfter2()
        {
            StocksBuy stocksBuy = new StocksBuy();

            int[] prices = [7, 6, 4, 3, 1];
            int expected = 0;
            int actual = stocksBuy.TwoPointersEachAfterAlgo(prices);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTwoPointersEachAfter3()
        {
            StocksBuy stocksBuy = new StocksBuy();

            int[] prices = [2, 1, 2, 1, 0, 2, 1];
            int expected = 2;
            int actual = stocksBuy.TwoPointersEachAfterAlgo(prices);

            Assert.AreEqual(expected, actual);
        }
    }
}

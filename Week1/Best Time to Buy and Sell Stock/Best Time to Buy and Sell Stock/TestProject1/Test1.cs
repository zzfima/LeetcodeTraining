﻿using Best_Time_to_Buy_and_Sell_Stock;

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

			int[] prices = [7,6,4,3,1];
			int expected = 0;
			int actual = stocksBuy.BruteForceAlgo(prices);

			Assert.AreEqual(expected, actual);
		}

				[TestMethod]
		public void TestSlidingWindoweForce1()
		{
			StocksBuy stocksBuy = new StocksBuy();

			int[] prices = [7, 1, 5, 3, 6, 4];
			int expected = 5;
			int actual = stocksBuy.SlidingWindowAlgo(prices);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestSlidingWindowForce2()
		{
			StocksBuy stocksBuy = new StocksBuy();

			int[] prices = [7,6,4,3,1];
			int expected = 0;
			int actual = stocksBuy.SlidingWindowAlgo(prices);

			Assert.AreEqual(expected, actual);
		}
	}
}

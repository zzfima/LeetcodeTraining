namespace Best_Time_to_Buy_and_Sell_Stock
{
	public class StocksBuy
	{
		public int BruteForceAlgo(int[] prices)
		{
			int maxRevenue = 0;

			for (int i = 0; i < prices.Length; i++)
				for (int j = i + 1; j < prices.Length; j++)
					if (prices[j] - prices[i] > maxRevenue)
						maxRevenue = prices[j] - prices[i];

			return maxRevenue;
		}
	}
}

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

		//not always works
		public int TwoPointersFromEdgesAlgo(int[] prices)
		{
			int maxRevenue = prices[prices.Length - 1] - prices[0];

			for (int i = 0, j = prices.Length - 1; i < j;)
			{
				//Select which index moves
				if (prices[j] - prices[i + 1] > prices[j - 1] - prices[i])
					i++;
				else
					j--;

				//calculate new max
				if (prices[j] - prices[i] > maxRevenue)
					maxRevenue = prices[j] - prices[i];
			}

			return maxRevenue;
		}


	}
}

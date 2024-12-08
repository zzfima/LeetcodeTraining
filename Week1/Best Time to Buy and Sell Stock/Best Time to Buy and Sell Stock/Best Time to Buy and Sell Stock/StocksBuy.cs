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

        public int TwoPointersEachAfterAlgo(int[] prices)
        {
            // If prices array is empty or contains only one price, no profit can be made.
            if (prices == null || prices.Length <= 1)
            {
                return 0;
            }

            // Initialize the minimum price to a large value and max profit to 0.
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            // Traverse through the price array
            foreach (int todayPrice in prices)
            {

                // Update the minimum price seen so far.
                if (todayPrice < minPrice)
                {
                    minPrice = todayPrice;
                }

                // Calculate potential profit if selling at the current price.
                int profit = todayPrice - minPrice;

                // Update the maximum profit if the current profit is greater.
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }

            return maxProfit;
        }
    }
}

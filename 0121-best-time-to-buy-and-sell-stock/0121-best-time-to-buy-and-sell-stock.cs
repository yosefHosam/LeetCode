public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices == null || prices.Length == 0)
            return 0;

        int minPrice = prices[0];
        int maxProfit = 0;

        foreach (int currentPrice in prices)
        {
            if (currentPrice < minPrice)
                minPrice = currentPrice;
            else if (currentPrice - minPrice > maxProfit)
                maxProfit = currentPrice - minPrice;
        }

        return maxProfit;
    }
}
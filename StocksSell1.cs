public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length < 2) return 0;
        
        int left = 0; int right = prices.Length - 1;
        int [] maxToRight = new int [prices.Length];
        maxToRight[right] = prices[right];
        right --;
        
        while(right >= 0)
        {
            maxToRight[right] = maxToRight[right + 1] > prices[right] ? maxToRight[right + 1] : prices[right];
            right --;
        }
        
        int diff = 0;
        while(left<prices.Length)
        {
            if(maxToRight[left] - prices[left] > diff)
               {
                   Console.WriteLine(left);
                   diff= maxToRight[left] - prices[left];
               }
            left ++;
        }
        
        return diff;
        
        
    }
}

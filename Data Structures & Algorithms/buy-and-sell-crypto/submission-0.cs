public class Solution {
    public int MaxProfit(int[] prices) {
        int min=int.MaxValue;
        int max=0;
        for(int i=0;i<prices.Length;i++){
            min=Math.Min(min,prices[i]);
            if(min<prices[i]){
                max=Math.Max(max,prices[i]-min);
            }
        }
        return max;
    }
}

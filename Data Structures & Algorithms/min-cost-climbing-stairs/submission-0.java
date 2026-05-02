class Solution {
    Integer dp[];
    public int find(int i,int a[],int n){
        if(i>=n) return 0;
        if(i==n-1) return a[i];
        if(dp[i]!=null) return dp[i];
        return dp[i]=a[i]+Math.min(find(i+1,a,n),find(i+2,a,n));
    }
    public int minCostClimbingStairs(int[] cost) {
        dp=new Integer[cost.length+1];
        return Math.min(find(0,cost,cost.length),find(1,cost,cost.length));
        
    }
}

class Solution {
    Integer dp[];
    public int find(int i,int n){
        if(i>n) return 0;
        if(i==n){
            return 1;
        }
        if(dp[i]!=null) return dp[i];
        return dp[i]=find(i+1,n)+find(i+2,n);


    }
    public int climbStairs(int n) {
        dp=new Integer[n+1];
        return find(0,n);
        
    }
}

class Solution {
    Integer dp[];
    public int find(int i){
        if(i==0) return 0;
        if(i==1 || i==2) return 1;
        if(dp[i]!=null) return dp[i];
        return dp[i]=find(i-1)+find(i-2)+find(i-3);
    }
    public int tribonacci(int n) {
        dp=new Integer[n+1];
        return find(n);
        
        
    }
}
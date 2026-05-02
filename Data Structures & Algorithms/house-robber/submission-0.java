class Solution {
    Integer dp[];
    public int find(int i,int a[]){
        if(i>=a.length) return 0;
        if(dp[i]!=null) return dp[i];
        int take=a[i]+find(i+2,a);
        int skip=find(i+1,a);
        return dp[i]=Math.max(take,skip);
    }
    public int rob(int[] nums) {
        dp=new Integer[nums.length];
        return find(0,nums);
        
    }
}

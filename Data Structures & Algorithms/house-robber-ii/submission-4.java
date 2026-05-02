class Solution {
    Integer dp[];
    public int find(int i,int a[],int n){
        if(i>=n) return 0;
        if(dp[i]!=null) return dp[i];
        int take=a[i]+find(i+2,a,n);
        int skip=find(i+1,a,n);
        return dp[i]=Math.max(take,skip);
    }
    public int rob(int[] nums) {
        if(nums.length==1) return nums[0];
        if(nums.length==2) return Math.max(nums[0],nums[1]);
        dp=new Integer[nums.length];

        int a=find(0,nums,nums.length-1);
                dp=new Integer[nums.length];

        int b=find(1,nums,nums.length);
        return Math.max(a,b);
        
    }
}

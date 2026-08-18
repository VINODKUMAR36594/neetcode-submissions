public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n=nums.Length;
        int[] pf=new int[nums.Length+1];
        int[] sf=new int[nums.Length+1];
        pf[0]=1;
        sf[n]=1;
        for(int i=1;i<n;i++){
            pf[i]=nums[i-1]*pf[i-1];
        }
        for(int i=n-1;i>=0;i--){
            sf[i]=sf[i+1]*nums[i];
        }
        int[] ans=new int[nums.Length];
        for(int i=0;i<n;i++){
            ans[i]=pf[i]*sf[i+1];
        }
        return ans;
    }
}

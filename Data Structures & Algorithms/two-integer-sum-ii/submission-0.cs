public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int i=0,j=nums.Length-1;
        int[] ans=new int[2];
        while(i<j){
            int sum=nums[i]+nums[j];
            if(sum==target){
                ans[0]=i+1;
                ans[1]=j+1;
                break;
            }
            else if(sum>target){
                j-=1;

            }
            else if(sum<target){
                i+=1;
            }
        }
        return ans;
    }
}

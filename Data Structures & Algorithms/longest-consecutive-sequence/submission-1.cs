public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0) return 0;
        SortedSet<int> set = new SortedSet<int>(nums);
        List<int> list = new List<int>(set);
        int c=1,max=0;
        for(int i=0;i<list.Count-1;i++){
            if(list[i]==(list[i+1]-1)){
                c+=1;
            }
            else{
                max=Math.Max(max,c);
                c=1;
            }
        }
        max=Math.Max(max,c);


        return max;
    }
}

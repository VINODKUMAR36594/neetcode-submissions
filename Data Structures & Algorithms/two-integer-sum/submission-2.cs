public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map=new Dictionary<int,int>();
        int[] a=new int[2];
        Array.Fill(a,-1);
        int j=0;
        foreach(int i in nums){
            if(map.ContainsKey(target-i)){
                a[1]=j;
                a[0]=map[target-i];
                return a;
            }
            if(!map.ContainsKey(i)) {
                map.Add(i,j);
            }
            j+=1;
        }
        return a;
    }
}

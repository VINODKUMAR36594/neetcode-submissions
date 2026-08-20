public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> arr = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++) {

            // Skip duplicate first elements
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k) {
                int sum = nums[i] + nums[j] + nums[k];

                if (sum == 0) {
                    arr.Add(new List<int> {
                        nums[i],
                        nums[j],
                        nums[k]
                    });

                    j++;
                    k--;

                    // Skip duplicate second elements
                    while (j < k && nums[j] == nums[j - 1])
                        j++;

                    // Skip duplicate third elements
                    while (j < k && nums[k] == nums[k + 1])
                        k--;
                }
                else if (sum > 0) {
                    k--;
                }
                else {
                    j++;
                }
            }
        }

        return arr;
    }
}
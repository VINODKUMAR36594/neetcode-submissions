class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        p=0
        for i in range(len(nums)+1):
            p^=i
        for j in nums:
            p^=j
        return p


        
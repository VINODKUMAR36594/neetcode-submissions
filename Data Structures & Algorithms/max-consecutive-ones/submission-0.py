class Solution:
    def findMaxConsecutiveOnes(self, nums: List[int]) -> int:
        ma=0
        r=0
        for i in nums:
            if i==1:
                r+=1
            else:
                ma=max(r,ma)
                r=0
        return max(r,ma)

        
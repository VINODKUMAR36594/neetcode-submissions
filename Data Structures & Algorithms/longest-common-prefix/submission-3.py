class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        s=strs[0]
        b=False
        for i in range(len(strs[0])):
            b=False
            for j in strs:
                if i>=len(j) or j[i]!=s[i]:
                    b=True
            if b:
                return s[0:i]
        if(b==False):
            return s
        return ""
class Solution:
    def countSeniors(self, details: List[str]) -> int:
        c=0
        for s in details:
            print(s[11:13])
            if int(s[11:13])>60:
                c+=1
        return c
        
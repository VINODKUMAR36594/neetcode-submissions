class Solution:
    
    def countBits(self, n: int) -> List[int]:
        l=[]
        def se(r):
            c=0
            while r!=0:
                r=(r&(r-1))
                c+=1
            return c
        for i in range(0,n+1):
            l.append(se(i))
        return l
        
class Solution:
    def reverse(self, x: int) -> int:
        # print(x)
        q=x
        x=abs(x)
        l=(2**31)-1
        nega=False
        if q<0:
            nega=True
        r=0
        while x!=0:
            r=r*10+(x%10)
            x//=10
        if r>=l:
            return  0
        if nega:
            r*=-1
        return r

        
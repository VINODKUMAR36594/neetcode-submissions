class Solution:
    def addBinary(self, a: str, b: str) -> str:
        a1=int(a,2)
        b1=int(b,2)
        su=a1+b1
        if len(a)<len(b):
            while len(a)!=len(b):
                a="0"+a
            print(a,b)
        if len(b)<len(a):
            while len(a)!=len(b):
                b="0"+b
        q=0
        a=a[::-1]
        b=b[::-1]
        return bin(su)[2:]


            
        
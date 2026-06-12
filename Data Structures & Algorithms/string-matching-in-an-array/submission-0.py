class Solution:
    def stringMatching(self, words: List[str]) -> List[str]:
        l=[]
        for i in words:
            for j in words:
                if i==j:
                    continue
                if len(j)>len(i):
                    continue
                p,q=0,len(j)
                while q<=len(i):
                    if i[p:q]==j:
                        if j not in l:
                            l.append(j)
                    p+=1
                    q+=1
        return l
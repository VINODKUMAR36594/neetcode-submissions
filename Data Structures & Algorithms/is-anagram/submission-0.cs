public class Solution {
    public bool IsAnagram(string s, string t) {

            if(s.Length!=t.Length) return false;
            Dictionary<char,int> map=new Dictionary<char,int>();
            Dictionary<char,int> p2=new Dictionary<char,int>();
            for(int i=0;i<s.Length;i++){
                if(!map.ContainsKey(s[i])){
                    map.Add(s[i],1);
                }
                else{
                    map[s[i]]+=1;
                }
                if(!p2.ContainsKey(t[i])){
                    p2.Add(t[i],1);
                }
                else{
                    p2[t[i]]+=1;
                }
            }
            foreach(var c in map){

                if(!p2.ContainsKey(c.Key) || map[c.Key]!=p2[c.Key]) return false;
                if(map[c.Key]!=p2[c.Key]) return false;
            }
            return  true;
            }
    }
            


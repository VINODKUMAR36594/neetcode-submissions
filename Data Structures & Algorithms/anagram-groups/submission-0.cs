public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map=new Dictionary<string,List<string>>();
        foreach(string s in strs){
            //haha
            char[] cf=s.ToCharArray();
            Array.Sort(cf);
            string p=new string(cf);
            if(!map.ContainsKey(p)){
                map.Add(p,new List<string>());
            }
            map[p].Add(s);
            
        }
        List<List<string>> ans=new List<List<string>>();
        foreach(var c in map){
            ans.Add(c.Value);
        }
        return ans;

    }
}

class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        HashMap<String,List<String>> map=new HashMap<>();
        for(String s:strs){
            char p[]=s.toCharArray();
            Arrays.sort(p);
String next = new String(p);
            if(!map.containsKey(next)){
                map.put(next,new ArrayList<String>());
            }
            map.get(next).add(s);
        }
        List<List<String>> ans=new ArrayList<>();
        for(String m:map.keySet()){
            System.out.println(m);
            ans.add(map.get(m));
        }
        return ans;
        
    }
}

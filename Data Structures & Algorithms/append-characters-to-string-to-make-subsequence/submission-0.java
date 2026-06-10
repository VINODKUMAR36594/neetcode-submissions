class Solution {
    public int appendCharacters(String s, String t) {
        int i=0;
        for(char c:s.toCharArray()){
            if(i<t.length() && c==t.charAt(i)){
                i+=1;
            }
        }
        return t.length()-i;
    }
}
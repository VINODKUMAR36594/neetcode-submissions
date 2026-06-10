class Solution {
    public int lengthOfLastWord(String s) {
        String ps[]=s.split("\\s+");
        return ps[ps.length-1].length();

    }
}
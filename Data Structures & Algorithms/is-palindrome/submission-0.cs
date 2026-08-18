public class Solution {
    public bool IsPalindrome(string s) {
        s=s.ToLower();
        string re="";
        foreach(char c in s){
            if(char.IsLetterOrDigit(c)){
                re+=c;
            }

        }
        string n=re.Replace(" ","");
        string rev=new string(re.Reverse().ToArray());
        if(rev.Equals(n)){
            return true;
        }
        return false;
    }
}

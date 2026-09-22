public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0;
        int j = s.Length-1;

        while(j>i)
        {
            while(j>i && !char.IsAsciiLetterOrDigit((s[i]))){i++;}
            while(j>i && !char.IsAsciiLetterOrDigit((s[j]))){j--;}
            if(char.ToLower(s[i]) != char.ToLower(s[j])){return false;}
            i++;
            j--;
        }
        return true;
    }
}
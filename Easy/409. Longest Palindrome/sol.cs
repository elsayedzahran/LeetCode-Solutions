public class Solution {
    public int LongestPalindrome(string s) {
        int[] alpha=Enumerable.Repeat(0,170).ToArray();
        foreach(var i in s)
        {
            alpha[i]++;
        }
        int res=0,odd=0;
        foreach(var item in alpha){
            if (item%2==1) odd++;
            res+=item;
        }
        if (odd>0) res-=(odd-1);
        return res;
    }
}

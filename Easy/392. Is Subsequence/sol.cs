public class Solution {
    public bool IsSubsequence(string s, string t) {
        int sz=s.Length,tz=t.Length;
        int it=0;
        for (int i=0;i<tz&&it!=sz;i++)
        {
            if (s[it]==t[i])
            {
                it++;
            }
        }
        if (it==sz) return true;
        return false;
    }
}

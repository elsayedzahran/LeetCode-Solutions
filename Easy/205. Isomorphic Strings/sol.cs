public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,char> mp=new Dictionary<char,char>();
        int n=s.Length;
        for(int i=0;i<n;i++)
        {
            if(!mp.ContainsKey(s[i]))
            {
                 if (mp.ContainsValue(t[i])) return false;
                 mp.Add(s[i],t[i]);
            }
            else if (mp[s[i]]!=t[i]) return false;
        }
        return true;
    }
}

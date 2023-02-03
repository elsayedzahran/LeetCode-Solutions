public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] mp=new int[250];
        int res = 0, cur_res = 0;
        int end = 0;
        for (int i = 0; i < s.Length ; i++)
        {
            mp[s[i]]++;
            cur_res = Math.Max(cur_res , mp[s[i]]);
            while (i-end+1-cur_res > k) mp[s[end++]]--;
            res = Math.Max(i-end+1 , res);
        }
        return res;
    }
}

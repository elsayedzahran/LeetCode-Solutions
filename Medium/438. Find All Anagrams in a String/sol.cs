public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        if (p.Length > s.Length) return new List<int>();
        var res=new List<int>();
        int[] mp=new int[150];
        foreach (var ch in p) mp[ch]++;
        var temp = new int[150];
        for (var i = 0; i < s.Length; i++)
        {
            temp[s[i]]++;
            if (i >= p.Length-1)
            {
                var index = i - (p.Length - 1);
                if (mp.SequenceEqual(temp))
                {
                    res.Add(index);
                }

                temp[s[index]]--;
            }
        }
        return res;
    }
}

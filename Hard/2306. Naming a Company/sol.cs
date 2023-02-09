public class Solution {
    public long DistinctNames(string[] ideas) {
         var map = new Dictionary<string, List<char>>();
        for (int i = 0; i < ideas.Length; i++)
        {
            string suffix = ideas[i].Substring(1);
            if (!map.ContainsKey(suffix)) map.Add(suffix, new List<char>());
            map[suffix].Add(ideas[i][0]);
        }
        int[,] cur = new int[26, 26];
        foreach(var values in map.Values)
            foreach(var value in values)
                foreach(var idx in values)
                    cur[value-'a',idx-'a']++;
        
        long res = 0;
        for(int i = 0; i < 26; i++)
            for (int j = 0; j < 26; j++)
                res += (cur[i, i] - cur[i, j]) * (cur[j, j] - cur[i, j]);
        
        return res;
    }
}

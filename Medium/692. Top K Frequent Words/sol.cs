public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        var res=new List<string>(k);
        var map = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (!map.ContainsKey(word)) map.Add(word,0);
            map[word]++;
        }
        var resList = map.ToList();
        resList.Sort((p1, p2)=>{
            if(p2.Value - p1.Value == 0) return String.Compare(p1.Key, p2.Key);
            return p2.Value - p1.Value;
        });
        int i = 0;
        foreach(var n in resList){
            res.Add(n.Key);
            if(++i == k) return res;
        }
        return null;
    }
}

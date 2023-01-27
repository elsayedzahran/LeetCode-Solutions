public class Solution {
    public IList<string> FindAllConcatenatedWordsInADict(string[] words) 
    {
        var set = new HashSet<string>();
        var res = new List<string>();
        
        foreach(var word in words) set.Add(word);

        foreach(var word in words) 
        {
            if (DFS( 0, 0, words, word, set)) 
            {
                res.Add(word);
            }
        }
        return res;
    }
    bool DFS(int idx,int cnt,string[] words,string word,HashSet<string> set)
    {
        if (idx==word.Length) return cnt>1;
        string temp="";
        for(int i=idx;i<word.Length;i++)
        {
            if (set.Contains(word.Substring(idx, i-idx+1)) && 
                DFS(i+1, cnt+1,words, word, set )) {
                return true;
            }
        }
        return false;
    }
}

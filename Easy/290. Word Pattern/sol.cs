public class Solution {
    public bool WordPattern(string pattern, string s) {
        var map1 = new Dictionary<char,string>();
        var map2 = new Dictionary<string,char>();
        var sList = s.Split(' ', StringSplitOptions.None);
        if(pattern.Length != sList.Count()) return false;
        
      for(int i = 0 ; i < sList.Count() ; i++){
        map1.TryAdd(pattern[i], sList[i]);
        map2.TryAdd(sList[i],pattern[i]);
        if(map1[pattern[i]] != sList[i]) return false;
        if(map2[sList[i]] != pattern[i]) return false;
      }
        return true;
    }
}

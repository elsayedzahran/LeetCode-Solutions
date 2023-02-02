public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        if (words.Length==1) return true;
        int[] ord=new int[26];
        for (int i = 0 ; i < order.Length ; i++) ord[order[i]-'a'] = i+1;
        for (int j = 0 ; j < words.Length-1 ; j++)
        {
            string cur = words[j];
            string next = words[j+1];
            int n = cur.Length , m = next.Length;
            for(int i = 0 ; i < n ; i++)
            {
                if (i >= m) return false;
                if (ord[cur[i]-'a'] < ord[next[i]-'a']) break;
                if (ord[cur[i]-'a'] > ord[next[i]-'a']) return false;
            }
        }
        return true;
    }
}

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;
        int[] frq=new int[150];
        int cnt=0;
        foreach (var ch in s1)
        {
            if (frq[ch]==0) cnt++;
            frq[ch]++;
        }
        int[] tst=new int[150];
        for (int i = 0 ; i < s1.Length ; i++)
        {
            tst[s2[i]]++;
            if (tst[s2[i]]==frq[s2[i]]) cnt--;
        }
        if (cnt==0) return true;
        int l=1, r=s1.Length;
        while (r < s2.Length)
        {
            if (frq[s2[l-1]] == tst[s2[l-1]] && tst[s2[l-1]] != 0) cnt++;
            tst[s2[l-1]]--;
            tst[s2[r]]++;
            if (tst[s2[r]] == frq[s2[r]]  && tst[s2[r]] != 0) cnt--;
            if (cnt==0) return true;
            r++;
            l++;
        }
        return false;
    }
}

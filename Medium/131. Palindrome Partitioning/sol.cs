public class Solution {
    public IList<IList<string>> Partition(string s) {
        var res=new List<IList<string>>();
        solve(0,s,res,new List<string>());
        return res;
    }
    void solve(int idx,string s,List<IList<string>> res, List<string> list)
    {
        if (idx==s.Length)
        {
            res.Add(new List<String>(list));
        }
        string dumb="";
        for (int i = idx; i < s.Length; i++){  
            dumb += s[i];
            if (valid(dumb))
            {
                list.Add(dumb);
                solve(i+1,s,res,list);
                list.RemoveAt(list.Count-1);
            }
        }
    }
    bool valid(string k)
    {
        int l=0,r=k.Length-1;
        while(l<r)
        {
            if (k[l]!=k[r]) return false;
            l++;
            r--;
        }
        return true;
    }
}

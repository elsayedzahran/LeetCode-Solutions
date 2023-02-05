public class Solution {
    public bool BackspaceCompare(string s, string t) {
        var st = new Stack<char>();
        var tt = new Stack<char>();
        foreach (var ch in s)
        {
            if (ch == '#' && st.Count > 0) st.Pop();
            if (ch != '#') st.Push(ch);
        }
        foreach (var ch in t)
        {
            if (ch == '#' && tt.Count > 0) tt.Pop();
            if (ch != '#') tt.Push(ch);
        }
        string res1="",res2="";
        foreach (var ch in st) res1 += ch;
        foreach (var ch in tt) res2 += ch;
        return res1 == res2? true : false;
    }
}

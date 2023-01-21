public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        string k=s;
        List<string> res = new List<string>();
        for(int a=0;a<4;a++)
        for(int b=0;b<4;b++)
        for(int c=0;c<4;c++)
        {
            int d=k.Length-a-b-c;
            if (d>0&&d<4)
            {
                try{
                int A = int.Parse(k.Substring(0, a));
                int B = int.Parse(k.Substring(a, b));
                int C = int.Parse(k.Substring(a + b, c));
                int D = int.Parse(k.Substring(a + b + c, d));
                if (D < 256 && A < 256 && B < 256 && C < 256)
                {
                    string ans= $"{A}.{B}.{C}.{D}";
                    if (ans.Length == s.Length + 3) res.Add(ans);
                }
                }
                catch{}
            }
        }
        return res;
    }
    
}

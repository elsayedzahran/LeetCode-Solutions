public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        string low;
        string high;
        if (str1.Length<=str2.Length)
        {
            low=str1;
            high=str2;
        }
        else
        {
            low=str2;
            high=str1;
        }
        string res="";
        for (int k=1;k<=low.Length;k++)
        {
            if (high.Length%k!=0||low.Length%k!=0) continue;
            string test=low.Substring(0,k);
            bool isDivisable=true;
            for(int i=0;i<low.Length;i++) if (low[i]!=test[i%k]) {isDivisable=false;break;}
            for(int i=0;i<high.Length;i++) if (high[i]!=test[i%k]) {isDivisable=false;break;}
            if (isDivisable) res=test;
        }
        return res;
    }
}

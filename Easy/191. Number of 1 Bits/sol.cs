public class Solution {
    public int HammingWeight(uint n) {
        int res=0;
        Console.WriteLine(n);
        while(n>0)
        {
            if (n%2==1) res++;
            n/=2;
        }
        return res;
    }
}

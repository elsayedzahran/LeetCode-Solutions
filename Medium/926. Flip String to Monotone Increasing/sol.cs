public class Solution {
    public int MinFlipsMonoIncr(string s) {
        int countFlip=0;
        foreach(var i in s) if (i=='0') countFlip++;
        int counter=countFlip;
        Console.WriteLine(counter);
        foreach(var i in s)
        {
            if (i=='0') {countFlip=Math.Min(countFlip,--counter);}
            else counter++;
        }
        return countFlip;
    }
}

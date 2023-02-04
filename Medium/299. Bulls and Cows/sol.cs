public class Solution {
    public string GetHint(string secret, string guess) {
        var frq=new int[150,2];
        int bull=0,cow=0;
        for (int i = 0 ; i < secret.Length ; i++)
        {
            if (secret[i] == guess[i]) bull++;
            else{
                frq[secret[i],0]++;
                frq[guess[i],1]++;
            }
        }
        for (int i = 0 ; i < frq.GetLength(0) ; i++)
        {
            cow += Math.Min(frq[i, 0], frq[i, 1]);
        }
        return $"{bull}A{cow}B";

    }
}

public class Solution {
    public bool DetectCapitalUse(string word) {
        int upperCount = 0, lowerCount = 0, n = word.Length;
        for(int i = 0; i < n; i++){
            if(Char.IsUpper(word[i]))
                upperCount++;
            else
                lowerCount++;
        }
        return upperCount == n || lowerCount == n || (Char.IsUpper(word[0]) && lowerCount == n-1);
    }
}

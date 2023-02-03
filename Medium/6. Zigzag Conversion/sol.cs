public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows==1) return s;
        string[] res=new string[numRows];
        bool moveDown = true;
        int rowIdx = 0;
        
        foreach (var ch in s) 
        {
            res[rowIdx] += ch;
            
            if (rowIdx == numRows - 1)
                moveDown = false;
            else if (rowIdx == 0)
                moveDown = true;

            rowIdx += (moveDown ? 1 : -1);
        }
        string ans="";
        foreach(var xx in res){ ans += xx; }
        return ans;
    }
}

public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        int n = num.Length - 1, carry = k;
        var res = new List<int>();
        while (n >= 0 || carry > 0)
        {
            if (n >= 0) carry += num[n--];
            res.Add(carry % 10);
            carry /= 10;
        }
        res.Reverse();
        return res;
    }
}

public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 2) return n == 2 ? 2 : 1 ;
        int[] arr=new int[n];
        arr[1] = 1;
        arr[2] = 2;
        for (int i=3 ; i < n ; i++) arr[i] = arr[i-1] +arr[i-2];
        return arr[n-1]+arr[n-2];
    }
}

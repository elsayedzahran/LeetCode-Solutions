public class Solution {
    public int Tribonacci(int n) {
        if (n<=2) return n>0?1:0;
        int res=0;
        int[] arr=new int[n+1];
        arr[0]=0;
        arr[1]=arr[2]=1;
        for(int i=3;i<=n;i++)
        {
            arr[i]=arr[i-1]+arr[i-2]+arr[i-3];
        }
        return arr[n];
    }
}

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int l=1,r=n,res=-1;
        while(l<=r)
        {
            int mid=(r-l)/2+l;
            if (IsBadVersion(mid))
            {
                res=mid;
                r=mid-1;
            }
            else l=mid+1;
        }
        return res;
    }
}

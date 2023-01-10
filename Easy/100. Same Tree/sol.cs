/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        bool flag=true;
        flag=Traverse(p,q);
        return flag;
    }
    public static bool Traverse(TreeNode p, TreeNode q) {
        if (p==null&&q==null) return true;
        else if (p==null||q==null) return false;
        return p.val==q.val&&Traverse(p.left,q.left)&&Traverse(p.right,q.right);
    }
}

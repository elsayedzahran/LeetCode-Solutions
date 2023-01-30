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
    public bool IsValidBST(TreeNode root) {
        return traverse(root , Int64.MaxValue , Int64.MinValue);
    }
    bool traverse(TreeNode node,long max,long min)
    {
        if (node==null) return true;
        return node.val < max && node.val > min 
        && traverse(node.left , node.val , min)
        && traverse(node.right , max , node.val);
    }
}

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
    public static List<int> ans=new List<int>();
    public IList<int> PreorderTraversal(TreeNode root) {
        ans.Clear();
        Traverse(root);
        return ans;
    }
    public static void Traverse(TreeNode root)
    {
        if (root==null) return;
        ans.Add(root.val);
        Traverse(root.left);
        Traverse(root.right);
    }
}
